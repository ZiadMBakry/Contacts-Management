using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ContactsBusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace ContactsProject
{
    public partial class frmContactsManagement : Form
    {
        private UC_DisplayData ucDisplayData;
        private UC_DashBoard ucDashBoard;
        private UC_DeleteContacts ucDeleteContact;
        private UC_UpdateContact ucUpdateContact;
        private UC_AddContact ucAddContact;

        private Button _btnActiveButton;

        public static int CompletedTasks = 0;
        public static int InCompletedTasks = 0 ;

        public frmContactsManagement()
        {
            InitializeComponent();
        }
        //Methods
        private void _FillFilterComboBox()
        {
            cbFilter.Items.Clear();
            DataTable columns = clsContact.GetColumnsName();
            foreach (DataRow col in columns.Rows)
            {
                cbFilter.Items.Add(col["COLUMN_NAME"]);
            }
        }
        private void _LoadUserControl(UserControl userControl, bool filterVisible = false)
        {
            pnlFilter.Visible = filterVisible;
            if (filterVisible)
                _FillFilterComboBox();

            pnlContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControl);
        }

        private void _MakeActiveButton(Button btnActive)
        {
            btnActive.FlatAppearance.BorderSize = 0;
            btnActive.BackColor = Color.LightGray;
            btnActive.ForeColor = Color.Black;
            btnActive.FlatStyle = FlatStyle.Standard;
        }
        private void _MakeInactiveButton(Button btnLastActive)
        {
            btnLastActive.FlatAppearance.BorderSize = 1;
            btnLastActive.BackColor = Color.DimGray;
            btnLastActive.ForeColor = Color.White;
            btnLastActive.FlatStyle = FlatStyle.Flat;

        }

        private void _ChangeActivation(Button btnActive)
        {
            if (_btnActiveButton != null)
                _MakeInactiveButton(_btnActiveButton);
            _btnActiveButton = btnActive;
            _MakeActiveButton(btnActive);
        }

        private void _LinkLabel_MouseEnter(object sender, EventArgs e)
        {
            LinkLabel lbl = sender as LinkLabel;
            lbl.LinkColor = Color.RoyalBlue;
        }

        private void _LinkLabel_MouseLeave(object sender, EventArgs e)
        {
            LinkLabel lbl = sender as LinkLabel;
            lbl.LinkColor = Color.White;
        }

        //Events
        private void frmListContacts_Load(object sender, EventArgs e)
        {
            llLinkedIn.MouseEnter += _LinkLabel_MouseEnter;
            llFacebook.MouseEnter += _LinkLabel_MouseEnter;
            llGitHub.MouseEnter += _LinkLabel_MouseEnter;

            llLinkedIn.MouseLeave += _LinkLabel_MouseLeave;
            llFacebook.MouseLeave += _LinkLabel_MouseLeave;
            llGitHub.MouseLeave += _LinkLabel_MouseLeave;

            ucDisplayData = new UC_DisplayData();
            ucDashBoard = new UC_DashBoard();
            ucUpdateContact = new UC_UpdateContact();
            ucDeleteContact = new UC_DeleteContacts();
            ucAddContact = new UC_AddContact();

            _LoadUserControl(ucDisplayData,true);
            _ChangeActivation((Button)btnDisplayALLData);
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            _ChangeActivation((Button)sender);
            ucDashBoard.RefreshValues();
            _LoadUserControl(ucDashBoard);
        }
        private void btnAddContact_Click(object sender, EventArgs e)
        {
            _ChangeActivation((Button)sender);
            _LoadUserControl(ucAddContact);
        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            _ChangeActivation((Button)sender);
            _LoadUserControl(ucUpdateContact);
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            _ChangeActivation((Button)sender);
            _LoadUserControl(ucDeleteContact);
        }
        private void btnDisplayALLData_Click(object sender, EventArgs e)
        {
            if (_btnActiveButton != (Button)sender)
            {
                _ChangeActivation((Button)sender);
                cbFilter.SelectedIndex = -1;
                txbFilter.Text = "";
                _LoadUserControl(ucDisplayData, true);
                btnFilter.PerformClick();
            }
            else
            {
                cbFilter.SelectedIndex = -1;
                txbFilter.Text = "";
                btnFilter.PerformClick();
            }
        }

        private void cbFilter_DropDown(object sender, EventArgs e)
        {
            
            if (cbFilter.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cbFilter.Text))
                lblPlaceholder.Visible = true;
            else
                lblPlaceholder.Visible = false;
        }

        private void cbFilter_DropDownClosed(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cbFilter.Text))
                lblPlaceholder.Visible = true;
            else
                lblPlaceholder.Visible = false;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cbFilter.Text))
                lblPlaceholder.Visible = true;
            else
            {
                lblPlaceholder.Visible = false;
                if(cbFilter.SelectedIndex == cbFilter.FindStringExact("DateOfBirth"))
                {
                    dtBirthDate.Visible = true;
                    txbFilter.Visible = false;
                }
                else
                {
                    dtBirthDate.Visible = false;
                    txbFilter.Visible = true;
                }
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == cbFilter.FindStringExact("DateOfBirth"))
                ucDisplayData.ChangeFilter(cbFilter.SelectedIndex, dtBirthDate.Value.ToString("yyyy-MM-dd"));
            else
                ucDisplayData.ChangeFilter(cbFilter.SelectedIndex, txbFilter.Text);
            ucDisplayData.RefreshData();
        }

        private void txbFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFilter.PerformClick();
            }

        }
        private void cbChangeMode_DropDown(object sender, EventArgs e)
        {
            if (cbChangeMode.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cbChangeMode.Text))
                lblPlaceholder2.Visible = true;
            else
                lblPlaceholder2.Visible = false;
        }

        private void cbChangeMode_DropDownClosed(object sender, EventArgs e)
        {
            if (cbChangeMode.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cbChangeMode.Text))
                lblPlaceholder2.Visible = true;
            else
                lblPlaceholder2.Visible = false;
        }

        private void cbChangeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChangeMode.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cbChangeMode.Text))
                lblPlaceholder2.Visible = true;
            else
            {
                lblPlaceholder2.Visible = false;
                ucDisplayData.ChangeMode(cbChangeMode.SelectedIndex);
            }
        }

        private void llFacebook_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/ziad.bakry.54/");
        }

        private void llLinkedIn_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/ziad-bakry-b65b2b245/");
        }

        private void llGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/ZiadMBakry");
        }
    }
}