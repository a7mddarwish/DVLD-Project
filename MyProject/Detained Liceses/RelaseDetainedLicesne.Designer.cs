namespace MyProject
{
    partial class RelaseDetainedLicesne
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LB_FineFees = new System.Windows.Forms.Label();
            this.LB_DetainBy = new System.Windows.Forms.Label();
            this.LB_DetainDate = new System.Windows.Forms.Label();
            this.LB_DetainID = new System.Windows.Forms.Label();
            this.LB_LiceseID = new System.Windows.Forms.Label();
            this.LB_TotalFees = new System.Windows.Forms.Label();
            this.LB_ReleaseBy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel_LicenseInfo = new System.Windows.Forms.LinkLabel();
            this.linkLabel_LicesesHist = new System.Windows.Forms.LinkLabel();
            this.btnRelease = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.ctrlFindLocalLicens1 = new MyProject.Licenss.ctrlFindLocalLicens();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(314, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Release Detaind License";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.LB_FineFees);
            this.groupBox1.Controls.Add(this.LB_DetainBy);
            this.groupBox1.Controls.Add(this.LB_DetainDate);
            this.groupBox1.Controls.Add(this.LB_DetainID);
            this.groupBox1.Controls.Add(this.LB_LiceseID);
            this.groupBox1.Controls.Add(this.LB_TotalFees);
            this.groupBox1.Controls.Add(this.LB_ReleaseBy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 691);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(956, 238);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detained Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Detained By:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Detain Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(428, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Fees:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "License ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(422, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Release By:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Fine Fees:";
            // 
            // LB_FineFees
            // 
            this.LB_FineFees.AutoSize = true;
            this.LB_FineFees.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FineFees.Location = new System.Drawing.Point(194, 167);
            this.LB_FineFees.Name = "LB_FineFees";
            this.LB_FineFees.Size = new System.Drawing.Size(55, 23);
            this.LB_FineFees.TabIndex = 0;
            this.LB_FineFees.Text = "[###]";
            // 
            // LB_DetainBy
            // 
            this.LB_DetainBy.AutoSize = true;
            this.LB_DetainBy.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DetainBy.Location = new System.Drawing.Point(194, 126);
            this.LB_DetainBy.Name = "LB_DetainBy";
            this.LB_DetainBy.Size = new System.Drawing.Size(55, 23);
            this.LB_DetainBy.TabIndex = 0;
            this.LB_DetainBy.Text = "[###]";
            // 
            // LB_DetainDate
            // 
            this.LB_DetainDate.AutoSize = true;
            this.LB_DetainDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DetainDate.Location = new System.Drawing.Point(194, 84);
            this.LB_DetainDate.Name = "LB_DetainDate";
            this.LB_DetainDate.Size = new System.Drawing.Size(55, 23);
            this.LB_DetainDate.TabIndex = 0;
            this.LB_DetainDate.Text = "[###]";
            // 
            // LB_DetainID
            // 
            this.LB_DetainID.AutoSize = true;
            this.LB_DetainID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DetainID.Location = new System.Drawing.Point(194, 43);
            this.LB_DetainID.Name = "LB_DetainID";
            this.LB_DetainID.Size = new System.Drawing.Size(55, 23);
            this.LB_DetainID.TabIndex = 0;
            this.LB_DetainID.Text = "[###]";
            // 
            // LB_LiceseID
            // 
            this.LB_LiceseID.AutoSize = true;
            this.LB_LiceseID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LiceseID.Location = new System.Drawing.Point(585, 43);
            this.LB_LiceseID.Name = "LB_LiceseID";
            this.LB_LiceseID.Size = new System.Drawing.Size(55, 23);
            this.LB_LiceseID.TabIndex = 0;
            this.LB_LiceseID.Text = "[###]";
            // 
            // LB_TotalFees
            // 
            this.LB_TotalFees.AutoSize = true;
            this.LB_TotalFees.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TotalFees.ForeColor = System.Drawing.Color.Red;
            this.LB_TotalFees.Location = new System.Drawing.Point(585, 126);
            this.LB_TotalFees.Name = "LB_TotalFees";
            this.LB_TotalFees.Size = new System.Drawing.Size(55, 23);
            this.LB_TotalFees.TabIndex = 0;
            this.LB_TotalFees.Text = "[###]";
            // 
            // LB_ReleaseBy
            // 
            this.LB_ReleaseBy.AutoSize = true;
            this.LB_ReleaseBy.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ReleaseBy.Location = new System.Drawing.Point(585, 86);
            this.LB_ReleaseBy.Name = "LB_ReleaseBy";
            this.LB_ReleaseBy.Size = new System.Drawing.Size(55, 23);
            this.LB_ReleaseBy.TabIndex = 0;
            this.LB_ReleaseBy.Text = "[###]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Detain ID:";
            // 
            // linkLabel_LicenseInfo
            // 
            this.linkLabel_LicenseInfo.AutoSize = true;
            this.linkLabel_LicenseInfo.Enabled = false;
            this.linkLabel_LicenseInfo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_LicenseInfo.Location = new System.Drawing.Point(274, 939);
            this.linkLabel_LicenseInfo.Name = "linkLabel_LicenseInfo";
            this.linkLabel_LicenseInfo.Size = new System.Drawing.Size(161, 23);
            this.linkLabel_LicenseInfo.TabIndex = 4;
            this.linkLabel_LicenseInfo.TabStop = true;
            this.linkLabel_LicenseInfo.Text = "Show License Info";
            // 
            // linkLabel_LicesesHist
            // 
            this.linkLabel_LicesesHist.AutoSize = true;
            this.linkLabel_LicesesHist.Enabled = false;
            this.linkLabel_LicesesHist.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_LicesesHist.Location = new System.Drawing.Point(47, 939);
            this.linkLabel_LicesesHist.Name = "linkLabel_LicesesHist";
            this.linkLabel_LicesesHist.Size = new System.Drawing.Size(197, 23);
            this.linkLabel_LicesesHist.TabIndex = 5;
            this.linkLabel_LicesesHist.TabStop = true;
            this.linkLabel_LicesesHist.Text = "Show Licenses History";
            // 
            // btnRelease
            // 
            this.btnRelease.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(222)))), ((int)(((byte)(235)))));
            this.btnRelease.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelease.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRelease.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.btnRelease.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRelease.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRelease.IconSize = 32;
            this.btnRelease.Location = new System.Drawing.Point(671, 939);
            this.btnRelease.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(140, 52);
            this.btnRelease.TabIndex = 15;
            this.btnRelease.Text = "Release";
            this.btnRelease.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelease.UseVisualStyleBackColor = false;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
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
            this.btnClose.Location = new System.Drawing.Point(838, 939);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 52);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlFindLocalLicens1
            // 
            this.ctrlFindLocalLicens1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFindLocalLicens1.Location = new System.Drawing.Point(27, 57);
            this.ctrlFindLocalLicens1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlFindLocalLicens1.Name = "ctrlFindLocalLicens1";
            this.ctrlFindLocalLicens1.Size = new System.Drawing.Size(1034, 695);
            this.ctrlFindLocalLicens1.TabIndex = 1;
            // 
            // RelaseDetainedLicesne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 1055);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linkLabel_LicenseInfo);
            this.Controls.Add(this.linkLabel_LicesesHist);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlFindLocalLicens1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RelaseDetainedLicesne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Relase Detained License";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Licenss.ctrlFindLocalLicens ctrlFindLocalLicens1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel_LicenseInfo;
        private System.Windows.Forms.LinkLabel linkLabel_LicesesHist;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LB_FineFees;
        private System.Windows.Forms.Label LB_DetainBy;
        private System.Windows.Forms.Label LB_DetainDate;
        private System.Windows.Forms.Label LB_DetainID;
        private System.Windows.Forms.Label LB_LiceseID;
        private System.Windows.Forms.Label LB_TotalFees;
        private System.Windows.Forms.Label LB_ReleaseBy;
        private FontAwesome.Sharp.IconButton btnRelease;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}