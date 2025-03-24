namespace MyProject
{
    partial class Form1
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.pbUserImge = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimze = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnChangePass = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMngDetain = new FontAwesome.Sharp.IconButton();
            this.btnDetain = new FontAwesome.Sharp.IconButton();
            this.btnRelease = new FontAwesome.Sharp.IconButton();
            this.btnDetaind = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMngInterLicese = new FontAwesome.Sharp.IconButton();
            this.btnMangeLocalApps = new FontAwesome.Sharp.IconButton();
            this.btnManageApps = new FontAwesome.Sharp.IconButton();
            this.btnTestTypes = new FontAwesome.Sharp.IconButton();
            this.btn_AppsTypes = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReplace = new FontAwesome.Sharp.IconButton();
            this.btnRenew = new FontAwesome.Sharp.IconButton();
            this.btnNewinternational = new FontAwesome.Sharp.IconButton();
            this.btn_newLocalLicese = new FontAwesome.Sharp.IconButton();
            this.btn_DL_Services = new FontAwesome.Sharp.IconButton();
            this.btnApplication = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUsers = new FontAwesome.Sharp.IconButton();
            this.btnDrivers = new FontAwesome.Sharp.IconButton();
            this.btnPeople = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.lbUserName);
            this.panelTitleBar.Controls.Add(this.pbUserImge);
            this.panelTitleBar.Controls.Add(this.pictureBox2);
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.btnMinimze);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(394, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(488, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lbUserName
            // 
            this.lbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbUserName.Location = new System.Drawing.Point(172, 30);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(114, 25);
            this.lbUserName.TabIndex = 7;
            this.lbUserName.Text = "User name";
            // 
            // pbUserImge
            // 
            this.pbUserImge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUserImge.Image = global::MyProject.Properties.Resources.Person;
            this.pbUserImge.Location = new System.Drawing.Point(101, 2);
            this.pbUserImge.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.pbUserImge.Name = "pbUserImge";
            this.pbUserImge.Size = new System.Drawing.Size(56, 70);
            this.pbUserImge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserImge.TabIndex = 6;
            this.pbUserImge.TabStop = false;
            this.pbUserImge.Click += new System.EventHandler(this.pbUserImge_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::MyProject.Properties.Resources.Alarm;
            this.pictureBox2.Location = new System.Drawing.Point(40, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::MyProject.Properties.Resources.Menu;
            this.pictureBox1.Location = new System.Drawing.Point(-18, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnMinimze
            // 
            this.btnMinimze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMinimze.IconChar = FontAwesome.Sharp.IconChar.CompressArrowsAlt;
            this.btnMinimze.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimze.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinimze.Location = new System.Drawing.Point(368, 3);
            this.btnMinimze.Name = "btnMinimze";
            this.btnMinimze.Size = new System.Drawing.Size(40, 22);
            this.btnMinimze.TabIndex = 3;
            this.btnMinimze.UseVisualStyleBackColor = false;
            this.btnMinimze.Click += new System.EventHandler(this.btnMinimze_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.Location = new System.Drawing.Point(408, 3);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(40, 22);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(448, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 22);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_2);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(69, 30);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(54, 19);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 42;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(18, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(45, 42);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(394, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(488, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.panelDesktop.Controls.Add(this.pictureBox3);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(394, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(488, 971);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::MyProject.Properties.Resources.FinalLogo;
            this.pictureBox3.Location = new System.Drawing.Point(149, 206);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(146)))));
            this.panel5.Controls.Add(this.btnLogout);
            this.panel5.Controls.Add(this.btnChangePass);
            this.panel5.Controls.Add(this.iconButton2);
            this.panel5.Controls.Add(this.btnUser);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 290);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(394, 248);
            this.panel5.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.UserLargeSlash;
            this.btnLogout.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 40;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 180);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogout.Size = new System.Drawing.Size(394, 60);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnChangePass.IconChar = FontAwesome.Sharp.IconChar.Exchange;
            this.btnChangePass.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnChangePass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangePass.IconSize = 40;
            this.btnChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePass.Location = new System.Drawing.Point(0, 120);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnChangePass.Size = new System.Drawing.Size(394, 60);
            this.btnChangePass.TabIndex = 7;
            this.btnChangePass.Text = "Change password";
            this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click_1);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconButton2.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 60);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(394, 60);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.Text = "User Info";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnUser.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.IconSize = 45;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUser.Size = new System.Drawing.Size(394, 60);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "Current User ";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnCurrentUser_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(394, 110);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.Image = global::MyProject.Properties.Resources.FinalLogo;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(394, 115);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(49)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnTestTypes);
            this.panel1.Controls.Add(this.btn_AppsTypes);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnApplication);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 627);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(146)))));
            this.panel4.Controls.Add(this.btnMngDetain);
            this.panel4.Controls.Add(this.btnDetain);
            this.panel4.Controls.Add(this.btnRelease);
            this.panel4.Controls.Add(this.btnDetaind);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 464);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 158);
            this.panel4.TabIndex = 6;
            // 
            // btnMngDetain
            // 
            this.btnMngDetain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(146)))));
            this.btnMngDetain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMngDetain.FlatAppearance.BorderSize = 0;
            this.btnMngDetain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngDetain.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMngDetain.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnMngDetain.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnMngDetain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMngDetain.IconSize = 44;
            this.btnMngDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMngDetain.Location = new System.Drawing.Point(0, 120);
            this.btnMngDetain.Name = "btnMngDetain";
            this.btnMngDetain.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMngDetain.Size = new System.Drawing.Size(394, 40);
            this.btnMngDetain.TabIndex = 5;
            this.btnMngDetain.Text = "Manage Detained Liceses";
            this.btnMngDetain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMngDetain.UseVisualStyleBackColor = false;
            this.btnMngDetain.Click += new System.EventHandler(this.btnMngDetain_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(146)))));
            this.btnDetain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetain.FlatAppearance.BorderSize = 0;
            this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetain.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDetain.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.btnDetain.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDetain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetain.IconSize = 38;
            this.btnDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetain.Location = new System.Drawing.Point(0, 80);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDetain.Size = new System.Drawing.Size(394, 40);
            this.btnDetain.TabIndex = 4;
            this.btnDetain.Text = "Detain Licese";
            this.btnDetain.UseVisualStyleBackColor = false;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(146)))));
            this.btnRelease.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelease.FlatAppearance.BorderSize = 0;
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelease.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRelease.IconChar = FontAwesome.Sharp.IconChar.LockOpen;
            this.btnRelease.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnRelease.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRelease.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelease.Location = new System.Drawing.Point(0, 40);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRelease.Size = new System.Drawing.Size(394, 40);
            this.btnRelease.TabIndex = 3;
            this.btnRelease.Text = "Release Licese";
            this.btnRelease.UseVisualStyleBackColor = false;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnDetaind
            // 
            this.btnDetaind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(49)))), ((int)(((byte)(97)))));
            this.btnDetaind.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetaind.FlatAppearance.BorderSize = 0;
            this.btnDetaind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetaind.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDetaind.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown;
            this.btnDetaind.IconColor = System.Drawing.Color.DarkGray;
            this.btnDetaind.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetaind.IconSize = 22;
            this.btnDetaind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetaind.Location = new System.Drawing.Point(0, 0);
            this.btnDetaind.Name = "btnDetaind";
            this.btnDetaind.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDetaind.Size = new System.Drawing.Size(394, 40);
            this.btnDetaind.TabIndex = 2;
            this.btnDetaind.Text = "Detain Liceses";
            this.btnDetaind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetaind.UseVisualStyleBackColor = false;
            this.btnDetaind.Click += new System.EventHandler(this.iconButton17_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(146)))));
            this.panel3.Controls.Add(this.btnMngInterLicese);
            this.panel3.Controls.Add(this.btnMangeLocalApps);
            this.panel3.Controls.Add(this.btnManageApps);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 344);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 120);
            this.panel3.TabIndex = 5;
            // 
            // btnMngInterLicese
            // 
            this.btnMngInterLicese.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(146)))));
            this.btnMngInterLicese.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMngInterLicese.FlatAppearance.BorderSize = 0;
            this.btnMngInterLicese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngInterLicese.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMngInterLicese.IconChar = FontAwesome.Sharp.IconChar.EarthAfrica;
            this.btnMngInterLicese.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnMngInterLicese.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMngInterLicese.IconSize = 40;
            this.btnMngInterLicese.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMngInterLicese.Location = new System.Drawing.Point(0, 80);
            this.btnMngInterLicese.Name = "btnMngInterLicese";
            this.btnMngInterLicese.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMngInterLicese.Size = new System.Drawing.Size(394, 40);
            this.btnMngInterLicese.TabIndex = 4;
            this.btnMngInterLicese.Text = "International";
            this.btnMngInterLicese.UseVisualStyleBackColor = false;
            this.btnMngInterLicese.Click += new System.EventHandler(this.btnMngInterLicese_Click);
            // 
            // btnMangeLocalApps
            // 
            this.btnMangeLocalApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(146)))));
            this.btnMangeLocalApps.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMangeLocalApps.FlatAppearance.BorderSize = 0;
            this.btnMangeLocalApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMangeLocalApps.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMangeLocalApps.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt;
            this.btnMangeLocalApps.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnMangeLocalApps.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMangeLocalApps.IconSize = 38;
            this.btnMangeLocalApps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMangeLocalApps.Location = new System.Drawing.Point(0, 40);
            this.btnMangeLocalApps.Name = "btnMangeLocalApps";
            this.btnMangeLocalApps.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMangeLocalApps.Size = new System.Drawing.Size(394, 40);
            this.btnMangeLocalApps.TabIndex = 3;
            this.btnMangeLocalApps.Text = "Local";
            this.btnMangeLocalApps.UseVisualStyleBackColor = false;
            this.btnMangeLocalApps.Click += new System.EventHandler(this.iconButton15_Click);
            // 
            // btnManageApps
            // 
            this.btnManageApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(49)))), ((int)(((byte)(97)))));
            this.btnManageApps.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageApps.FlatAppearance.BorderSize = 0;
            this.btnManageApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageApps.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManageApps.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown;
            this.btnManageApps.IconColor = System.Drawing.Color.DarkGray;
            this.btnManageApps.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnManageApps.IconSize = 22;
            this.btnManageApps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageApps.Location = new System.Drawing.Point(0, 0);
            this.btnManageApps.Name = "btnManageApps";
            this.btnManageApps.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnManageApps.Size = new System.Drawing.Size(394, 40);
            this.btnManageApps.TabIndex = 2;
            this.btnManageApps.Text = "Manage Applications";
            this.btnManageApps.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageApps.UseVisualStyleBackColor = false;
            this.btnManageApps.Click += new System.EventHandler(this.iconButton16_Click);
            // 
            // btnTestTypes
            // 
            this.btnTestTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(49)))), ((int)(((byte)(97)))));
            this.btnTestTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTestTypes.FlatAppearance.BorderSize = 0;
            this.btnTestTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestTypes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTestTypes.IconChar = FontAwesome.Sharp.IconChar.RoadCircleCheck;
            this.btnTestTypes.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnTestTypes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTestTypes.IconSize = 40;
            this.btnTestTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestTypes.Location = new System.Drawing.Point(0, 304);
            this.btnTestTypes.Name = "btnTestTypes";
            this.btnTestTypes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTestTypes.Size = new System.Drawing.Size(394, 40);
            this.btnTestTypes.TabIndex = 4;
            this.btnTestTypes.Text = "Test Types mangement";
            this.btnTestTypes.UseVisualStyleBackColor = false;
            this.btnTestTypes.Click += new System.EventHandler(this.btnTestTypes_Click);
            // 
            // btn_AppsTypes
            // 
            this.btn_AppsTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(49)))), ((int)(((byte)(97)))));
            this.btn_AppsTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AppsTypes.FlatAppearance.BorderSize = 0;
            this.btn_AppsTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AppsTypes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_AppsTypes.IconChar = FontAwesome.Sharp.IconChar.Artstation;
            this.btn_AppsTypes.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_AppsTypes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_AppsTypes.IconSize = 38;
            this.btn_AppsTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AppsTypes.Location = new System.Drawing.Point(0, 264);
            this.btn_AppsTypes.Name = "btn_AppsTypes";
            this.btn_AppsTypes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_AppsTypes.Size = new System.Drawing.Size(394, 40);
            this.btn_AppsTypes.TabIndex = 3;
            this.btn_AppsTypes.Text = "Applications Types mangement";
            this.btn_AppsTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AppsTypes.UseVisualStyleBackColor = false;
            this.btn_AppsTypes.Click += new System.EventHandler(this.btn_AppsTypes_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(146)))));
            this.panel2.Controls.Add(this.btnReplace);
            this.panel2.Controls.Add(this.btnRenew);
            this.panel2.Controls.Add(this.btnNewinternational);
            this.panel2.Controls.Add(this.btn_newLocalLicese);
            this.panel2.Controls.Add(this.btn_DL_Services);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 204);
            this.panel2.TabIndex = 2;
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(146)))));
            this.btnReplace.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReplace.FlatAppearance.BorderSize = 0;
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplace.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReplace.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.btnReplace.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnReplace.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReplace.IconSize = 38;
            this.btnReplace.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplace.Location = new System.Drawing.Point(0, 160);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnReplace.Size = new System.Drawing.Size(394, 40);
            this.btnReplace.TabIndex = 6;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(146)))));
            this.btnRenew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRenew.FlatAppearance.BorderSize = 0;
            this.btnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenew.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRenew.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.btnRenew.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnRenew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRenew.IconSize = 44;
            this.btnRenew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenew.Location = new System.Drawing.Point(0, 120);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRenew.Size = new System.Drawing.Size(394, 40);
            this.btnRenew.TabIndex = 5;
            this.btnRenew.Text = "Renew Local Licese";
            this.btnRenew.UseVisualStyleBackColor = false;
            this.btnRenew.Click += new System.EventHandler(this.iconButton8_Click);
            // 
            // btnNewinternational
            // 
            this.btnNewinternational.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(146)))));
            this.btnNewinternational.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewinternational.FlatAppearance.BorderSize = 0;
            this.btnNewinternational.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewinternational.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNewinternational.IconChar = FontAwesome.Sharp.IconChar.EarthAfrica;
            this.btnNewinternational.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnNewinternational.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewinternational.IconSize = 40;
            this.btnNewinternational.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewinternational.Location = new System.Drawing.Point(0, 80);
            this.btnNewinternational.Name = "btnNewinternational";
            this.btnNewinternational.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNewinternational.Size = new System.Drawing.Size(394, 40);
            this.btnNewinternational.TabIndex = 4;
            this.btnNewinternational.Text = "New Internationall Licese";
            this.btnNewinternational.UseVisualStyleBackColor = false;
            this.btnNewinternational.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // btn_newLocalLicese
            // 
            this.btn_newLocalLicese.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(74)))), ((int)(((byte)(146)))));
            this.btn_newLocalLicese.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_newLocalLicese.FlatAppearance.BorderSize = 0;
            this.btn_newLocalLicese.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newLocalLicese.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_newLocalLicese.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt;
            this.btn_newLocalLicese.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_newLocalLicese.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_newLocalLicese.IconSize = 40;
            this.btn_newLocalLicese.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newLocalLicese.Location = new System.Drawing.Point(0, 40);
            this.btn_newLocalLicese.Name = "btn_newLocalLicese";
            this.btn_newLocalLicese.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btn_newLocalLicese.Size = new System.Drawing.Size(394, 40);
            this.btn_newLocalLicese.TabIndex = 3;
            this.btn_newLocalLicese.Text = "New Local Licese";
            this.btn_newLocalLicese.UseVisualStyleBackColor = false;
            this.btn_newLocalLicese.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // btn_DL_Services
            // 
            this.btn_DL_Services.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(49)))), ((int)(((byte)(97)))));
            this.btn_DL_Services.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_DL_Services.FlatAppearance.BorderSize = 0;
            this.btn_DL_Services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DL_Services.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_DL_Services.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleDown;
            this.btn_DL_Services.IconColor = System.Drawing.Color.DarkGray;
            this.btn_DL_Services.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_DL_Services.IconSize = 22;
            this.btn_DL_Services.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DL_Services.Location = new System.Drawing.Point(0, 0);
            this.btn_DL_Services.Name = "btn_DL_Services";
            this.btn_DL_Services.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_DL_Services.Size = new System.Drawing.Size(394, 40);
            this.btn_DL_Services.TabIndex = 2;
            this.btn_DL_Services.Text = "License Services";
            this.btn_DL_Services.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DL_Services.UseVisualStyleBackColor = false;
            this.btn_DL_Services.Click += new System.EventHandler(this.btn_DL_Services_Click);
            // 
            // btnApplication
            // 
            this.btnApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnApplication.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApplication.FlatAppearance.BorderSize = 0;
            this.btnApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplication.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplication.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnApplication.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnApplication.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnApplication.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplication.Location = new System.Drawing.Point(0, 0);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnApplication.Size = new System.Drawing.Size(394, 60);
            this.btnApplication.TabIndex = 1;
            this.btnApplication.Text = "Applications";
            this.btnApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplication.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApplication.UseVisualStyleBackColor = false;
            this.btnApplication.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panel5);
            this.panelMenu.Controls.Add(this.btnUsers);
            this.panelMenu.Controls.Add(this.btnDrivers);
            this.panelMenu.Controls.Add(this.btnPeople);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(394, 1055);
            this.panelMenu.TabIndex = 0;
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsers.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsers.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 230);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUsers.Size = new System.Drawing.Size(394, 60);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDrivers.IconChar = FontAwesome.Sharp.IconChar.Biking;
            this.btnDrivers.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnDrivers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.Location = new System.Drawing.Point(0, 170);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDrivers.Size = new System.Drawing.Size(394, 60);
            this.btnDrivers.TabIndex = 3;
            this.btnDrivers.Text = "Drivers";
            this.btnDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDrivers.UseVisualStyleBackColor = true;
            this.btnDrivers.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPeople.FlatAppearance.BorderSize = 0;
            this.btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeople.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPeople.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.btnPeople.IconColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnPeople.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeople.Location = new System.Drawing.Point(0, 110);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPeople.Size = new System.Drawing.Size(394, 60);
            this.btnPeople.TabIndex = 2;
            this.btnPeople.Text = "People";
            this.btnPeople.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeople.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPeople.UseVisualStyleBackColor = true;
            this.btnPeople.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(882, 1055);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnMinimze;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbUserImge;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconButton btnPeople;
        private FontAwesome.Sharp.IconButton btnUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnMngInterLicese;
        private FontAwesome.Sharp.IconButton btnMangeLocalApps;
        private FontAwesome.Sharp.IconButton btnManageApps;
        private FontAwesome.Sharp.IconButton btnTestTypes;
        private FontAwesome.Sharp.IconButton btn_AppsTypes;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnReplace;
        private FontAwesome.Sharp.IconButton btnRenew;
        private FontAwesome.Sharp.IconButton btnNewinternational;
        private FontAwesome.Sharp.IconButton btn_newLocalLicese;
        private FontAwesome.Sharp.IconButton btn_DL_Services;
        private FontAwesome.Sharp.IconButton btnApplication;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnMngDetain;
        private FontAwesome.Sharp.IconButton btnDetain;
        private FontAwesome.Sharp.IconButton btnRelease;
        private FontAwesome.Sharp.IconButton btnDetaind;
        private FontAwesome.Sharp.IconButton btnDrivers;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnChangePass;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label lbUserName;
    }
}

