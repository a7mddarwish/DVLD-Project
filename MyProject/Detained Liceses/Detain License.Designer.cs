namespace MyProject
{
    partial class Detain_License
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
            this.LB_DetainID = new System.Windows.Forms.Label();
            this.LB_DetainDate = new System.Windows.Forms.Label();
            this.LB_DetaindBy = new System.Windows.Forms.Label();
            this.LB_LicenseID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel_LicenseInfo = new System.Windows.Forms.LinkLabel();
            this.linkLabel_LicesesHist = new System.Windows.Forms.LinkLabel();
            this.btnDetain = new FontAwesome.Sharp.IconButton();
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
            this.label1.Location = new System.Drawing.Point(396, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detain License";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.LB_DetainID);
            this.groupBox1.Controls.Add(this.LB_DetainDate);
            this.groupBox1.Controls.Add(this.LB_DetaindBy);
            this.groupBox1.Controls.Add(this.LB_LicenseID);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 646);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 205);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detain Info";
            // 
            // LB_DetainID
            // 
            this.LB_DetainID.AutoSize = true;
            this.LB_DetainID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DetainID.Location = new System.Drawing.Point(197, 46);
            this.LB_DetainID.Name = "LB_DetainID";
            this.LB_DetainID.Size = new System.Drawing.Size(55, 23);
            this.LB_DetainID.TabIndex = 2;
            this.LB_DetainID.Text = "[###]";
            // 
            // LB_DetainDate
            // 
            this.LB_DetainDate.AutoSize = true;
            this.LB_DetainDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DetainDate.Location = new System.Drawing.Point(197, 96);
            this.LB_DetainDate.Name = "LB_DetainDate";
            this.LB_DetainDate.Size = new System.Drawing.Size(55, 23);
            this.LB_DetainDate.TabIndex = 2;
            this.LB_DetainDate.Text = "[###]";
            // 
            // LB_DetaindBy
            // 
            this.LB_DetaindBy.AutoSize = true;
            this.LB_DetaindBy.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DetaindBy.Location = new System.Drawing.Point(567, 96);
            this.LB_DetaindBy.Name = "LB_DetaindBy";
            this.LB_DetaindBy.Size = new System.Drawing.Size(55, 23);
            this.LB_DetaindBy.TabIndex = 2;
            this.LB_DetaindBy.Text = "[###]";
            // 
            // LB_LicenseID
            // 
            this.LB_LicenseID.AutoSize = true;
            this.LB_LicenseID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LicenseID.Location = new System.Drawing.Point(567, 46);
            this.LB_LicenseID.Name = "LB_LicenseID";
            this.LB_LicenseID.Size = new System.Drawing.Size(55, 23);
            this.LB_LicenseID.TabIndex = 2;
            this.LB_LicenseID.Text = "[###]";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 168);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fine fees :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Detain Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detained ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(397, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Detained By :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "License ID:";
            // 
            // linkLabel_LicenseInfo
            // 
            this.linkLabel_LicenseInfo.AutoSize = true;
            this.linkLabel_LicenseInfo.Enabled = false;
            this.linkLabel_LicenseInfo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_LicenseInfo.Location = new System.Drawing.Point(280, 911);
            this.linkLabel_LicenseInfo.Name = "linkLabel_LicenseInfo";
            this.linkLabel_LicenseInfo.Size = new System.Drawing.Size(134, 19);
            this.linkLabel_LicenseInfo.TabIndex = 4;
            this.linkLabel_LicenseInfo.TabStop = true;
            this.linkLabel_LicenseInfo.Text = "Show License Info";
            this.linkLabel_LicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LicenseInfo_LinkClicked);
            // 
            // linkLabel_LicesesHist
            // 
            this.linkLabel_LicesesHist.AutoSize = true;
            this.linkLabel_LicesesHist.Enabled = false;
            this.linkLabel_LicesesHist.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_LicesesHist.Location = new System.Drawing.Point(63, 911);
            this.linkLabel_LicesesHist.Name = "linkLabel_LicesesHist";
            this.linkLabel_LicesesHist.Size = new System.Drawing.Size(164, 19);
            this.linkLabel_LicesesHist.TabIndex = 5;
            this.linkLabel_LicesesHist.TabStop = true;
            this.linkLabel_LicesesHist.Text = "Show Licenses History";
            this.linkLabel_LicesesHist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LicesesHist_LinkClicked);
            // 
            // btnDetain
            // 
            this.btnDetain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(222)))), ((int)(((byte)(235)))));
            this.btnDetain.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDetain.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnDetain.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDetain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetain.IconSize = 32;
            this.btnDetain.Location = new System.Drawing.Point(641, 896);
            this.btnDetain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(124, 48);
            this.btnDetain.TabIndex = 13;
            this.btnDetain.Text = "Detain";
            this.btnDetain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetain.UseVisualStyleBackColor = false;
            this.btnDetain.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnClose.Location = new System.Drawing.Point(789, 896);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 48);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrlFindLocalLicens1
            // 
            this.ctrlFindLocalLicens1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.5F);
            this.ctrlFindLocalLicens1.Location = new System.Drawing.Point(57, 55);
            this.ctrlFindLocalLicens1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlFindLocalLicens1.Name = "ctrlFindLocalLicens1";
            this.ctrlFindLocalLicens1.Size = new System.Drawing.Size(980, 589);
            this.ctrlFindLocalLicens1.TabIndex = 15;
            // 
            // Detain_License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 960);
            this.Controls.Add(this.ctrlFindLocalLicens1);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.linkLabel_LicenseInfo);
            this.Controls.Add(this.linkLabel_LicesesHist);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Detain_License";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detain_License";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel_LicenseInfo;
        private System.Windows.Forms.LinkLabel linkLabel_LicesesHist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_DetainID;
        private System.Windows.Forms.Label LB_LicenseID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LB_DetainDate;
        private System.Windows.Forms.Label LB_DetaindBy;
        private FontAwesome.Sharp.IconButton btnDetain;
        private FontAwesome.Sharp.IconButton btnClose;
        private Licenss.ctrlFindLocalLicens ctrlFindLocalLicens1;
    }
}