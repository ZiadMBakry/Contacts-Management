namespace ContactsProject
{
    partial class frmContactsManagement
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContactsManagement));
            this.lblPoweredBy = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.llFacebook = new System.Windows.Forms.LinkLabel();
            this.llLinkedIn = new System.Windows.Forms.LinkLabel();
            this.llGitHub = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txbFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblPlaceholder = new System.Windows.Forms.Label();
            this.cbChangeMode = new System.Windows.Forms.ComboBox();
            this.lblPlaceholder2 = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnUpdateContact = new System.Windows.Forms.Button();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.btnDisplayALLData = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnAddNewContact = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.pnlFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPoweredBy
            // 
            this.lblPoweredBy.AutoSize = true;
            this.lblPoweredBy.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPoweredBy.Font = new System.Drawing.Font("Tahoma", 9.163636F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoweredBy.ForeColor = System.Drawing.Color.White;
            this.lblPoweredBy.Location = new System.Drawing.Point(0, 0);
            this.lblPoweredBy.Name = "lblPoweredBy";
            this.lblPoweredBy.Padding = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.lblPoweredBy.Size = new System.Drawing.Size(245, 37);
            this.lblPoweredBy.TabIndex = 5;
            this.lblPoweredBy.Text = "Powered By Ziad Bakry © 2025";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pnlFooter.Controls.Add(this.lblDesc);
            this.pnlFooter.Controls.Add(this.llFacebook);
            this.pnlFooter.Controls.Add(this.llLinkedIn);
            this.pnlFooter.Controls.Add(this.llGitHub);
            this.pnlFooter.Controls.Add(this.lblPoweredBy);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 609);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1509, 55);
            this.pnlFooter.TabIndex = 0;
            // 
            // llFacebook
            // 
            this.llFacebook.AutoSize = true;
            this.llFacebook.Dock = System.Windows.Forms.DockStyle.Right;
            this.llFacebook.Font = new System.Drawing.Font("Tahoma", 9.163636F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llFacebook.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llFacebook.LinkColor = System.Drawing.Color.White;
            this.llFacebook.Location = new System.Drawing.Point(1250, 0);
            this.llFacebook.Name = "llFacebook";
            this.llFacebook.Padding = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.llFacebook.Size = new System.Drawing.Size(94, 37);
            this.llFacebook.TabIndex = 11;
            this.llFacebook.TabStop = true;
            this.llFacebook.Text = "Facebook";
            this.llFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llFacebook_LinkClicked_1);
            // 
            // llLinkedIn
            // 
            this.llLinkedIn.AutoSize = true;
            this.llLinkedIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.llLinkedIn.Font = new System.Drawing.Font("Tahoma", 9.163636F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llLinkedIn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llLinkedIn.LinkColor = System.Drawing.Color.White;
            this.llLinkedIn.Location = new System.Drawing.Point(1344, 0);
            this.llLinkedIn.Name = "llLinkedIn";
            this.llLinkedIn.Padding = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.llLinkedIn.Size = new System.Drawing.Size(89, 37);
            this.llLinkedIn.TabIndex = 10;
            this.llLinkedIn.TabStop = true;
            this.llLinkedIn.Text = "LinkedIn";
            this.llLinkedIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLinkedIn_LinkClicked_1);
            // 
            // llGitHub
            // 
            this.llGitHub.AutoSize = true;
            this.llGitHub.Dock = System.Windows.Forms.DockStyle.Right;
            this.llGitHub.Font = new System.Drawing.Font("Tahoma", 9.163636F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llGitHub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llGitHub.LinkColor = System.Drawing.Color.White;
            this.llGitHub.Location = new System.Drawing.Point(1433, 0);
            this.llGitHub.Name = "llGitHub";
            this.llGitHub.Padding = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.llGitHub.Size = new System.Drawing.Size(76, 37);
            this.llGitHub.TabIndex = 8;
            this.llGitHub.TabStop = true;
            this.llGitHub.Text = "GitHub";
            this.llGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llGitHub_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAddContact);
            this.panel1.Controls.Add(this.btnUpdateContact);
            this.panel1.Controls.Add(this.btnDeleteContact);
            this.panel1.Controls.Add(this.btnDisplayALLData);
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 609);
            this.panel1.TabIndex = 0;
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Checked = false;
            this.dtBirthDate.CustomFormat = "yyyy-MM-dd";
            this.dtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthDate.Location = new System.Drawing.Point(317, 22);
            this.dtBirthDate.MaxDate = new System.DateTime(2025, 3, 10, 0, 0, 0, 0);
            this.dtBirthDate.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(230, 24);
            this.dtBirthDate.TabIndex = 7;
            this.dtBirthDate.Value = new System.DateTime(2025, 3, 10, 0, 0, 0, 0);
            this.dtBirthDate.Visible = false;
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFilter.Font = new System.Drawing.Font("Tahoma", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbFilter.Location = new System.Drawing.Point(85, 21);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(219, 25);
            this.cbFilter.TabIndex = 6;
            this.cbFilter.DropDown += new System.EventHandler(this.cbFilter_DropDown);
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            this.cbFilter.DropDownClosed += new System.EventHandler(this.cbFilter_DropDownClosed);
            // 
            // txbFilter
            // 
            this.txbFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFilter.Font = new System.Drawing.Font("Tahoma", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFilter.Location = new System.Drawing.Point(317, 22);
            this.txbFilter.MaxLength = 100;
            this.txbFilter.Name = "txbFilter";
            this.txbFilter.Size = new System.Drawing.Size(230, 24);
            this.txbFilter.TabIndex = 8;
            this.txbFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbFilter_KeyDown);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.DimGray;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Tahoma", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(560, 21);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 28);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblPlaceholder
            // 
            this.lblPlaceholder.AutoSize = true;
            this.lblPlaceholder.BackColor = System.Drawing.Color.White;
            this.lblPlaceholder.CausesValidation = false;
            this.lblPlaceholder.Enabled = false;
            this.lblPlaceholder.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPlaceholder.Location = new System.Drawing.Point(89, 25);
            this.lblPlaceholder.Name = "lblPlaceholder";
            this.lblPlaceholder.Size = new System.Drawing.Size(86, 17);
            this.lblPlaceholder.TabIndex = 10;
            this.lblPlaceholder.Text = "Choose Filter";
            // 
            // cbChangeMode
            // 
            this.cbChangeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChangeMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbChangeMode.Font = new System.Drawing.Font("Tahoma", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChangeMode.FormattingEnabled = true;
            this.cbChangeMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbChangeMode.Items.AddRange(new object[] {
            "Short Data",
            "Full Details"});
            this.cbChangeMode.Location = new System.Drawing.Point(940, 21);
            this.cbChangeMode.Name = "cbChangeMode";
            this.cbChangeMode.Size = new System.Drawing.Size(219, 25);
            this.cbChangeMode.TabIndex = 9;
            this.cbChangeMode.DropDown += new System.EventHandler(this.cbChangeMode_DropDown);
            this.cbChangeMode.SelectedIndexChanged += new System.EventHandler(this.cbChangeMode_SelectedIndexChanged);
            this.cbChangeMode.DropDownClosed += new System.EventHandler(this.cbChangeMode_DropDownClosed);
            // 
            // lblPlaceholder2
            // 
            this.lblPlaceholder2.AutoSize = true;
            this.lblPlaceholder2.BackColor = System.Drawing.Color.White;
            this.lblPlaceholder2.CausesValidation = false;
            this.lblPlaceholder2.Enabled = false;
            this.lblPlaceholder2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPlaceholder2.Location = new System.Drawing.Point(945, 25);
            this.lblPlaceholder2.Name = "lblPlaceholder2";
            this.lblPlaceholder2.Size = new System.Drawing.Size(139, 17);
            this.lblPlaceholder2.TabIndex = 12;
            this.lblPlaceholder2.Text = "Change Display Mode";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pnlFilter.Controls.Add(this.lblPlaceholder2);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.txbFilter);
            this.pnlFilter.Controls.Add(this.cbChangeMode);
            this.pnlFilter.Controls.Add(this.lblPlaceholder);
            this.pnlFilter.Controls.Add(this.dtBirthDate);
            this.pnlFilter.Controls.Add(this.cbFilter);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Font = new System.Drawing.Font("Tahoma", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlFilter.Location = new System.Drawing.Point(280, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1229, 66);
            this.pnlFilter.TabIndex = 13;
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(280, 66);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1229, 543);
            this.pnlContainer.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.Color.DimGray;
            this.btnAddContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContact.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContact.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddContact.Image = global::ContactsProject.Properties.Resources.add_user64;
            this.btnAddContact.Location = new System.Drawing.Point(-6, 212);
            this.btnAddContact.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddContact.Size = new System.Drawing.Size(284, 80);
            this.btnAddContact.TabIndex = 1;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddContact.UseVisualStyleBackColor = false;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnUpdateContact
            // 
            this.btnUpdateContact.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdateContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateContact.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateContact.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateContact.Image = global::ContactsProject.Properties.Resources.refresh64;
            this.btnUpdateContact.Location = new System.Drawing.Point(-6, 298);
            this.btnUpdateContact.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateContact.Name = "btnUpdateContact";
            this.btnUpdateContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdateContact.Size = new System.Drawing.Size(284, 80);
            this.btnUpdateContact.TabIndex = 2;
            this.btnUpdateContact.Text = "Update Contact";
            this.btnUpdateContact.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdateContact.UseVisualStyleBackColor = false;
            this.btnUpdateContact.Click += new System.EventHandler(this.btnUpdateContact_Click);
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteContact.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteContact.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteContact.Image = global::ContactsProject.Properties.Resources.trash_can64;
            this.btnDeleteContact.Location = new System.Drawing.Point(-6, 384);
            this.btnDeleteContact.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteContact.Size = new System.Drawing.Size(284, 80);
            this.btnDeleteContact.TabIndex = 3;
            this.btnDeleteContact.Text = "Delete Contact";
            this.btnDeleteContact.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDeleteContact.UseVisualStyleBackColor = false;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // btnDisplayALLData
            // 
            this.btnDisplayALLData.BackColor = System.Drawing.Color.DimGray;
            this.btnDisplayALLData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayALLData.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayALLData.ForeColor = System.Drawing.Color.Transparent;
            this.btnDisplayALLData.Image = ((System.Drawing.Image)(resources.GetObject("btnDisplayALLData.Image")));
            this.btnDisplayALLData.Location = new System.Drawing.Point(-6, 126);
            this.btnDisplayALLData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDisplayALLData.Name = "btnDisplayALLData";
            this.btnDisplayALLData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDisplayALLData.Size = new System.Drawing.Size(284, 80);
            this.btnDisplayALLData.TabIndex = 0;
            this.btnDisplayALLData.Text = "Display All Data";
            this.btnDisplayALLData.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDisplayALLData.UseVisualStyleBackColor = false;
            this.btnDisplayALLData.Click += new System.EventHandler(this.btnDisplayALLData_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.DimGray;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Image = global::ContactsProject.Properties.Resources.dashboard64;
            this.btnDashBoard.Location = new System.Drawing.Point(-6, 470);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDashBoard.Size = new System.Drawing.Size(284, 80);
            this.btnDashBoard.TabIndex = 4;
            this.btnDashBoard.Text = "Dash Board";
            this.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnAddNewContact
            // 
            this.btnAddNewContact.BackColor = System.Drawing.Color.Red;
            this.btnAddNewContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewContact.Font = new System.Drawing.Font("Times New Roman", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewContact.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewContact.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewContact.Image")));
            this.btnAddNewContact.Location = new System.Drawing.Point(20, 20);
            this.btnAddNewContact.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddNewContact.Name = "btnAddNewContact";
            this.btnAddNewContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddNewContact.Size = new System.Drawing.Size(257, 84);
            this.btnAddNewContact.TabIndex = 1;
            this.btnAddNewContact.TabStop = false;
            this.btnAddNewContact.Text = "Add Contact";
            this.btnAddNewContact.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAddNewContact.UseVisualStyleBackColor = false;
            // 
            // lblDesc
            // 
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDesc.Font = new System.Drawing.Font("Tahoma", 9.163636F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.White;
            this.lblDesc.Location = new System.Drawing.Point(245, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(1005, 55);
            this.lblDesc.TabIndex = 12;
            this.lblDesc.Text = "All data is retrieved from ContactsDB.";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmContactsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1509, 664);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFooter);
            this.Font = new System.Drawing.Font("Times New Roman", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmContactsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts Management System";
            this.Load += new System.EventHandler(this.frmListContacts_Load);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddNewContact;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnUpdateContact;
        private System.Windows.Forms.Label lblPoweredBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Button btnDisplayALLData;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox txbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblPlaceholder;
        private System.Windows.Forms.ComboBox cbChangeMode;
        private System.Windows.Forms.Label lblPlaceholder2;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.LinkLabel llGitHub;
        private System.Windows.Forms.LinkLabel llFacebook;
        private System.Windows.Forms.LinkLabel llLinkedIn;
        private System.Windows.Forms.Label lblDesc;
    }
}

