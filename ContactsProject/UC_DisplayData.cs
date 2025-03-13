using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ContactsProject
{
    public partial class UC_DisplayData : UserControl
    {
        private enum enDisplayMode {ShortData, AllData}
        private enum enDisplayFilter {ContactsID = 0, ContactsFirstName = 1, ContactsLastName = 2,ContactsEmail = 3,ContactsPhone = 4,
                ContactsAddress = 5, ContactBirthDate = 6, ContactsCountryID = 7, ContactsImagePath = 8, AllContacts = 9}

        enDisplayMode _Mode = enDisplayMode.ShortData;

        enDisplayFilter _FilterMode = enDisplayFilter.AllContacts;

        private string _FilterText = "";
        public UC_DisplayData()
        {
            InitializeComponent();
        }
        //Methods
        private void _FillData()
        {
            if (_Mode == enDisplayMode.ShortData)
                dgvContactsData.DataSource = clsContact.GetContacts();
            else
                dgvContactsData.DataSource = clsContact.GetFullDetails();
        }
        private void _FillData(string columnName, string cellValue, bool isLike = true)
        {
            if (_Mode == enDisplayMode.ShortData)
                dgvContactsData.DataSource = clsContact.GetContacts(columnName,cellValue,isLike);
            else
                dgvContactsData.DataSource = clsContact.GetFullDetails(columnName,cellValue,isLike);
        }
        private void _FillData(int contactID)
        {
            if (_Mode == enDisplayMode.ShortData)
                dgvContactsData.DataSource = clsContact.GetContact(contactID);
            else
                dgvContactsData.DataSource = clsContact.GetContactFullDetails(contactID);
        }
        private void _RefreshContactsList()
        {
            switch (_FilterMode)
            {
                case enDisplayFilter.ContactsID:
                    if(int.TryParse(_FilterText,out int contactID))
                        _FillData(contactID);
                    break;
                case enDisplayFilter.ContactsFirstName:
                    _FillData("FirstName", _FilterText);
                    break;
                case enDisplayFilter.ContactsLastName:
                    _FillData("LastName",_FilterText); 
                    break;
                case enDisplayFilter.ContactsEmail:
                    _FillData("Email", _FilterText);
                    break;
                case enDisplayFilter.ContactsPhone:
                    _FillData("Phone", _FilterText);
                    break;
                case enDisplayFilter.ContactsAddress:
                    _FillData("Address", _FilterText);
                    break;
                case enDisplayFilter.ContactBirthDate:
                    _FillData("DateOfBirth", _FilterText);
                    break;
                case enDisplayFilter.ContactsCountryID:
                    if (int.TryParse(_FilterText,out int countryID))
                        _FillData("CountryID", _FilterText,false);
                    break;
                case enDisplayFilter.ContactsImagePath:
                    _FillData("ImagePath", _FilterText);
                    break;
                case enDisplayFilter.AllContacts:
                    _FillData();
                    break;
                default:
                    _FillData();
                    break;
            }
        }
        public void ChangeMode(int index)
        {
            _Mode = (enDisplayMode)index;
            _RefreshContactsList();
        }
        public void RefreshData()
        {
            _RefreshContactsList();
        }
        public void ChangeFilter(int cbIndex, string sFilter)
        {
            if (sFilter != "")
            {
                _FilterMode = (enDisplayFilter)cbIndex;
                _FilterText = sFilter;
            }
            else
                _FilterMode = (enDisplayFilter.AllContacts);
        }

        //Events
        private void UC_DisplayData_Load(object sender, EventArgs e)
        {
            _RefreshContactsList();

            //Scroll Treatment يجعل التمرير اكثر سلاسة ويقلل الوميض
            typeof(DataGridView).InvokeMember("DoubleBuffered",
            System.Reflection.BindingFlags.NonPublic |
            System.Reflection.BindingFlags.Instance |
            System.Reflection.BindingFlags.SetProperty,
            null, dgvContactsData, new object[] { true });

            dgvContactsData.VirtualMode = true;
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditContact frmEdit = new frmAddEditContact((int)dgvContactsData.CurrentRow.Cells[0].Value);
            frmEdit.ShowDialog();
            _RefreshContactsList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this person?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsContact.DeleteContact((int)dgvContactsData.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Contact deleted successfully", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshContactsList();
                    frmContactsManagement.CompletedTasks++;
                }
                else
                {
                    MessageBox.Show("Contact not deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmContactsManagement.InCompletedTasks++;
                }
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _RefreshContactsList();
        }
    }
}