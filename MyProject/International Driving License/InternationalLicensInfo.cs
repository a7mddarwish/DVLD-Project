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
    public partial class InternationalLicensInfo : Form
    {
        int _LicensID {  get; set; }
        public InternationalLicensInfo(int LicenesID)
        {
            InitializeComponent();
            _LicensID = LicenesID;
        }


        private void InternationalLicensInfo_Load(object sender, EventArgs e)
        {
            ctrlInterNationalLicesneInfo1.LoadInfo(_LicensID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        => this.Close();
    }
}
