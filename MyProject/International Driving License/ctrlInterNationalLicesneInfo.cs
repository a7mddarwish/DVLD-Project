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

namespace MyProject
{
    public partial class ctrlInterNationalLicesneInfo : UserControl
    {
        private int LocalLicenseID { get; set; }
        private clsInterNationalLicenes _InternationalLicese;
        public ctrlInterNationalLicesneInfo()
        {
            InitializeComponent();
        }

        public void LoadInfo(int LicesID)
        {
            _InternationalLicese = clsInterNationalLicenes.Find(LicesID);

            // Load Local Licens
            ctrlLicenseInfo1.LoadByLiceseID(_InternationalLicese.LocalLicensID);

            // Load internationalLicens
            LB_LLID.Text = _InternationalLicese.LocalLicensID.ToString();
            LB_ILID.Text = _InternationalLicese.internationalLicensID.ToString();
            LB_IssueDate.Text= _InternationalLicese.IssueDate.ToString("dd/MMM/yyyy");
            LB_ExpirDate.Text= _InternationalLicese.ExpirationDate.ToString("dd/MMM/yyyy");
            LB_AppDate.Text= _InternationalLicese.BaseApplicationInfo.AppDate.ToString("dd/MMM/yyyy");
            LB_AppID.Text = _InternationalLicese.BaseApplicationID.ToString();
            LB_CreatedBy.Text = _InternationalLicese.UserCreatedInfo.UserName;
            LB_Fees.Text = _InternationalLicese.BaseApplicationInfo.Fees.ToString("0.00");

        }


    }
}
