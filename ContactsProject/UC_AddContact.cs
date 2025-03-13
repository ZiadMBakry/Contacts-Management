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
    public partial class UC_AddContact : UserControl
    {
        public UC_AddContact()
        {
            InitializeComponent();
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            frmAddEditContact frmAddEditContact = new frmAddEditContact(-1);
            frmAddEditContact.ShowDialog();
        }
    }
}
