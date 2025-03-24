namespace MyProject
{
    partial class RenewLicense
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_Notes = new System.Windows.Forms.TextBox();
            this.LB_RenewAppID = new System.Windows.Forms.Label();
            this.LB_RAppDate = new System.Windows.Forms.Label();
            this.LB_AppFees = new System.Windows.Forms.Label();
            this.LB_LiceseFees = new System.Windows.Forms.Label();
            this.LB_NewLiceseID = new System.Windows.Forms.Label();
            this.LB_OldLicesseID = new System.Windows.Forms.Label();
            this.LB_ExpirationDate = new System.Windows.Forms.Label();
            this.LB_CreatedBy = new System.Windows.Forms.Label();
            this.LB_Totalfees = new System.Windows.Forms.Label();
            this.LB_IssueDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel_LicesesHist = new System.Windows.Forms.LinkLabel();
            this.linkLabel_LicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnIssue = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.ctrlFindLocalLicens1 = new MyProject.Licenss.ctrlFindLocalLicens();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_Notes);
            this.groupBox1.Controls.Add(this.LB_RenewAppID);
            this.groupBox1.Controls.Add(this.LB_RAppDate);
            this.groupBox1.Controls.Add(this.LB_AppFees);
            this.groupBox1.Controls.Add(this.LB_LiceseFees);
            this.groupBox1.Controls.Add(this.LB_NewLiceseID);
            this.groupBox1.Controls.Add(this.LB_OldLicesseID);
            this.groupBox1.Controls.Add(this.LB_ExpirationDate);
            this.groupBox1.Controls.Add(this.LB_CreatedBy);
            this.groupBox1.Controls.Add(this.LB_Totalfees);
            this.groupBox1.Controls.Add(this.LB_IssueDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F);
            this.groupBox1.Location = new System.Drawing.Point(8, 526);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(963, 314);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renew License application info";
            // 
            // TB_Notes
            // 
            this.TB_Notes.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Notes.Location = new System.Drawing.Point(140, 239);
            this.TB_Notes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_Notes.Multiline = true;
            this.TB_Notes.Name = "TB_Notes";
            this.TB_Notes.Size = new System.Drawing.Size(415, 65);
            this.TB_Notes.TabIndex = 2;
            // 
            // LB_RenewAppID
            // 
            this.LB_RenewAppID.AutoSize = true;
            this.LB_RenewAppID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RenewAppID.Location = new System.Drawing.Point(191, 38);
            this.LB_RenewAppID.Name = "LB_RenewAppID";
            this.LB_RenewAppID.Size = new System.Drawing.Size(53, 22);
            this.LB_RenewAppID.TabIndex = 1;
            this.LB_RenewAppID.Text = "[###]";
            // 
            // LB_RAppDate
            // 
            this.LB_RAppDate.AutoSize = true;
            this.LB_RAppDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_RAppDate.Location = new System.Drawing.Point(191, 73);
            this.LB_RAppDate.Name = "LB_RAppDate";
            this.LB_RAppDate.Size = new System.Drawing.Size(53, 22);
            this.LB_RAppDate.TabIndex = 1;
            this.LB_RAppDate.Text = "[###]";
            // 
            // LB_AppFees
            // 
            this.LB_AppFees.AutoSize = true;
            this.LB_AppFees.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AppFees.Location = new System.Drawing.Point(191, 146);
            this.LB_AppFees.Name = "LB_AppFees";
            this.LB_AppFees.Size = new System.Drawing.Size(53, 22);
            this.LB_AppFees.TabIndex = 1;
            this.LB_AppFees.Text = "[###]";
            // 
            // LB_LiceseFees
            // 
            this.LB_LiceseFees.AutoSize = true;
            this.LB_LiceseFees.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LiceseFees.Location = new System.Drawing.Point(191, 182);
            this.LB_LiceseFees.Name = "LB_LiceseFees";
            this.LB_LiceseFees.Size = new System.Drawing.Size(53, 22);
            this.LB_LiceseFees.TabIndex = 1;
            this.LB_LiceseFees.Text = "[###]";
            // 
            // LB_NewLiceseID
            // 
            this.LB_NewLiceseID.AutoSize = true;
            this.LB_NewLiceseID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NewLiceseID.Location = new System.Drawing.Point(542, 38);
            this.LB_NewLiceseID.Name = "LB_NewLiceseID";
            this.LB_NewLiceseID.Size = new System.Drawing.Size(53, 22);
            this.LB_NewLiceseID.TabIndex = 1;
            this.LB_NewLiceseID.Text = "[###]";
            // 
            // LB_OldLicesseID
            // 
            this.LB_OldLicesseID.AutoSize = true;
            this.LB_OldLicesseID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_OldLicesseID.Location = new System.Drawing.Point(542, 73);
            this.LB_OldLicesseID.Name = "LB_OldLicesseID";
            this.LB_OldLicesseID.Size = new System.Drawing.Size(53, 22);
            this.LB_OldLicesseID.TabIndex = 1;
            this.LB_OldLicesseID.Text = "[###]";
            // 
            // LB_ExpirationDate
            // 
            this.LB_ExpirationDate.AutoSize = true;
            this.LB_ExpirationDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ExpirationDate.Location = new System.Drawing.Point(542, 109);
            this.LB_ExpirationDate.Name = "LB_ExpirationDate";
            this.LB_ExpirationDate.Size = new System.Drawing.Size(53, 22);
            this.LB_ExpirationDate.TabIndex = 1;
            this.LB_ExpirationDate.Text = "[###]";
            // 
            // LB_CreatedBy
            // 
            this.LB_CreatedBy.AutoSize = true;
            this.LB_CreatedBy.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CreatedBy.Location = new System.Drawing.Point(542, 146);
            this.LB_CreatedBy.Name = "LB_CreatedBy";
            this.LB_CreatedBy.Size = new System.Drawing.Size(53, 22);
            this.LB_CreatedBy.TabIndex = 1;
            this.LB_CreatedBy.Text = "[###]";
            // 
            // LB_Totalfees
            // 
            this.LB_Totalfees.AutoSize = true;
            this.LB_Totalfees.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Totalfees.Location = new System.Drawing.Point(542, 182);
            this.LB_Totalfees.Name = "LB_Totalfees";
            this.LB_Totalfees.Size = new System.Drawing.Size(53, 22);
            this.LB_Totalfees.TabIndex = 1;
            this.LB_Totalfees.Text = "[###]";
            // 
            // LB_IssueDate
            // 
            this.LB_IssueDate.AutoSize = true;
            this.LB_IssueDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_IssueDate.Location = new System.Drawing.Point(191, 109);
            this.LB_IssueDate.Name = "LB_IssueDate";
            this.LB_IssueDate.Size = new System.Drawing.Size(53, 22);
            this.LB_IssueDate.TabIndex = 1;
            this.LB_IssueDate.Text = "[###]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Application Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "R.L.Application ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Issue Date :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Application Fees :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "License Fees :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Notes :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(375, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Old License ID :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(409, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "Total fees :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(400, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Created by :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(368, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Expiration Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Renew License ID :";
            // 
            // linkLabel_LicesesHist
            // 
            this.linkLabel_LicesesHist.AutoSize = true;
            this.linkLabel_LicesesHist.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_LicesesHist.Location = new System.Drawing.Point(10, 871);
            this.linkLabel_LicesesHist.Name = "linkLabel_LicesesHist";
            this.linkLabel_LicesesHist.Size = new System.Drawing.Size(186, 22);
            this.linkLabel_LicesesHist.TabIndex = 2;
            this.linkLabel_LicesesHist.TabStop = true;
            this.linkLabel_LicesesHist.Text = "Show Licenses History";
            this.linkLabel_LicesesHist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LicesesHist_LinkClicked);
            // 
            // linkLabel_LicenseInfo
            // 
            this.linkLabel_LicenseInfo.AutoSize = true;
            this.linkLabel_LicenseInfo.Enabled = false;
            this.linkLabel_LicenseInfo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_LicenseInfo.Location = new System.Drawing.Point(204, 871);
            this.linkLabel_LicenseInfo.Name = "linkLabel_LicenseInfo";
            this.linkLabel_LicenseInfo.Size = new System.Drawing.Size(153, 22);
            this.linkLabel_LicenseInfo.TabIndex = 2;
            this.linkLabel_LicenseInfo.TabStop = true;
            this.linkLabel_LicenseInfo.Text = "Show License Info";
            this.linkLabel_LicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btnIssue
            // 
            this.btnIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(222)))), ((int)(((byte)(235)))));
            this.btnIssue.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnIssue.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btnIssue.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnIssue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIssue.IconSize = 35;
            this.btnIssue.Location = new System.Drawing.Point(703, 865);
            this.btnIssue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(132, 34);
            this.btnIssue.TabIndex = 15;
            this.btnIssue.Text = "Renew";
            this.btnIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(222)))), ((int)(((byte)(235)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClose.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 38;
            this.btnClose.Location = new System.Drawing.Point(853, 866);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 34);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlFindLocalLicens1
            // 
            this.ctrlFindLocalLicens1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlFindLocalLicens1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFindLocalLicens1.Location = new System.Drawing.Point(12, -4);
            this.ctrlFindLocalLicens1.Name = "ctrlFindLocalLicens1";
            this.ctrlFindLocalLicens1.Size = new System.Drawing.Size(1239, 543);
            this.ctrlFindLocalLicens1.TabIndex = 0;
            // 
            // RenewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 903);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlFindLocalLicens1);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.linkLabel_LicenseInfo);
            this.Controls.Add(this.linkLabel_LicesesHist);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RenewLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Renew License";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenss.ctrlFindLocalLicens ctrlFindLocalLicens1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_RenewAppID;
        private System.Windows.Forms.Label LB_RAppDate;
        private System.Windows.Forms.Label LB_AppFees;
        private System.Windows.Forms.Label LB_LiceseFees;
        private System.Windows.Forms.Label LB_NewLiceseID;
        private System.Windows.Forms.Label LB_OldLicesseID;
        private System.Windows.Forms.Label LB_ExpirationDate;
        private System.Windows.Forms.Label LB_CreatedBy;
        private System.Windows.Forms.Label LB_Totalfees;
        private System.Windows.Forms.Label LB_IssueDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TB_Notes;
        private System.Windows.Forms.LinkLabel linkLabel_LicesesHist;
        private System.Windows.Forms.LinkLabel linkLabel_LicenseInfo;
        private FontAwesome.Sharp.IconButton btnIssue;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}