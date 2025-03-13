namespace ContactsProject
{
    partial class UC_DeleteContacts
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
            this.txbContactID = new System.Windows.Forms.TextBox();
            this.lblContactID = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlContactInfo = new System.Windows.Forms.Panel();
            this.lblOutputPhone = new System.Windows.Forms.Label();
            this.lblOutputAge = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOutputName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.picboxImage = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlContactInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txbContactID
            // 
            this.txbContactID.BackColor = System.Drawing.Color.White;
            this.txbContactID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbContactID.Font = new System.Drawing.Font("Tahoma", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContactID.Location = new System.Drawing.Point(330, 15);
            this.txbContactID.Margin = new System.Windows.Forms.Padding(4);
            this.txbContactID.MaxLength = 32;
            this.txbContactID.Name = "txbContactID";
            this.txbContactID.Size = new System.Drawing.Size(268, 29);
            this.txbContactID.TabIndex = 5;
            this.txbContactID.WordWrap = false;
            this.txbContactID.TextChanged += new System.EventHandler(this.txbContactID_TextChanged);
            this.txbContactID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbContactID_KeyDown);
            // 
            // lblContactID
            // 
            this.lblContactID.AutoSize = true;
            this.lblContactID.BackColor = System.Drawing.Color.White;
            this.lblContactID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContactID.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblContactID.Location = new System.Drawing.Point(335, 18);
            this.lblContactID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactID.Name = "lblContactID";
            this.lblContactID.Size = new System.Drawing.Size(90, 21);
            this.lblContactID.TabIndex = 4;
            this.lblContactID.Text = "Contact ID";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(610, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(76, 29);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.lblContactID);
            this.pnlHeader.Controls.Add(this.txbContactID);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1070, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlContactInfo
            // 
            this.pnlContactInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlContactInfo.Controls.Add(this.lblOutputPhone);
            this.pnlContactInfo.Controls.Add(this.lblOutputAge);
            this.pnlContactInfo.Controls.Add(this.lblAge);
            this.pnlContactInfo.Controls.Add(this.lblPhone);
            this.pnlContactInfo.Controls.Add(this.lblName);
            this.pnlContactInfo.Controls.Add(this.lblOutputName);
            this.pnlContactInfo.Controls.Add(this.btnDelete);
            this.pnlContactInfo.Controls.Add(this.picboxImage);
            this.pnlContactInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContactInfo.Location = new System.Drawing.Point(0, 65);
            this.pnlContactInfo.Name = "pnlContactInfo";
            this.pnlContactInfo.Padding = new System.Windows.Forms.Padding(110, 80, 0, 0);
            this.pnlContactInfo.Size = new System.Drawing.Size(1070, 244);
            this.pnlContactInfo.TabIndex = 5;
            // 
            // lblOutputPhone
            // 
            this.lblOutputPhone.AutoSize = true;
            this.lblOutputPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOutputPhone.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputPhone.ForeColor = System.Drawing.Color.White;
            this.lblOutputPhone.Location = new System.Drawing.Point(365, 135);
            this.lblOutputPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutputPhone.Name = "lblOutputPhone";
            this.lblOutputPhone.Size = new System.Drawing.Size(0, 21);
            this.lblOutputPhone.TabIndex = 10;
            this.lblOutputPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputAge
            // 
            this.lblOutputAge.AutoSize = true;
            this.lblOutputAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOutputAge.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputAge.ForeColor = System.Drawing.Color.White;
            this.lblOutputAge.Location = new System.Drawing.Point(365, 85);
            this.lblOutputAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutputAge.Name = "lblOutputAge";
            this.lblOutputAge.Size = new System.Drawing.Size(0, 21);
            this.lblOutputAge.TabIndex = 8;
            this.lblOutputAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAge.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(229, 84);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(120, 21);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Contact Age:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPhone.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(254, 134);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 21);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(221, 34);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(136, 21);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Contact Name:";
            // 
            // lblOutputName
            // 
            this.lblOutputName.AutoSize = true;
            this.lblOutputName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOutputName.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputName.ForeColor = System.Drawing.Color.White;
            this.lblOutputName.Location = new System.Drawing.Point(365, 35);
            this.lblOutputName.Margin = new System.Windows.Forms.Padding(0);
            this.lblOutputName.Name = "lblOutputName";
            this.lblOutputName.Size = new System.Drawing.Size(0, 21);
            this.lblOutputName.TabIndex = 6;
            this.lblOutputName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(463, 188);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 33);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // picboxImage
            // 
            this.picboxImage.Location = new System.Drawing.Point(656, 17);
            this.picboxImage.Margin = new System.Windows.Forms.Padding(4);
            this.picboxImage.Name = "picboxImage";
            this.picboxImage.Size = new System.Drawing.Size(165, 139);
            this.picboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxImage.TabIndex = 20;
            this.picboxImage.TabStop = false;
            // 
            // UC_DeleteContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlContactInfo);
            this.Controls.Add(this.pnlHeader);
            this.Name = "UC_DeleteContacts";
            this.Size = new System.Drawing.Size(1070, 309);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContactInfo.ResumeLayout(false);
            this.pnlContactInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbContactID;
        private System.Windows.Forms.Label lblContactID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContactInfo;
        private System.Windows.Forms.Label lblOutputPhone;
        private System.Windows.Forms.Label lblOutputAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOutputName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox picboxImage;
    }
}
