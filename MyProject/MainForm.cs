using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussnisLayer;
using MyProject.Drivers;
using MyProject.Local_Driving_Licenses;

namespace MyProject
{
    public partial class MainForm : Form
    {
        LoginScreen loginScreen;
        public MainForm(LoginScreen lgn)
        {
            InitializeComponent();
           loginScreen = lgn;
        }

  
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeopleMainFrm frm = new PeopleMainFrm();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersMainfrm frm = new UsersMainfrm();
            frm.ShowDialog();
        }

        private void signToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobalUser.GlobalUser = null;
            loginScreen.Show();
            this.Close();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCrntUserInfo frm = new ViewCrntUserInfo();
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeUserPassfrm frm = new ChangeUserPassfrm();
            frm.ShowDialog();
        }

        private void applicationTypesMangementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowApplicaionsTypes frm = new ShowApplicaionsTypes();
            frm.ShowDialog();
        }

        private void testTypesManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MangeTestTypes frm = new MangeTestTypes();
            frm.ShowDialog();

        }

    
        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MangeLocalDL frm = new MangeLocalDL();
            frm.ShowDialog();
        }

        private void localLicenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdateLocalDrivingLecinesApp frm = new AddUpdateLocalDrivingLecinesApp();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrivers frm = new ShowDrivers();
            frm.ShowDialog();
        }
 

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueInternationalLicense frm = new IssueInternationalLicense();
            frm.ShowDialog();
        }

        private void internationalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InternationalLicenses frm = new InternationalLicenses();  
            frm.ShowDialog();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewLicense frm = new RenewLicense();
            frm .ShowDialog();
        }

        private void replaceForLostOrDamgedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplaceforLostOrDamged frm = new ReplaceforLostOrDamged();
            frm .ShowDialog();
        }

        private void mangeDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MangeDetaindLicese frm = new MangeDetaindLicese();
            frm .ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detain_License frm = new Detain_License();
            frm.ShowDialog();
        }

        private void relaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelaseDetainedLicesne frm = new RelaseDetainedLicesne();
            frm.ShowDialog();
        }
    }
}
