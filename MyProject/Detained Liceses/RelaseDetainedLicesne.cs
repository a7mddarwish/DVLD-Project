using BussnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MyProject
{
    public partial class RelaseDetainedLicesne : Form
    {
        clsDetaindLicense D;
        clsApplication _NewApplication;

        public RelaseDetainedLicesne()
        {
            InitializeComponent();
            ctrlFindLocalLicens1.FoundDone += Found;
        }
        public RelaseDetainedLicesne(int LiceseID)
        {
            InitializeComponent();
            ctrlFindLocalLicens1.FoundDone += Found;
            ctrlFindLocalLicens1.LoadByLicenseIDandLockFilter(LiceseID);

        }


        private void Found(int LiceseId)
        {
            D = clsDetaindLicense.FindDetainByLiceseID(LiceseId);
            linkLabel_LicenseInfo.Enabled = true;
            linkLabel_LicesesHist.Enabled = true;
            SetDetainInfo();
        }

        private void CollectData()
        {
     //       SetDetainInfo();

            _NewApplication = new clsApplication();
            _NewApplication.ApplicationTypeID = (int)clsApplication.enApplicationType.RelaseDetained;
            _NewApplication.Status = clsApplication.enStatus.Completed;
            _NewApplication.PersonID = clsLocalLicens.FindByLicenseID(D.LicenseID)._BaseApplicationInfo.PersonID;
            _NewApplication.AppDate = DateTime.Now;
            _NewApplication.lastStatusDate = DateTime.Now;
            _NewApplication.Fees = clsApplicationType.Find(_NewApplication.ApplicationTypeID).Fees;
            _NewApplication.UserCreatedID = clsGlobalUser.GlobalUser.ID;


            D.IsReleased = true;
            D.ReleaseDate = DateTime.Now;
            D.ReleasedByUserID = clsGlobalUser.GlobalUser.ID;


        }

        private void SetDetainInfo()
        {
            LB_DetainID.Text = D.DetainID.ToString();
            LB_DetainBy.Text = clsUser.Find(D.DetainByUserID).ToString();
            LB_DetainDate.Text = D.DetainDate.ToString("dd/MMM/yyyy");
            LB_FineFees.Text = D.FineFees.ToString("0.00");
            LB_LiceseID.Text = D.LicenseID.ToString();
            LB_ReleaseBy.Text = clsGlobalUser.GlobalUser.UserName;
            LB_TotalFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.RelaseDetained).Fees.ToString("0.00");
        }


        private void btn_Release_Click(object sender, EventArgs e)
        {
          
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to Release this Licesne ?", "Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;


            CollectData();


            if (!_NewApplication.SaveNewApp(_NewApplication.ApplicationTypeID))
            {
                MessageBox.Show("Something goes wrong while applying for a new Appliation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            D.ReleaseApplicationID = _NewApplication.BaseApplicationID;
            if (!D.Save())
            {
                MessageBox.Show("Something goes wrong while Updating Licese statues", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("License Released Succesfully", "Completed", MessageBoxButtons.OK);



            btnRelease.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
