using BussnisLayer;
using MyProject.Licenss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MyProject
{
    public partial class RenewLicense : Form
    {

        clsLocalLicens _OldLicese = null;
        clsLocalLicens _NewLicesne = null;

        clsApplication _NewApplication = null;

        public RenewLicense()
        {
            InitializeComponent();
            ctrlFindLocalLicens1.FoundDone += FoundDone;
        }

        private void FoundDone(int LiceseId)
        {
            _OldLicese = clsLocalLicens.FindByLicenseID(LiceseId);


            if (_OldLicese.ExpirationDate > DateTime.Now)
            {
                MessageBox.Show($"this License is active already , deactivation appoint of it after {(int)(_OldLicese.ExpirationDate - DateTime.Now).TotalDays} Day(s) from now");
                btnIssue.Enabled = false;
                groupBox1.Enabled = false;
                return;
            }


            Preparing();
            

        }

        private void Preparing()
        {
  
            // prepare new Application Data
            _NewApplication = new clsApplication();
            _NewApplication.ApplicationTypeID = (int)clsApplication.enApplicationType.Renew;
            _NewApplication.AppDate = DateTime.Now;
            _NewApplication.PersonID = clsDrivers.GetPersonIDByDriverID(_OldLicese.DriverID);
            _NewApplication.Status = clsApplication.enStatus.Completed;
            _NewApplication.lastStatusDate = DateTime.Now;
            _NewApplication.Fees = clsApplicationType.Find((int)clsApplication.enApplicationType.Renew).Fees;
            _NewApplication.UserCreatedID = clsGlobalUser.GlobalUser.ID;

            // prepare new License Data

            clsLicensClass crntLicenseClass = clsLicensClass.Find(_OldLicese.LicenseClassID);

            _NewLicesne = new clsLocalLicens();
            _NewLicesne.DriverID = _OldLicese.DriverID;
            _NewLicesne.LicenseClassID = _OldLicese.LicenseClassID;
            _NewLicesne.IsActive = true;
            _NewLicesne._Mode = clsLocalLicens.enMode.AddNew;
            _NewLicesne.Notes = TB_Notes.Text;
            _NewLicesne.IssueDate = DateTime.Now;
            _NewLicesne.ExpirationDate = DateTime.Now.AddYears(crntLicenseClass.ValidtyLength);
            _NewLicesne.IssueReason = clsLocalLicens.enIssueReason.Renew;
            _NewLicesne.CreatedByUserID = clsGlobalUser.GlobalUser.ID;
            _NewLicesne.PaidFees = crntLicenseClass.Fees;


            SetDefValues();

        }

        private void SetDefValues()
        {

            LB_IssueDate.Text = DateTime.Now.ToString("dd/MMM/yyyyy");
            LB_RAppDate.Text = DateTime.Now.ToString("dd/MMM/yyyyy");
            LB_ExpirationDate.Text = DateTime.Now.AddYears(clsLicensClass.Find(_OldLicese.LicenseClassID).ValidtyLength).ToString("dd/MMM/yyyyy");
            LB_CreatedBy.Text = clsGlobalUser.GlobalUser.UserName;
            LB_OldLicesseID.Text = _OldLicese.LicenseID.ToString();

            LB_AppFees.Text = _NewApplication.Fees.ToString("0.00");
            LB_LiceseFees.Text = clsLicensClass.Find(_OldLicese.LicenseClassID).Fees.ToString("0.00");
            LB_Totalfees.Text = (decimal.Parse(LB_AppFees.Text) + decimal.Parse(LB_LiceseFees.Text)).ToString("0.00");




        }


        private void btn_Issue_Click(object sender, EventArgs e)
        {
          



        }

        private void btn_Cancel_Click(object sender, EventArgs e) => this.Close();

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicensInfo frm = new ShowLicensInfo(_NewLicesne.BaseApplicationID);
            frm.ShowDialog();
        }

        private void linkLabel_LicesesHist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (_OldLicese != null)
            {
                PersonLicenseHistory frm = new PersonLicenseHistory(_OldLicese._BaseApplicationInfo.PersonID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choice Licese First" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Isseu this Licesne ?", "Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;




            if (!_NewApplication.SaveNewApp((int)clsApplication.enApplicationType.Renew))
            {
                MessageBox.Show("Something went wrong while applying for a new Appliation", "Error", MessageBoxButtons.OK);
                return;
            }
            _NewLicesne.BaseApplicationID = _NewApplication.BaseApplicationID;

            if (!_NewLicesne.Save())
            {
                MessageBox.Show("Something went wrong while Create new Licese", "Error", MessageBoxButtons.OK);
                _NewApplication.Cancel();
                _NewApplication = null;
                return;
            }

            if (clsLocalLicens.DeActivateLicense(_OldLicese.LicenseID))
                MessageBox.Show($"{_NewApplication.PersonInfo.FullName} Now has new Licesne with ID: {_NewLicesne.LicenseID}", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);


            btnIssue.Enabled = false;
            linkLabel_LicenseInfo.Enabled = true;
            LB_NewLiceseID.Text = _NewLicesne.LicenseID.ToString();
            LB_RenewAppID.Text = _NewApplication.BaseApplicationID.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
