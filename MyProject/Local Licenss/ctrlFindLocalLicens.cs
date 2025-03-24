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
    public partial class ctrlFindLocalLicens : UserControl
    {
        public delegate void Found(int LiceseId);
        public event Found FoundDone;
            
        public bool EnableFilter { set
            {
                groupBox1.Enabled = value;
            }
        }
        private int _LiceseID = -1 ;
        public int LicenseID { get => _LiceseID; }
        public ctrlFindLocalLicens()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // منع إدخال الحرف
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void ctrlLicenseInfo1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        public void LoadByLicenseIDandLockFilter(int LicenseID)
        {
            if (! clsLocalLicens.IsLicenseExist(LicenseID))
            {
                MessageBox.Show($"Licesne with ID: {LicenseID} not found" , "Not completed" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }
            _LiceseID = LicenseID;
            ctrlLicenseInfo1.LoadByLiceseID(LicenseID);
            textBox1.Text = LicenseID.ToString();
            groupBox1.Enabled = false;
            FoundDone?.Invoke(LicenseID);

        }

        public void textboxfoucs() =>textBox1.Focus();

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter Old Licese ID");
            }
            _LiceseID = int.Parse(textBox1.Text);

            if (_LiceseID > 0 && clsLocalLicens.IsLicenseExist(_LiceseID))
            {
                ctrlLicenseInfo1.LoadByLiceseID(_LiceseID);
                FoundDone?.Invoke(_LiceseID);
                return;

            }

            MessageBox.Show("License not found ", "Not found", MessageBoxButtons.OK);
            ctrlLicenseInfo1.SetDefValues();
        }

       
    }
}
