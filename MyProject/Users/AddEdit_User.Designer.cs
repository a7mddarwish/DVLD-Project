namespace MyProject
{
    partial class AddEdit_User
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
            this.components = new System.ComponentModel.Container();
            this.LB_Header = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Person = new System.Windows.Forms.TabPage();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.find_ShowPerson1 = new MyProject.Find_ShowPerson();
            this.tab_User = new System.Windows.Forms.TabPage();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.ActivationCheck = new System.Windows.Forms.CheckBox();
            this.TB_Confirm = new System.Windows.Forms.TextBox();
            this.TB_Pass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_ID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.tabControl1.SuspendLayout();
            this.tab_Person.SuspendLayout();
            this.tab_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Header
            // 
            this.LB_Header.AutoSize = true;
            this.LB_Header.Font = new System.Drawing.Font("Microsoft JhengHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Header.ForeColor = System.Drawing.Color.Red;
            this.LB_Header.Location = new System.Drawing.Point(398, 10);
            this.LB_Header.Name = "LB_Header";
            this.LB_Header.Size = new System.Drawing.Size(429, 77);
            this.LB_Header.TabIndex = 0;
            this.LB_Header.Text = "Add new user";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_Person);
            this.tabControl1.Controls.Add(this.tab_User);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F);
            this.tabControl1.Location = new System.Drawing.Point(35, 78);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1119, 628);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tab_Person
            // 
            this.tab_Person.Controls.Add(this.btnNext);
            this.tab_Person.Controls.Add(this.find_ShowPerson1);
            this.tab_Person.Location = new System.Drawing.Point(4, 31);
            this.tab_Person.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Person.Name = "tab_Person";
            this.tab_Person.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_Person.Size = new System.Drawing.Size(1111, 593);
            this.tab_Person.TabIndex = 0;
            this.tab_Person.Text = "Person Info";
            this.tab_Person.UseVisualStyleBackColor = true;
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
            this.btnNext.Location = new System.Drawing.Point(880, 536);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 45);
            this.btnNext.TabIndex = 10;
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // find_ShowPerson1
            // 
            this.find_ShowPerson1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.find_ShowPerson1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_ShowPerson1.Location = new System.Drawing.Point(87, 16);
            this.find_ShowPerson1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.find_ShowPerson1.Name = "find_ShowPerson1";
            this.find_ShowPerson1.Size = new System.Drawing.Size(936, 512);
            this.find_ShowPerson1.TabIndex = 0;
            // 
            // tab_User
            // 
            this.tab_User.Controls.Add(this.btnSave);
            this.tab_User.Controls.Add(this.ActivationCheck);
            this.tab_User.Controls.Add(this.TB_Confirm);
            this.tab_User.Controls.Add(this.TB_Pass);
            this.tab_User.Controls.Add(this.label6);
            this.tab_User.Controls.Add(this.TB_UserName);
            this.tab_User.Controls.Add(this.label5);
            this.tab_User.Controls.Add(this.LB_ID);
            this.tab_User.Controls.Add(this.label4);
            this.tab_User.Controls.Add(this.label3);
            this.tab_User.Location = new System.Drawing.Point(4, 31);
            this.tab_User.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_User.Name = "tab_User";
            this.tab_User.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tab_User.Size = new System.Drawing.Size(1111, 593);
            this.tab_User.TabIndex = 1;
            this.tab_User.Text = "User Info";
            this.tab_User.UseVisualStyleBackColor = true;
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
            this.btnSave.Location = new System.Drawing.Point(880, 536);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 45);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ActivationCheck
            // 
            this.ActivationCheck.AutoSize = true;
            this.ActivationCheck.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivationCheck.Location = new System.Drawing.Point(232, 296);
            this.ActivationCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ActivationCheck.Name = "ActivationCheck";
            this.ActivationCheck.Size = new System.Drawing.Size(98, 26);
            this.ActivationCheck.TabIndex = 3;
            this.ActivationCheck.Text = "Is Active";
            this.ActivationCheck.UseVisualStyleBackColor = true;
            // 
            // TB_Confirm
            // 
            this.TB_Confirm.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Confirm.Location = new System.Drawing.Point(232, 245);
            this.TB_Confirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_Confirm.Name = "TB_Confirm";
            this.TB_Confirm.Size = new System.Drawing.Size(130, 29);
            this.TB_Confirm.TabIndex = 2;
            this.TB_Confirm.Leave += new System.EventHandler(this.textBox3_Leave);
            this.TB_Confirm.Validating += new System.ComponentModel.CancelEventHandler(this.TB_UserName_Validating);
            // 
            // TB_Pass
            // 
            this.TB_Pass.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Pass.Location = new System.Drawing.Point(232, 191);
            this.TB_Pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_Pass.Name = "TB_Pass";
            this.TB_Pass.Size = new System.Drawing.Size(130, 29);
            this.TB_Pass.TabIndex = 1;
            this.TB_Pass.TextChanged += new System.EventHandler(this.TB_Pass_TextChanged);
            this.TB_Pass.Leave += new System.EventHandler(this.TB_Leave);
            this.TB_Pass.Validating += new System.ComponentModel.CancelEventHandler(this.TB_UserName_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Confirm Pass.";
            // 
            // TB_UserName
            // 
            this.TB_UserName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_UserName.Location = new System.Drawing.Point(232, 132);
            this.TB_UserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(130, 29);
            this.TB_UserName.TabIndex = 0;
            this.TB_UserName.Leave += new System.EventHandler(this.TB_Leave);
            this.TB_UserName.Validating += new System.ComponentModel.CancelEventHandler(this.TB_UserName_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password:";
            // 
            // LB_ID
            // 
            this.LB_ID.AutoSize = true;
            this.LB_ID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ID.Location = new System.Drawing.Point(232, 78);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(44, 22);
            this.LB_ID.TabIndex = 1;
            this.LB_ID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "UserName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "User ID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btnClose.Location = new System.Drawing.Point(522, 714);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 45);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddEdit_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 766);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LB_Header);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddEdit_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditUser";
            this.Load += new System.EventHandler(this.AddEdit_User_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Person.ResumeLayout(false);
            this.tab_User.ResumeLayout(false);
            this.tab_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Header;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Person;
        private System.Windows.Forms.TabPage tab_User;
        private Find_ShowPerson find_ShowPerson1;
        private System.Windows.Forms.TextBox TB_Confirm;
        private System.Windows.Forms.TextBox TB_Pass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ActivationCheck;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}