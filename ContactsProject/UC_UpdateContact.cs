using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsProject
{
    public partial class UC_UpdateContact : UserControl
    {
        public UC_UpdateContact()
        {
            InitializeComponent();
        }
        //Methods
        private void _ShowFormInPanel(Form childForm)
        {
            pnlMain.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; 
            childForm.AutoScroll = true;
            childForm.AutoScrollMinSize = new Size(0, childForm.Height);
            childForm.Dock = DockStyle.Fill;
            
            pnlMain.Controls.Add(childForm);
            childForm.Show();
        }
        //Events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbContactID.Text, out int contactID))
            {
                try
                {
                    frmAddEditContact frm = new frmAddEditContact(contactID);
                    _ShowFormInPanel(frm);
                }
                catch { }
            }
            else
                MessageBox.Show("Make sure the fields contain valid data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
