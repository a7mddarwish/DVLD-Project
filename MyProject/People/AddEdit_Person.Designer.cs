namespace MyProject
{
    partial class AddEdit_Person
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateTB = new System.Windows.Forms.DateTimePicker();
            this.lLB_remove = new System.Windows.Forms.LinkLabel();
            this.lLB_Set = new System.Windows.Forms.LinkLabel();
            this.PB_img = new System.Windows.Forms.PictureBox();
            this.CB_Cntry = new System.Windows.Forms.ComboBox();
            this.RB_F = new System.Windows.Forms.RadioButton();
            this.RB_M = new System.Windows.Forms.RadioButton();
            this.TB_TN = new System.Windows.Forms.TextBox();
            this.TB_Adrs = new System.Windows.Forms.TextBox();
            this.TB_Mail = new System.Windows.Forms.TextBox();
            this.TB_Ph = new System.Windows.Forms.TextBox();
            this.TB_NN = new System.Windows.Forms.TextBox();
            this.TB_FN = new System.Windows.Forms.TextBox();
            this.TB_SN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_LN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_ID = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Header
            // 
            this.LB_Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_Header.AutoSize = true;
            this.LB_Header.Font = new System.Drawing.Font("Lucida Bright", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Header.ForeColor = System.Drawing.Color.Red;
            this.LB_Header.Location = new System.Drawing.Point(474, 9);
            this.LB_Header.Name = "LB_Header";
            this.LB_Header.Size = new System.Drawing.Size(419, 53);
            this.LB_Header.TabIndex = 0;
            this.LB_Header.Text = "Add new person";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DateTB);
            this.panel1.Controls.Add(this.lLB_remove);
            this.panel1.Controls.Add(this.lLB_Set);
            this.panel1.Controls.Add(this.PB_img);
            this.panel1.Controls.Add(this.CB_Cntry);
            this.panel1.Controls.Add(this.RB_F);
            this.panel1.Controls.Add(this.RB_M);
            this.panel1.Controls.Add(this.TB_TN);
            this.panel1.Controls.Add(this.TB_Adrs);
            this.panel1.Controls.Add(this.TB_Mail);
            this.panel1.Controls.Add(this.TB_Ph);
            this.panel1.Controls.Add(this.TB_NN);
            this.panel1.Controls.Add(this.TB_FN);
            this.panel1.Controls.Add(this.TB_SN);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TB_LN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(48, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 478);
            this.panel1.TabIndex = 1;
            // 
            // DateTB
            // 
            this.DateTB.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTB.Location = new System.Drawing.Point(647, 82);
            this.DateTB.Name = "DateTB";
            this.DateTB.Size = new System.Drawing.Size(168, 29);
            this.DateTB.TabIndex = 7;
            // 
            // lLB_remove
            // 
            this.lLB_remove.AutoSize = true;
            this.lLB_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLB_remove.Location = new System.Drawing.Point(940, 275);
            this.lLB_remove.Name = "lLB_remove";
            this.lLB_remove.Size = new System.Drawing.Size(120, 20);
            this.lLB_remove.TabIndex = 7;
            this.lLB_remove.TabStop = true;
            this.lLB_remove.Text = "Remove Image";
            this.lLB_remove.Visible = false;
            this.lLB_remove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLB_remove_LinkClicked);
            // 
            // lLB_Set
            // 
            this.lLB_Set.AutoSize = true;
            this.lLB_Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lLB_Set.Location = new System.Drawing.Point(951, 239);
            this.lLB_Set.Name = "lLB_Set";
            this.lLB_Set.Size = new System.Drawing.Size(90, 22);
            this.lLB_Set.TabIndex = 11;
            this.lLB_Set.TabStop = true;
            this.lLB_Set.Text = "Set Image";
            this.lLB_Set.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLB_Set_LinkClicked);
            // 
            // PB_img
            // 
            this.PB_img.Location = new System.Drawing.Point(920, 80);
            this.PB_img.Name = "PB_img";
            this.PB_img.Size = new System.Drawing.Size(149, 140);
            this.PB_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_img.TabIndex = 6;
            this.PB_img.TabStop = false;
            // 
            // CB_Cntry
            // 
            this.CB_Cntry.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Cntry.FormattingEnabled = true;
            this.CB_Cntry.Location = new System.Drawing.Point(647, 189);
            this.CB_Cntry.Name = "CB_Cntry";
            this.CB_Cntry.Size = new System.Drawing.Size(168, 30);
            this.CB_Cntry.TabIndex = 9;
            // 
            // RB_F
            // 
            this.RB_F.AutoSize = true;
            this.RB_F.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_F.Location = new System.Drawing.Point(286, 133);
            this.RB_F.Name = "RB_F";
            this.RB_F.Size = new System.Drawing.Size(79, 26);
            this.RB_F.TabIndex = 4;
            this.RB_F.TabStop = true;
            this.RB_F.Text = "Femal";
            this.RB_F.UseVisualStyleBackColor = true;
            this.RB_F.CheckedChanged += new System.EventHandler(this.RB_F_CheckedChanged);
            // 
            // RB_M
            // 
            this.RB_M.AutoSize = true;
            this.RB_M.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_M.Location = new System.Drawing.Point(203, 133);
            this.RB_M.Name = "RB_M";
            this.RB_M.Size = new System.Drawing.Size(70, 26);
            this.RB_M.TabIndex = 5;
            this.RB_M.TabStop = true;
            this.RB_M.Text = "Male";
            this.RB_M.UseVisualStyleBackColor = true;
            this.RB_M.CheckedChanged += new System.EventHandler(this.RB_M_CheckedChanged);
            // 
            // TB_TN
            // 
            this.TB_TN.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_TN.Location = new System.Drawing.Point(650, 23);
            this.TB_TN.Name = "TB_TN";
            this.TB_TN.Size = new System.Drawing.Size(168, 29);
            this.TB_TN.TabIndex = 2;
            // 
            // TB_Adrs
            // 
            this.TB_Adrs.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Adrs.Location = new System.Drawing.Point(203, 257);
            this.TB_Adrs.Multiline = true;
            this.TB_Adrs.Name = "TB_Adrs";
            this.TB_Adrs.Size = new System.Drawing.Size(569, 126);
            this.TB_Adrs.TabIndex = 10;
            this.TB_Adrs.Validating += new System.ComponentModel.CancelEventHandler(this.TB_FN_Validating);
            // 
            // TB_Mail
            // 
            this.TB_Mail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Mail.Location = new System.Drawing.Point(203, 187);
            this.TB_Mail.Name = "TB_Mail";
            this.TB_Mail.Size = new System.Drawing.Size(168, 29);
            this.TB_Mail.TabIndex = 6;
            this.TB_Mail.Leave += new System.EventHandler(this.TB_Mail_Leave);
            this.TB_Mail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // TB_Ph
            // 
            this.TB_Ph.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Ph.Location = new System.Drawing.Point(647, 136);
            this.TB_Ph.Name = "TB_Ph";
            this.TB_Ph.Size = new System.Drawing.Size(168, 29);
            this.TB_Ph.TabIndex = 8;
            this.TB_Ph.Validating += new System.ComponentModel.CancelEventHandler(this.TB_FN_Validating);
            // 
            // TB_NN
            // 
            this.TB_NN.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NN.Location = new System.Drawing.Point(203, 80);
            this.TB_NN.Name = "TB_NN";
            this.TB_NN.Size = new System.Drawing.Size(168, 29);
            this.TB_NN.TabIndex = 4;
            this.TB_NN.Leave += new System.EventHandler(this.TB_NN_Leave);
            // 
            // TB_FN
            // 
            this.TB_FN.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FN.Location = new System.Drawing.Point(208, 23);
            this.TB_FN.Name = "TB_FN";
            this.TB_FN.Size = new System.Drawing.Size(168, 29);
            this.TB_FN.TabIndex = 0;
            this.TB_FN.Validating += new System.ComponentModel.CancelEventHandler(this.TB_FN_Validating);
            // 
            // TB_SN
            // 
            this.TB_SN.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_SN.Location = new System.Drawing.Point(425, 23);
            this.TB_SN.Name = "TB_SN";
            this.TB_SN.Size = new System.Drawing.Size(168, 29);
            this.TB_SN.TabIndex = 1;
            this.TB_SN.Validating += new System.ComponentModel.CancelEventHandler(this.TB_FN_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(17, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Adress:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(507, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "Country :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(507, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(507, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Date of birth :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "National No.";
            // 
            // TB_LN
            // 
            this.TB_LN.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_LN.Location = new System.Drawing.Point(868, 23);
            this.TB_LN.Name = "TB_LN";
            this.TB_LN.Size = new System.Drawing.Size(168, 29);
            this.TB_LN.TabIndex = 3;
            this.TB_LN.Validating += new System.ComponentModel.CancelEventHandler(this.TB_FN_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Person ID :";
            // 
            // LB_ID
            // 
            this.LB_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_ID.AutoSize = true;
            this.LB_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ID.Location = new System.Drawing.Point(186, 90);
            this.LB_ID.Name = "LB_ID";
            this.LB_ID.Size = new System.Drawing.Size(40, 22);
            this.LB_ID.TabIndex = 2;
            this.LB_ID.Text = "N/A";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(222)))), ((int)(((byte)(235)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(1097, 627);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 42);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(222)))), ((int)(((byte)(235)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.errorProvider1.SetIconAlignment(this.btnSave, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.Gray;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnSave.IconSize = 38;
            this.btnSave.Location = new System.Drawing.Point(935, 627);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 42);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // AddEdit_Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 683);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.LB_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LB_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddEdit_Person";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEdit_Person";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_TN;
        private System.Windows.Forms.TextBox TB_FN;
        private System.Windows.Forms.TextBox TB_SN;
        private System.Windows.Forms.TextBox TB_LN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_NN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RB_F;
        private System.Windows.Forms.RadioButton RB_M;
        private System.Windows.Forms.TextBox TB_Mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Adrs;
        private System.Windows.Forms.TextBox TB_Ph;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox PB_img;
        private System.Windows.Forms.ComboBox CB_Cntry;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel lLB_remove;
        private System.Windows.Forms.LinkLabel lLB_Set;
        private System.Windows.Forms.DateTimePicker DateTB;
        private System.Windows.Forms.Label LB_ID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}