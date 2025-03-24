using BussnisLayer;
using FontAwesome.Sharp;
using MyProject.Drivers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyProject
{
    public partial class Form1 : Form
    {
        //Fields
        private IconButton currentBtn;
        private IconButton currentSubBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        LoginScreen loginScreen;
       
        //Constructor
        public Form1(LoginScreen lgn)
        {
            loginScreen = lgn;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            HideSubMenu();


        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
               // Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void ActiveSubButton(object senderBtn, Color color)
        {

        }

        private void DisableSubButton()
        {
            if (currentSubBtn != null)
            {
                HideSubMenu();

                currentSubBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentSubBtn.ForeColor = Color.Gainsboro;
                currentSubBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentSubBtn.IconColor = Color.Gainsboro;
                currentSubBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentSubBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        } 
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                HideSubMenu();

                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //   childForm.Dock = DockStyle.Fill;
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(
                (panelDesktop.Width - childForm.Width) / 2,
                (panelDesktop.Height - childForm.Height) / 2
            );
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
          //  childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }
        //Events
        //Reset
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
            HideSubMenu();
        }
        //Menu Button_Clicks
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (panel1.Height > 80)
            {
                panel1.Height = btnApplication.Height;
                ResretSubPanels();

                return;
            }
            ActivateButton(sender, RGBColors.color1);
          //  OpenChildForm(new Applications());
            ShowSubMenu(panel1 , null);
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new PeopleMainFrm());
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
           OpenChildForm(new ShowDrivers());
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
           OpenChildForm(new UsersMainfrm());
        }
        private void btnMarketing_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
         //   OpenChildForm(new FormMarketing());
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
         //   OpenChildForm(new FormSetting());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

   

        private void btnClose_Click_2(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

  

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;

        }

        private void btnMinimze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

      public void HideSubMenu()
        {
            panel1.Height = btnApplication.Height;
            panel5.Height = btnUser.Height;
        }

        void ShowSubMenu(Panel pnl , IconButton targetbtn)
        {
            ResretSubPanels();
            if (targetbtn != null)
                targetbtn.IconChar = IconChar.CircleUp;
           pnl.Height = pnl.Controls[0].Height;
            //        pnl.Height = pnl.Controls.OfType<Button>().Count() * 30 + 15;
            foreach (Control ctrl in pnl.Controls)
            {
                   ctrl.Height = 40;
                   pnl.Height += 40;
            }
            btnApplication.Height = 60;

            if (pnl != panel1 && pnl != panel5)
            panel1.Height += pnl.Height;

            //if (pnl == panel5)
            //    panel5.Height += pnl.Height;

        }

        void ResretSubPanels()
        {
            // Set all Icon Up
            btn_DL_Services.IconChar = IconChar.CircleDown;
            btnDetaind.IconChar = IconChar.CircleDown;
            btnManageApps.IconChar = IconChar.CircleDown;
            panel5.Height = btnUser.Height;
            panel2.Height = 40;
            panel3.Height = 40;
            panel4.Height = 40;
        }

        private void btn_DL_Services_Click(object sender, EventArgs e)
        {
            if (panel2.Height > 50)
            {
                ResretSubPanels();
                return;
            }

            ShowSubMenu(panel2, (IconButton)sender);

        }

        private void iconButton17_Click(object sender, EventArgs e)
        {
            if (panel4.Height > 50)
            {
                ResretSubPanels();
                return;
            }
            ShowSubMenu(panel4 , (IconButton)sender);

        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            if (panel3.Height > 50)
            {
                ResretSubPanels();
                return;
            }
            ShowSubMenu(panel3, (IconButton)sender);

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddUpdateLocalDrivingLecinesApp());

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new IssueInternationalLicense());

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RenewLicense());

        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ReplaceforLostOrDamged());

        }

        private void btn_AppsTypes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ShowApplicaionsTypes());

        }

        private void btnTestTypes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MangeTestTypes());

        }

        private void iconButton15_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MangeLocalDL());

        }

        private void btnMngInterLicese_Click(object sender, EventArgs e)
        {
            OpenChildForm(new InternationalLicenses());

        }

        private void btnMngDetain_Click(object sender, EventArgs e)
        {

            OpenChildForm(new MangeDetaindLicese());
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Detain_License());

        }

        private void btnRelease_Click(object sender, EventArgs e)
        {

            OpenChildForm(new RelaseDetainedLicesne());
        }

        private void btncrntUserInfo_Click(object sender, EventArgs e)
        {
            if (panel5.Height > 80)
            {
                ResretSubPanels();
                return;
            }
            ActivateButton(sender, RGBColors.color1);
            //  OpenChildForm(new Applications());
            ShowSubMenu(panel5, null);
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            clsGlobalUser.GlobalUser = null;
            loginScreen.Show();
            this.Close();
        }

        private void pbUserImge_Click(object sender, EventArgs e)
        {
            panel5.Height = 188;
            panel5.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void btnCurrentUser_Click(object sender, EventArgs e)
        {
            if (panel5.Height > 80)
            {
                ResretSubPanels();
                return;
            }
            ActivateButton(sender, RGBColors.color1);
            //  OpenChildForm(new Applications());
            ShowSubMenu(panel5, null);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewCrntUserInfo());

        }

        private void btnChangePass_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ChangeUserPassfrm());

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbUserName.Text = clsGlobalUser.GlobalUser.UserName;
            if (!String.IsNullOrEmpty(clsGlobalUser.GlobalUser.UPerson.ImagePath) && File.Exists(clsGlobalUser.GlobalUser.UPerson.ImagePath))
                pbUserImge.ImageLocation = clsGlobalUser.GlobalUser.UPerson.ImagePath;
        }
    }
}
