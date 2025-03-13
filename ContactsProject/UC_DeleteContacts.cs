using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsProject
{
    public partial class UC_DeleteContacts : UserControl
    {
        private clsContact _FoundContact;

        public UC_DeleteContacts()
        {
            InitializeComponent();
        }
        //Methods
        private void _LoadImage(clsContact contact)
        {
            if (contact.ImagePath != "")
                try
                {
                    picboxImage.Load(contact.ImagePath);
                }
                catch
                {
                    picboxImage.Image = null;
                }
            else
                picboxImage.Image = null;
        }

        private void _FillInfo(clsContact contact)
        {
            lblOutputName.Text = $"{contact.FirstName} {contact.LastName}";
            int age = (int)Math.Floor((DateTime.Today - contact.BirthDate).Days / 365.2425);
            if (age > 0)
                lblOutputAge.Text = $"{(int)Math.Floor((DateTime.Today - contact.BirthDate).Days / 365.2425)}";
            else
                lblOutputAge.Text = "";
            lblOutputPhone.Text = $"{contact.Phone}";
            _LoadImage(contact);            
        }

        //Events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbContactID.Text, out int contactID))
            {
                if (clsContact.IsContactExist(contactID))
                {
                    _FoundContact = clsContact.FindContact(contactID);
                    _FillInfo(_FoundContact);
                }
                else
                {
                    MessageBox.Show($"No contact with ID {contactID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _FoundContact = new clsContact();
                    _FillInfo(_FoundContact);
                }
            }

            else
            {
                MessageBox.Show("Make sure the fields contain valid data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txbContactID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void txbContactID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbContactID.Text))
                lblContactID.Visible = true;
            else
                lblContactID.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete this person?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsContact.DeleteContact(_FoundContact))
                {
                    MessageBox.Show("Contact deleted successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmContactsManagement.CompletedTasks++;
                }
                else
                {
                    MessageBox.Show("Contact not deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmContactsManagement.InCompletedTasks++;
                }
            }
        }
    }
}
