namespace ContactsProject
{
    partial class UC_DashBoard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlNumberOfContacts = new System.Windows.Forms.Panel();
            this.lblNumberOfContacts = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pnlCompletedTasks = new System.Windows.Forms.Panel();
            this.lblCompletedTasks = new System.Windows.Forms.Label();
            this.pnlIncompletedTasks = new System.Windows.Forms.Panel();
            this.lblIncompletedTasks = new System.Windows.Forms.Label();
            this.picboxIncompleted = new System.Windows.Forms.PictureBox();
            this.picboxCountContacts = new System.Windows.Forms.PictureBox();
            this.picboxCompleted = new System.Windows.Forms.PictureBox();
            this.pnlNumberOfContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.pnlCompletedTasks.SuspendLayout();
            this.pnlIncompletedTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxIncompleted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCountContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCompleted)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNumberOfContacts
            // 
            this.pnlNumberOfContacts.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlNumberOfContacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNumberOfContacts.Controls.Add(this.picboxCountContacts);
            this.pnlNumberOfContacts.Controls.Add(this.lblNumberOfContacts);
            this.pnlNumberOfContacts.Location = new System.Drawing.Point(50, 50);
            this.pnlNumberOfContacts.Name = "pnlNumberOfContacts";
            this.pnlNumberOfContacts.Size = new System.Drawing.Size(240, 190);
            this.pnlNumberOfContacts.TabIndex = 0;
            // 
            // lblNumberOfContacts
            // 
            this.lblNumberOfContacts.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberOfContacts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNumberOfContacts.Font = new System.Drawing.Font("Segoe UI", 11.78182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfContacts.ForeColor = System.Drawing.Color.DimGray;
            this.lblNumberOfContacts.Location = new System.Drawing.Point(0, 121);
            this.lblNumberOfContacts.Name = "lblNumberOfContacts";
            this.lblNumberOfContacts.Size = new System.Drawing.Size(238, 67);
            this.lblNumberOfContacts.TabIndex = 2;
            this.lblNumberOfContacts.Text = "Number Of Contacts: ";
            this.lblNumberOfContacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pnlCompletedTasks
            // 
            this.pnlCompletedTasks.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlCompletedTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCompletedTasks.Controls.Add(this.picboxCompleted);
            this.pnlCompletedTasks.Controls.Add(this.lblCompletedTasks);
            this.pnlCompletedTasks.Location = new System.Drawing.Point(390, 50);
            this.pnlCompletedTasks.Name = "pnlCompletedTasks";
            this.pnlCompletedTasks.Size = new System.Drawing.Size(240, 190);
            this.pnlCompletedTasks.TabIndex = 1;
            // 
            // lblCompletedTasks
            // 
            this.lblCompletedTasks.BackColor = System.Drawing.Color.Transparent;
            this.lblCompletedTasks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCompletedTasks.Font = new System.Drawing.Font("Segoe UI", 11.78182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedTasks.ForeColor = System.Drawing.Color.DimGray;
            this.lblCompletedTasks.Location = new System.Drawing.Point(0, 121);
            this.lblCompletedTasks.Name = "lblCompletedTasks";
            this.lblCompletedTasks.Size = new System.Drawing.Size(238, 67);
            this.lblCompletedTasks.TabIndex = 2;
            this.lblCompletedTasks.Text = "Completed Tasks:";
            this.lblCompletedTasks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlIncompletedTasks
            // 
            this.pnlIncompletedTasks.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlIncompletedTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlIncompletedTasks.Controls.Add(this.picboxIncompleted);
            this.pnlIncompletedTasks.Controls.Add(this.lblIncompletedTasks);
            this.pnlIncompletedTasks.Location = new System.Drawing.Point(730, 50);
            this.pnlIncompletedTasks.Name = "pnlIncompletedTasks";
            this.pnlIncompletedTasks.Size = new System.Drawing.Size(240, 190);
            this.pnlIncompletedTasks.TabIndex = 2;
            // 
            // lblIncompletedTasks
            // 
            this.lblIncompletedTasks.BackColor = System.Drawing.Color.Transparent;
            this.lblIncompletedTasks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblIncompletedTasks.Font = new System.Drawing.Font("Segoe UI", 11.78182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncompletedTasks.ForeColor = System.Drawing.Color.DimGray;
            this.lblIncompletedTasks.Location = new System.Drawing.Point(0, 121);
            this.lblIncompletedTasks.Name = "lblIncompletedTasks";
            this.lblIncompletedTasks.Size = new System.Drawing.Size(238, 67);
            this.lblIncompletedTasks.TabIndex = 2;
            this.lblIncompletedTasks.Text = "Incompleted Tasks:";
            this.lblIncompletedTasks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picboxIncompleted
            // 
            this.picboxIncompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.picboxIncompleted.Image = global::ContactsProject.Properties.Resources.incomplete512;
            this.picboxIncompleted.Location = new System.Drawing.Point(0, 0);
            this.picboxIncompleted.Name = "picboxIncompleted";
            this.picboxIncompleted.Size = new System.Drawing.Size(238, 118);
            this.picboxIncompleted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxIncompleted.TabIndex = 0;
            this.picboxIncompleted.TabStop = false;
            // 
            // picboxCountContacts
            // 
            this.picboxCountContacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.picboxCountContacts.Image = global::ContactsProject.Properties.Resources.counting512;
            this.picboxCountContacts.Location = new System.Drawing.Point(0, 0);
            this.picboxCountContacts.Name = "picboxCountContacts";
            this.picboxCountContacts.Size = new System.Drawing.Size(238, 119);
            this.picboxCountContacts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxCountContacts.TabIndex = 0;
            this.picboxCountContacts.TabStop = false;
            // 
            // picboxCompleted
            // 
            this.picboxCompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.picboxCompleted.Image = global::ContactsProject.Properties.Resources.goal512;
            this.picboxCompleted.Location = new System.Drawing.Point(0, 0);
            this.picboxCompleted.Name = "picboxCompleted";
            this.picboxCompleted.Size = new System.Drawing.Size(238, 118);
            this.picboxCompleted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxCompleted.TabIndex = 0;
            this.picboxCompleted.TabStop = false;
            // 
            // UC_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlIncompletedTasks);
            this.Controls.Add(this.pnlNumberOfContacts);
            this.Controls.Add(this.pnlCompletedTasks);
            this.Name = "UC_DashBoard";
            this.Size = new System.Drawing.Size(1012, 352);
            this.Load += new System.EventHandler(this.UC_DashBoard_Load);
            this.pnlNumberOfContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.pnlCompletedTasks.ResumeLayout(false);
            this.pnlIncompletedTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxIncompleted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCountContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxCompleted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxCountContacts;
        private System.Windows.Forms.Panel pnlNumberOfContacts;
        private System.Windows.Forms.Label lblNumberOfContacts;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel pnlCompletedTasks;
        private System.Windows.Forms.PictureBox picboxCompleted;
        private System.Windows.Forms.Label lblCompletedTasks;
        private System.Windows.Forms.Panel pnlIncompletedTasks;
        private System.Windows.Forms.PictureBox picboxIncompleted;
        private System.Windows.Forms.Label lblIncompletedTasks;
    }
}
