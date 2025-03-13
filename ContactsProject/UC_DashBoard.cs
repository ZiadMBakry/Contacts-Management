using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ContactsBusinessLayer;

namespace ContactsProject
{
    public partial class UC_DashBoard : UserControl
    {
        public UC_DashBoard()
        {
            InitializeComponent();
        }

        //جعل الحواف دائرية ChatGPT
        public void MakePanelRounded(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        public void RefreshValues()
        {
            lblNumberOfContacts.Text = $"Number Of Contacts: {clsContact.GetNumberOfContacts()}";
            lblCompletedTasks.Text = $"Completed Tasks: {frmContactsManagement.CompletedTasks}";
            lblIncompletedTasks.Text = $"Incompleted Tasks: {frmContactsManagement.InCompletedTasks}";
        }
        private void UC_DashBoard_Load(object sender, EventArgs e)
        {
            MakePanelRounded(pnlNumberOfContacts,60);
            MakePanelRounded(pnlCompletedTasks,60);
            MakePanelRounded(pnlIncompletedTasks, 60);
        }
    }
}
