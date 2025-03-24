namespace MyProject
{
    partial class AddUpdateLocalDrivingLecinesApp
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
            this.LB_Header = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tap_Person = new System.Windows.Forms.TabPage();
            this.find_ShowPerson1 = new MyProject.Find_ShowPerson();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.Tab_AppInfo = new System.Windows.Forms.TabPage();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_CreatedBy = new System.Windows.Forms.Label();
            this.LB_AppFees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_AppDate = new System.Windows.Forms.Label();
            this.LB_AppID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_Message = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.tabControl1.SuspendLayout();
            this.Tap_Person.SuspendLayout();
            this.Tab_AppInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Header
            // 
            this.LB_Header.AutoSize = true;
            this.LB_Header.Font = new System.Drawing.Font("Microsoft JhengHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Header.ForeColor = System.Drawing.Color.Red;
            this.LB_Header.Location = new System.Drawing.Point(353, 32);
            this.LB_Header.Name = "LB_Header";
            this.LB_Header.Size = new System.Drawing.Size(515, 55);
            this.LB_Header.TabIndex = 0;
            this.LB_Header.Text = "New local driving licens";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tap_Person);
            this.tabControl1.Controls.Add(this.Tab_AppInfo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(64, 132);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(990, 601);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Tap_Person
            // 
            this.Tap_Person.Controls.Add(this.find_ShowPerson1);
            this.Tap_Person.Controls.Add(this.btnNext);
            this.Tap_Person.Location = new System.Drawing.Point(4, 31);
            this.Tap_Person.Name = "Tap_Person";
            this.Tap_Person.Padding = new System.Windows.Forms.Padding(3);
            this.Tap_Person.Size = new System.Drawing.Size(982, 566);
            this.Tap_Person.TabIndex = 0;
            this.Tap_Person.Text = "Person Info";
            this.Tap_Person.UseVisualStyleBackColor = true;
            // 
            // find_ShowPerson1
            // 
            this.find_ShowPerson1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.find_ShowPerson1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_ShowPerson1.Location = new System.Drawing.Point(23, 0);
            this.find_ShowPerson1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.find_ShowPerson1.Name = "find_ShowPerson1";
            this.find_ShowPerson1.Size = new System.Drawing.Size(933, 513);
            this.find_ShowPerson1.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(222)))), ((int)(((byte)(235)))));
            this.btnNext.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnNext.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 38;
            this.btnNext.Location = new System.Drawing.Point(734, 513);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 45);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Tab_AppInfo
            // 
            this.Tab_AppInfo.Controls.Add(this.btnSave);
            this.Tab_AppInfo.Controls.Add(this.comboBox1);
            this.Tab_AppInfo.Controls.Add(this.label7);
            this.Tab_AppInfo.Controls.Add(this.label5);
            this.Tab_AppInfo.Controls.Add(this.LB_CreatedBy);
            this.Tab_AppInfo.Controls.Add(this.LB_AppFees);
            this.Tab_AppInfo.Controls.Add(this.label3);
            this.Tab_AppInfo.Controls.Add(this.label4);
            this.Tab_AppInfo.Controls.Add(this.LB_AppDate);
            this.Tab_AppInfo.Controls.Add(this.LB_AppID);
            this.Tab_AppInfo.Controls.Add(this.label2);
            this.Tab_AppInfo.Location = new System.Drawing.Point(4, 31);
            this.Tab_AppInfo.Name = "Tab_AppInfo";
            this.Tab_AppInfo.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_AppInfo.Size = new System.Drawing.Size(982, 566);
            this.Tab_AppInfo.TabIndex = 1;
            this.Tab_AppInfo.Text = "Application Info";
            this.Tab_AppInfo.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(222)))), ((int)(((byte)(235)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 38;
            this.btnSave.Location = new System.Drawing.Point(734, 519);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 45);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(287, 222);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 30);
            this.comboBox1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(119, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Created by :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Application Fees :";
            // 
            // LB_CreatedBy
            // 
            this.LB_CreatedBy.AutoSize = true;
            this.LB_CreatedBy.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CreatedBy.Location = new System.Drawing.Point(283, 334);
            this.LB_CreatedBy.Name = "LB_CreatedBy";
            this.LB_CreatedBy.Size = new System.Drawing.Size(63, 25);
            this.LB_CreatedBy.TabIndex = 0;
            this.LB_CreatedBy.Text = "[###]";
            // 
            // LB_AppFees
            // 
            this.LB_AppFees.AutoSize = true;
            this.LB_AppFees.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AppFees.Location = new System.Drawing.Point(283, 274);
            this.LB_AppFees.Name = "LB_AppFees";
            this.LB_AppFees.Size = new System.Drawing.Size(63, 25);
            this.LB_AppFees.TabIndex = 0;
            this.LB_AppFees.Text = "[###]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lecienecs class :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Application Date :";
            // 
            // LB_AppDate
            // 
            this.LB_AppDate.AutoSize = true;
            this.LB_AppDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AppDate.Location = new System.Drawing.Point(283, 165);
            this.LB_AppDate.Name = "LB_AppDate";
            this.LB_AppDate.Size = new System.Drawing.Size(63, 25);
            this.LB_AppDate.TabIndex = 0;
            this.LB_AppDate.Text = "[###]";
            // 
            // LB_AppID
            // 
            this.LB_AppID.AutoSize = true;
            this.LB_AppID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AppID.Location = new System.Drawing.Point(283, 119);
            this.LB_AppID.Name = "LB_AppID";
            this.LB_AppID.Size = new System.Drawing.Size(63, 25);
            this.LB_AppID.TabIndex = 0;
            this.LB_AppID.Text = "[###]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "D.L Application ID :";
            // 
            // LB_Message
            // 
            this.LB_Message.AutoSize = true;
            this.LB_Message.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Message.ForeColor = System.Drawing.Color.Red;
            this.LB_Message.Location = new System.Drawing.Point(182, 90);
            this.LB_Message.Name = "LB_Message";
            this.LB_Message.Size = new System.Drawing.Size(789, 19);
            this.LB_Message.TabIndex = 2;
            this.LB_Message.Text = "You can not change Application info , if you want to change any thinng cancel or " +
    "delete this and create another one.";
            this.LB_Message.Visible = false;
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
            this.btnClose.Location = new System.Drawing.Point(506, 740);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 45);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddUpdateLocalDrivingLecinesApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 859);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.LB_Message);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LB_Header);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddUpdateLocalDrivingLecinesApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Local Driving LecinesApp";
            this.Activated += new System.EventHandler(this.AddUpdateLocalDrivingLecinesApp_Activated);
            this.Load += new System.EventHandler(this.AddLocalDrivingLecinesApp_Load);
            this.tabControl1.ResumeLayout(false);
            this.Tap_Person.ResumeLayout(false);
            this.Tab_AppInfo.ResumeLayout(false);
            this.Tab_AppInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Header;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tap_Person;
        private System.Windows.Forms.TabPage Tab_AppInfo;
        private Find_ShowPerson find_ShowPerson1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_AppFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LB_AppDate;
        private System.Windows.Forms.Label LB_AppID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LB_CreatedBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_Message;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}