using BussnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.Licenss
{
    public partial class Issue_Driving_Licens : Form
    {
        int _LocalDrivingApplicationID = 0;
        clsLocalApplications _LocalApplicationInfo;
        clsLocalLicens _Licens = null;
        int DriverID = -1;

        public Issue_Driving_Licens(int LocalDrivingApplicationID)
        {
            InitializeComponent();



            _LocalDrivingApplicationID = LocalDrivingApplicationID;
           
            _LocalApplicationInfo = clsLocalApplications.GetFullAppInfoByLocalAppID(LocalDrivingApplicationID);
            if( _LocalApplicationInfo != null ) 
             DriverID = clsPerson.GetDriverIDwithPersonID(_LocalApplicationInfo.PersonID);

        }

        private void Issue_Driving_Licens_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingApplicationID);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            

        }

        private void _CollectData()
        {
            _Licens = new clsLocalLicens();

           
            
            //public int IssueReason { get; set; }
            //public int DetainByUserID { get; set; }

            _Licens.BaseApplicationID = _LocalApplicationInfo.BaseApplicationID;
            _Licens.DriverID = DriverID;
            _Licens.LicenseClassID = _LocalApplicationInfo.LicenesClassID;
            _Licens.IssueDate = DateTime.Now;
            _Licens.ExpirationDate = DateTime.Now.AddYears(_LocalApplicationInfo.LicensClassInfo.ValidtyLength);
            _Licens.Notes = TB_Notes.Text;
            _Licens.PaidFees = _LocalApplicationInfo.Fees;
            _Licens.IsActive = true;
            _Licens.IssueReason = clsLocalLicens.enIssueReason.FirstTime;
            _Licens.CreatedByUserID = clsGlobalUser.GlobalUser.ID;



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DriverID == -1)
                DriverID = _LocalApplicationInfo.PersonInfo.MakeHimDriver();

            _CollectData();

            if (_Licens.Save() && _LocalApplicationInfo.SetComplete())
            {
                MessageBox.Show("Licens Issued successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
       => this.Close();
    }
}
