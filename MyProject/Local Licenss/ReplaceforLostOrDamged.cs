using BussnisLayer;
using MyProject.Licenss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BussnisLayer.clsLocalLicens;

namespace MyProject
{
    public partial class ReplaceforLostOrDamged : Form
    {
        clsLocalLicens _OldLicese;
        clsLocalLicens _NewLicesne;

        clsApplication _NewApplication;
        public ReplaceforLostOrDamged()
        {
            InitializeComponent();
            ctrlFindLocalLicens1.FoundDone += Found;
        }

        private void Found(int LiceseId)
        {
            _OldLicese = clsLocalLicens.FindByLicenseID(LiceseId);
            if (!_OldLicese.IsActive)
            {
                MessageBox.Show("This License is not Active" , "Not completed" , MessageBoxButtons.OK);
                btnIssue.Enabled = false;
                return;
            }
            btnIssue.Enabled = true;

            SetDefValues();
        }


        private void Preparing()
            {

                // prepare new Application Data
                _NewApplication = new clsApplication();
                _NewApplication.ApplicationTypeID = (RB_Lost.Checked) ? (int)clsApplication.enApplicationType.ReplaceForLost :(int) clsApplication.enApplicationType.ReplaceForDamge;
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
                _NewLicesne.Notes = string.Empty;
                _NewLicesne.IssueDate = DateTime.Now;
                _NewLicesne.ExpirationDate = DateTime.Now.AddYears(crntLicenseClass.ValidtyLength);
                _NewLicesne.IssueReason = (RB_Lost.Checked) ? clsLocalLicens.enIssueReason.Lost: clsLocalLicens.enIssueReason.Damaged;
                _NewLicesne.CreatedByUserID = clsGlobalUser.GlobalUser.ID;
                _NewLicesne.PaidFees = crntLicenseClass.Fees;



            
        }

        private void RB_Lost_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_Lost.Checked)
            {
                LB_Header.Text = "Replace for lost";
                LB_ApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.ReplaceForLost).Fees.ToString("0.00");


            }
            else
            {
                LB_ApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.ReplaceForDamge).Fees.ToString("0.00");

                LB_Header.Text = "Replace for Damaged";
            }
        }

        private void ReplaceforLostOrDamged_Load(object sender, EventArgs e)
        {
      //      SetDefValues();
        }


        private void SetDefValues()
        {

            LB_AppDate.Text = DateTime.Now.ToString("dd/MMM/yyyyy");
            LB_OldLicesneID.Text = _OldLicese.LicenseID.ToString();
            LB_CreatedBy.Text = clsGlobalUser.GlobalUser.UserName;
            LB_ApplicationFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.ReplaceForDamge).Fees.ToString("0.00");

        }

        private void btn_Issue_Click(object sender, EventArgs e)
        {
           

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
                    MessageBox.Show("Choice Licese First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             
        }

        private void linkLabel_LicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicensInfo frm = new ShowLicensInfo(_NewLicesne.BaseApplicationID);
            frm.ShowDialog();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Isseu this Licesne ?", "Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;


            Preparing();


            if (!_NewApplication.SaveNewApp(_NewApplication.ApplicationTypeID))
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
                MessageBox.Show($"{_NewApplication.PersonInfo.FullName} Now has a new Licesne with ID: {_NewLicesne.LicenseID}", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);


            btnIssue.Enabled = false;
            linkLabel_LicenseInfo.Enabled = true;
            LB_NewLicenseID.Text = _NewLicesne.LicenseID.ToString();
            LB_NewAppID.Text = _NewApplication.BaseApplicationID.ToString();

        }
    }
}
