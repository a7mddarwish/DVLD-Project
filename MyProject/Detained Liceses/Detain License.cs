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
    public partial class Detain_License : Form
    {
        clsLocalLicens _crntLicense;
        clsDetaindLicense _detainLicense;

        public Detain_License()
        {
            InitializeComponent();
            ctrlFindLocalLicens1.FoundDone += Found;
        }

        private void Found(int LiceseId)
        {
           _crntLicense = clsLocalLicens.FindByLicenseID(LiceseId);
            linkLabel_LicenseInfo.Enabled = true;
            linkLabel_LicesesHist.Enabled = true;   

            SetDefValue();

            if (clsDetaindLicense.IsLicenseDetained(LiceseId))
            {
                MessageBox.Show("This License already detained" , "hint" , MessageBoxButtons.OK , MessageBoxIcon.Information);
                btnDetain.Enabled = false;
                return;
            }

            btnDetain.Enabled = true;
        }

        private void SetDefValue()
        {
            LB_DetainDate.Text = DateTime.Now.ToString("dd/MMM/yyyyy");
            LB_DetaindBy.Text = clsGlobalUser.GlobalUser.UserName;
            LB_LicenseID.Text = _crntLicense.LicenseID.ToString();

        }

        private void button1_Click(object sender, EventArgs e) => this.Close();

        private void btn_Issue_Click(object sender, EventArgs e)
        {
          

        }

        private void CollectDate()
        {
            _detainLicense = new clsDetaindLicense();

            _detainLicense.LicenseID = _crntLicense.LicenseID;
            _detainLicense.DetainDate = DateTime.Now;
            _detainLicense.FineFees = decimal.Parse(textBox1.Text);
            _detainLicense.DetainByUserID = clsGlobalUser.GlobalUser.ID;
            _detainLicense.IsReleased = false;
            _detainLicense.ReleaseDate = null;
            _detainLicense.ReleasedByUserID = null;
            _detainLicense.ReleaseApplicationID = null;

        }

        private void linkLabel_LicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ShowLicensInfo frm = new ShowLicensInfo(_crntLicense.BaseApplicationID);
            frm.ShowDialog();
        }

        private void linkLabel_LicesesHist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
                PersonLicenseHistory frm = new PersonLicenseHistory(_crntLicense._BaseApplicationInfo.PersonID);
                frm.ShowDialog();
          
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // منع إدخال الحرف
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter fine fees amount per doller", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure to Detain this Licesne ?", "Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            CollectDate();

            if (_detainLicense.Save())
            {
                MessageBox.Show($"License detaned successfully with ID: {_detainLicense.DetainID}.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnDetain.Enabled = false;
                LB_DetainID.Text = _detainLicense.DetainID.ToString();
                return;
            }

            MessageBox.Show("Somthing goes wrong during Detained process , try later", "Not complete", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
