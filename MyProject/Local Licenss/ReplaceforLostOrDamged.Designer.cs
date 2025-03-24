namespace MyProject
{ 
    partial class ReplaceforLostOrDamged
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
            this.RB_Lost = new System.Windows.Forms.RadioButton();
            this.RB_Damged = new System.Windows.Forms.RadioButton();
            this.LB_Header = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LB_ApplicationFees = new System.Windows.Forms.Label();
            this.LB_AppDate = new System.Windows.Forms.Label();
            this.LB_NewAppID = new System.Windows.Forms.Label();
            this.LB_NewLicenseID = new System.Windows.Forms.Label();
            this.LB_OldLicesneID = new System.Windows.Forms.Label();
            this.LB_CreatedBy = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel_LicenseInfo = new System.Windows.Forms.LinkLabel();
            this.linkLabel_LicesesHist = new System.Windows.Forms.LinkLabel();
            this.ctrlFindLocalLicens1 = new MyProject.Licenss.ctrlFindLocalLicens();
            this.btnIssue = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Lost);
            this.groupBox1.Controls.Add(this.RB_Damged);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(704, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replacement reason";
            // 
            // RB_Lost
            // 
            this.RB_Lost.AutoSize = true;
            this.RB_Lost.Location = new System.Drawing.Point(16, 28);
            this.RB_Lost.Name = "RB_Lost";
            this.RB_Lost.Size = new System.Drawing.Size(55, 21);
            this.RB_Lost.TabIndex = 0;
            this.RB_Lost.Text = "Lost";
            this.RB_Lost.UseVisualStyleBackColor = true;
            this.RB_Lost.CheckedChanged += new System.EventHandler(this.RB_Lost_CheckedChanged);
            // 
            // RB_Damged
            // 
            this.RB_Damged.AutoSize = true;
            this.RB_Damged.Checked = true;
            this.RB_Damged.Location = new System.Drawing.Point(95, 28);
            this.RB_Damged.Name = "RB_Damged";
            this.RB_Damged.Size = new System.Drawing.Size(88, 21);
            this.RB_Damged.TabIndex = 0;
            this.RB_Damged.TabStop = true;
            this.RB_Damged.Text = "Damaged";
            this.RB_Damged.UseVisualStyleBackColor = true;
            // 
            // LB_Header
            // 
            this.LB_Header.AutoSize = true;
            this.LB_Header.Font = new System.Drawing.Font("Microsoft JhengHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Header.ForeColor = System.Drawing.Color.Red;
            this.LB_Header.Location = new System.Drawing.Point(258, 11);
            this.LB_Header.Name = "LB_Header";
            this.LB_Header.Size = new System.Drawing.Size(407, 47);
            this.LB_Header.TabIndex = 2;
            this.LB_Header.Text = "Replace for Damaged";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LB_ApplicationFees);
            this.groupBox2.Controls.Add(this.LB_AppDate);
            this.groupBox2.Controls.Add(this.LB_NewAppID);
            this.groupBox2.Controls.Add(this.LB_NewLicenseID);
            this.groupBox2.Controls.Add(this.LB_OldLicesneID);
            this.groupBox2.Controls.Add(this.LB_CreatedBy);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 648);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(926, 192);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Replacement License info";
            // 
            // LB_ApplicationFees
            // 
            this.LB_ApplicationFees.AutoSize = true;
            this.LB_ApplicationFees.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ApplicationFees.Location = new System.Drawing.Point(207, 115);
            this.LB_ApplicationFees.Name = "LB_ApplicationFees";
            this.LB_ApplicationFees.Size = new System.Drawing.Size(53, 22);
            this.LB_ApplicationFees.TabIndex = 2;
            this.LB_ApplicationFees.Text = "[###]";
            // 
            // LB_AppDate
            // 
            this.LB_AppDate.AutoSize = true;
            this.LB_AppDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AppDate.Location = new System.Drawing.Point(207, 76);
            this.LB_AppDate.Name = "LB_AppDate";
            this.LB_AppDate.Size = new System.Drawing.Size(53, 22);
            this.LB_AppDate.TabIndex = 2;
            this.LB_AppDate.Text = "[###]";
            // 
            // LB_NewAppID
            // 
            this.LB_NewAppID.AutoSize = true;
            this.LB_NewAppID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NewAppID.Location = new System.Drawing.Point(207, 38);
            this.LB_NewAppID.Name = "LB_NewAppID";
            this.LB_NewAppID.Size = new System.Drawing.Size(53, 22);
            this.LB_NewAppID.TabIndex = 2;
            this.LB_NewAppID.Text = "[###]";
            // 
            // LB_NewLicenseID
            // 
            this.LB_NewLicenseID.AutoSize = true;
            this.LB_NewLicenseID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NewLicenseID.Location = new System.Drawing.Point(553, 38);
            this.LB_NewLicenseID.Name = "LB_NewLicenseID";
            this.LB_NewLicenseID.Size = new System.Drawing.Size(53, 22);
            this.LB_NewLicenseID.TabIndex = 2;
            this.LB_NewLicenseID.Text = "[###]";
            // 
            // LB_OldLicesneID
            // 
            this.LB_OldLicesneID.AutoSize = true;
            this.LB_OldLicesneID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_OldLicesneID.Location = new System.Drawing.Point(553, 76);
            this.LB_OldLicesneID.Name = "LB_OldLicesneID";
            this.LB_OldLicesneID.Size = new System.Drawing.Size(53, 22);
            this.LB_OldLicesneID.TabIndex = 2;
            this.LB_OldLicesneID.Text = "[###]";
            // 
            // LB_CreatedBy
            // 
            this.LB_CreatedBy.AutoSize = true;
            this.LB_CreatedBy.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CreatedBy.Location = new System.Drawing.Point(553, 115);
            this.LB_CreatedBy.Name = "LB_CreatedBy";
            this.LB_CreatedBy.Size = new System.Drawing.Size(53, 22);
            this.LB_CreatedBy.TabIndex = 2;
            this.LB_CreatedBy.Text = "[###]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-237, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "R.L.ApplicationID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-237, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "R.L.ApplicationID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Application fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Application Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "R.L.ApplicationID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(421, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Created By:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(400, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Old licesne ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Replcaement License ID:";
            // 
            // linkLabel_LicenseInfo
            // 
            this.linkLabel_LicenseInfo.AutoSize = true;
            this.linkLabel_LicenseInfo.Enabled = false;
            this.linkLabel_LicenseInfo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_LicenseInfo.Location = new System.Drawing.Point(218, 852);
            this.linkLabel_LicenseInfo.Name = "linkLabel_LicenseInfo";
            this.linkLabel_LicenseInfo.Size = new System.Drawing.Size(134, 19);
            this.linkLabel_LicenseInfo.TabIndex = 3;
            this.linkLabel_LicenseInfo.TabStop = true;
            this.linkLabel_LicenseInfo.Text = "Show License Info";
            this.linkLabel_LicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LicenseInfo_LinkClicked);
            // 
            // linkLabel_LicesesHist
            // 
            this.linkLabel_LicesesHist.AutoSize = true;
            this.linkLabel_LicesesHist.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_LicesesHist.Location = new System.Drawing.Point(25, 852);
            this.linkLabel_LicesesHist.Name = "linkLabel_LicesesHist";
            this.linkLabel_LicesesHist.Size = new System.Drawing.Size(164, 19);
            this.linkLabel_LicesesHist.TabIndex = 4;
            this.linkLabel_LicesesHist.TabStop = true;
            this.linkLabel_LicesesHist.Text = "Show Licenses History";
            this.linkLabel_LicesesHist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LicesesHist_LinkClicked);
            // 
            // ctrlFindLocalLicens1
            // 
            this.ctrlFindLocalLicens1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlFindLocalLicens1.Location = new System.Drawing.Point(20, 64);
            this.ctrlFindLocalLicens1.Name = "ctrlFindLocalLicens1";
            this.ctrlFindLocalLicens1.Size = new System.Drawing.Size(934, 550);
            this.ctrlFindLocalLicens1.TabIndex = 0;
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
            this.btnIssue.Location = new System.Drawing.Point(614, 845);
            this.btnIssue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(132, 34);
            this.btnIssue.TabIndex = 17;
            this.btnIssue.Text = "Replace";
            this.btnIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
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
            this.btnClose.Location = new System.Drawing.Point(799, 845);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(108, 34);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // ReplaceforLostOrDamged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 879);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linkLabel_LicenseInfo);
            this.Controls.Add(this.linkLabel_LicesesHist);
            this.Controls.Add(this.LB_Header);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlFindLocalLicens1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReplaceforLostOrDamged";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReplaceforLostOrDamged";
            this.Load += new System.EventHandler(this.ReplaceforLostOrDamged_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Licenss.ctrlFindLocalLicens ctrlFindLocalLicens1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label LB_Header;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.LinkLabel linkLabel_LicenseInfo;
    private System.Windows.Forms.LinkLabel linkLabel_LicesesHist;
    private System.Windows.Forms.RadioButton RB_Lost;
    private System.Windows.Forms.RadioButton RB_Damged;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LB_ApplicationFees;
        private System.Windows.Forms.Label LB_AppDate;
        private System.Windows.Forms.Label LB_NewAppID;
        private System.Windows.Forms.Label LB_NewLicenseID;
        private System.Windows.Forms.Label LB_OldLicesneID;
        private System.Windows.Forms.Label LB_CreatedBy;
        private FontAwesome.Sharp.IconButton btnIssue;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}