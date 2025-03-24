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

namespace MyProject
{
    public partial class IssueInternationalLicense : Form
    {

        clsApplicationType _ApplicationType;
        clsLocalLicens _LocalLicens;
        clsInterNationalLicenes _InternationalLicese ;
        public IssueInternationalLicense()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
         => this.Close();

        private void IssueInternationalLicense_Load(object sender, EventArgs e)
        {
            _SetDefValues();
        }

        private void _SetDefValues()
        {
            _ApplicationType = clsApplicationType.Find((int)clsApplication.enApplicationType.NewInterNAtional);
            LB_IssueDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            LB_AppDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            LB_CreatedBy.Text = clsGlobalUser.GlobalUser.UserName;
            LB_Fees.Text =_ApplicationType.Fees.ToString();
            LB_ExpirDate.Text = DateTime.Now.AddYears(clsInterNationalLicenes.DefaultValidityLength).ToString("dd/MMM/yyyy");

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void _CollectData()
        {
            _InternationalLicese = new clsInterNationalLicenes(); 
            // Fill Base Application information
            _InternationalLicese.BaseApplicationInfo.ApplicationTypeID = (int)clsApplication.enApplicationType.NewInterNAtional;
            _InternationalLicese.BaseApplicationInfo.PersonID = _LocalLicens._BaseApplicationInfo.PersonID;
            _InternationalLicese.BaseApplicationInfo.AppDate = DateTime.Now;
            _InternationalLicese.BaseApplicationInfo.lastStatusDate = DateTime.Now;
            _InternationalLicese.BaseApplicationInfo.Status = clsApplication.enStatus.Completed;
            _InternationalLicese.BaseApplicationInfo.Fees = _ApplicationType.Fees;
            _InternationalLicese.BaseApplicationInfo.UserCreatedID = clsGlobalUser.GlobalUser.ID;

            // fill international Liense

            _InternationalLicese.DriverID = clsPerson.GetDriverIDwithPersonID(_LocalLicens._BaseApplicationInfo.PersonID);
            _InternationalLicese.LocalLicensID = _LocalLicens.LicenseID;
            _InternationalLicese.IssueDate = DateTime.Now;
            _InternationalLicese.ExpirationDate = DateTime.Now;
            _InternationalLicese.IsActive = true;
            _InternationalLicese.CreatedByUserID = clsGlobalUser.GlobalUser.ID; ;

        }

        private bool _ValiedToIssue()
        {
            _LocalLicens = clsLocalLicens.FindByLicenseID(ctrlFindLocalLicens1.LicenseID);
            if (_LocalLicens == null) 
            {
                MessageBox.Show("Local License does not exist" , "Not found" , MessageBoxButtons.OK);
                return false;
            }
            if (clsInterNationalLicenes.IsDriverHasActiveInternationLicense(_LocalLicens.DriverID))
            {
                MessageBox.Show($"{_LocalLicens._BaseApplicationInfo.PersonInfo.FullName} has an active international license", "Not complete", MessageBoxButtons.OK);
                return false;
            }
            if (! _LocalLicens.IsActive)
            {
                MessageBox.Show("Local License does not Active", "Must be active", MessageBoxButtons.OK);
                return false;
            }
            if (_LocalLicens.ExpirationDate < DateTime.Now) 
            {

                MessageBox.Show("this Local Licenes is expired", "Expire License", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_LocalLicens == null)
            {
                MessageBox.Show("Choice Personal License First");
                return;
            }
            PersonLicenseHistory frm = new PersonLicenseHistory(_LocalLicens._BaseApplicationInfo.PersonID);
            frm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InternationalLicensInfo frm = new InternationalLicensInfo(_InternationalLicese.internationalLicensID);
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValiedToIssue())
            {
                return;
            }

            _CollectData();

            if (_InternationalLicese.Save())
            {
                MessageBox.Show("International license saved successfully", "Complete process", MessageBoxButtons.OK);
                LB_LLID.Text = _InternationalLicese.LocalLicensID.ToString();
                LB_ILID.Text = _InternationalLicese.internationalLicensID.ToString();
                LB_AppID.Text = _InternationalLicese.BaseApplicationInfo.ToString();
                ctrlFindLocalLicens1.EnableFilter = false;
                linkLabel2.Enabled = true;
                return;
            }
            else
            {
                MessageBox.Show("Somthing goes wrong in saving proccess", "Not Complete", MessageBoxButtons.OK);
                return;

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        => this.Close();
    }
}
