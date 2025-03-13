using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContactsProject
{
    public partial class frmAddEditContact : Form
    {
        private clsContact _Contact;
        private int _ContactID = -1;
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode;
        public frmAddEditContact(int contactID)
        {
            InitializeComponent();
            _ContactID = contactID;
            if (_ContactID == -1)
                Mode = enMode.AddNew;
            else
                Mode = enMode.Update;

            _LoadData();
            txbFirstName.Validating += _ValidateTextBox;
            txbLastName.Validating += _ValidateTextBox;
            txbEmail.Validating += _ValidateTextBox;
            txbPhone.Validating += _ValidateTextBox;
            txbAddress.Validating += _ValidateTextBox;
        }

        //----------------------------------- Private Methods -----------------------------------
        private void _FillCountriesInComboBox()
        {
            cbCountry.Items.Clear();
            DataTable countries = clsCountry.GetAllCountries();
            foreach (DataRow country in countries.Rows)
            {
                cbCountry.Items.Add(country["CountryName"]);
            }
        }
        private void _LoadImage()
        {
            if (_Contact.ImagePath != "")
                try
                {
                    picboxImage.Load(_Contact.ImagePath);
                }
                catch
                {
                    picboxImage.Image = null;
                }
            else
                picboxImage.Image = null;
            llRemove.Visible = (_Contact.ImagePath != "");
        }
        private void _LoadImage(string imgPath)
        {
            if (imgPath != "")
            {
                try
                {
                    picboxImage.Load(imgPath);
                }
                catch
                {
                    picboxImage.Image = null;
                }
            }
            else
                picboxImage.Image = null;
            llRemove.Visible = (imgPath != "");
        }
        private void _FillContactFromBoxes()
        {
            if (!string.IsNullOrWhiteSpace(txbFirstName.Text))
                _Contact.FirstName = txbFirstName.Text;
            else
                _Contact.FirstName = null;

            if (!string.IsNullOrWhiteSpace(txbLastName.Text))
                _Contact.LastName = txbLastName.Text;
            else
                _Contact.LastName = null;

            if (!string.IsNullOrWhiteSpace(txbEmail.Text))
                _Contact.Email = txbEmail.Text;
            else
                _Contact.Email = null;

            if (!string.IsNullOrWhiteSpace(txbPhone.Text))
                _Contact.Phone = txbPhone.Text;
            else
                _Contact.Phone = null;

            _Contact.BirthDate = dtpBirthDate.Value;
            _Contact.CountryID = (int)clsCountry.FindCountry(cbCountry.Text).CountryID;

            if (!string.IsNullOrWhiteSpace(txbAddress.Text))
                _Contact.Address = txbAddress.Text;
            else
                _Contact.Address = null;

            if (picboxImage.ImageLocation != null)
                _Contact.ImagePath = picboxImage.ImageLocation;
            else
                _Contact.ImagePath = "";
        }
        private void _FillBoxesFromContactToUpdate()
        {
            //txbContactID.Text = _ContactID.ToString();
            txbFirstName.Text = _Contact.FirstName;
            txbLastName.Text = _Contact.LastName;
            txbEmail.Text = _Contact.Email;
            txbPhone.Text = _Contact.Phone;
            dtpBirthDate.Value = _Contact.BirthDate;
            cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.FindCountry(_Contact.CountryID).CountryName.ToString()); //## Try it
            txbAddress.Text = _Contact.Address;
            _LoadImage();
        }
        private void _LoadData()
        {
            _FillCountriesInComboBox();
            cbCountry.SelectedIndex = 0;

            switch (Mode)
            {
                case enMode.AddNew:
                    lblAddEditContact.Text = "Add New Contact";
                    _Contact = new clsContact(); //To Make Mode add new in clsCountry Class
                    llRemove.Visible = false;
                    break;

                case enMode.Update:
                    if (clsContact.IsContactExist(_ContactID))
                    {
                        _Contact = clsContact.FindContact(_ContactID);

                        if (_Contact == null)
                        {
                            MessageBox.Show($"This Form will be closed because no contact with ID = {_ContactID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                            return;
                        }

                        lblAddEditContact.Text = $"Edit contact with ID: {_ContactID}";
                        _FillBoxesFromContactToUpdate();
                    }
                    else
                    {
                        MessageBox.Show($"This Form will be closed because no contact with ID = {_ContactID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }
                    break;
            }
        }

        private void _ValidateTextBox(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
                errorProvider1.SetError(textBox, "This field is required!");
            else
                errorProvider1.SetError(textBox, ""); //No error
        }

        //----------------------------------- Events -----------------------------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save this changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _FillContactFromBoxes();
                if (_Contact.Save())
                {
                    MessageBox.Show($"Data Saved Successfully\nContact ID: {_Contact.ContactID}", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmContactsManagement.CompletedTasks++;
                    Mode = enMode.Update;
                    lblAddEditContact.Text = $"Edit contact with ID: {_Contact.ContactID}";
                }
                else
                {
                    MessageBox.Show("Data not saved, make sure to fill in the fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmContactsManagement.InCompletedTasks++;
                }
            }
        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _Contact.ImagePath = "";
            _LoadImage();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Insert Image";
                openFileDialog.Filter = "All Images |*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imgPath = openFileDialog.FileName;
                    _LoadImage(imgPath);
                }
            }
        }
    }
}
