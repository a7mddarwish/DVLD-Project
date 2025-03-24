using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject.Local_Driving_Licenses
{
    public partial class ShowLocalDrivingLicensInfo : Form
    {
        int _LocalDrivingLicensID = -1;
        public ShowLocalDrivingLicensInfo(int LocalDLID)
        {
            InitializeComponent();
            _LocalDrivingLicensID = LocalDLID;
        }

        private void ShowLocalDrivingLicensInfo_Load(object sender, EventArgs e)
        {
            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID(_LocalDrivingLicensID);
        }

        private void button1_Click(object sender, EventArgs e) => this.Close();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
