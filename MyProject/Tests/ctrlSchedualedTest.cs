using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussnisLayer;

namespace MyProject.Tests
{
    public partial class ctrlSchedualedTest : UserControl
    {
        clsTestType.enTestType _TestType = clsTestType.enTestType.Vision;
        int _TestAppointmentID = -1;
        clsTestAppointment _TestAppointment = null;
        
        public clsTestType.enTestType TestType {
            
            get { return _TestType; }
        
            set 
            { 
                switch(value)
                {
                    case clsTestType.enTestType.Vision:
                        _TestType = clsTestType.enTestType.Vision;
                        groupBox1.Text = "Vision Test";
                        PB_TestImage.Image = Properties.Resources.Vision;
                        break;
                    
                    case clsTestType.enTestType.Writen:
                        _TestType = clsTestType.enTestType.Writen;
                        PB_TestImage.Image = Properties.Resources.written;

                        groupBox1.Text = "Written Test";
                        break;
                    
                    case clsTestType.enTestType.Street:
                        _TestType = clsTestType.enTestType.Street;
                        PB_TestImage.Image = Properties.Resources.Street;

                        groupBox1.Text = "Street Test";
                        break;

                }
            

            
            
            
            
            }
        
        }

        public ctrlSchedualedTest()
        {
            InitializeComponent();
        }
        public void LoadInfo(int TestAppointmentID)
        {
            _TestAppointmentID = TestAppointmentID;
            _TestAppointment = clsTestAppointment.Find(_TestAppointmentID);

            if (_TestAppointment == null ) 
            {
                
                MessageBox.Show($"Test Appointment with ID ={_TestAppointmentID} is not found" , "Does not exist" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                
                return;
            }
            TestType = _TestAppointment.TestType;
            if (_TestAppointment.IsLocked)
            {
                MessageBox.Show("This appointment is locked , get another appointment" , "worng" , MessageBoxButtons.OK , MessageBoxIcon.Hand);
                return;
            }

            _SetAppointmentInfo();
        }

        private void _SetAppointmentInfo()
        {
            LB_LDL_ID.Text = _TestAppointment.ID.ToString();
            LB_LicensClass.Text = _TestAppointment.LocalApplicationInfo.LicensClassInfo.ClassName;
            LB_Name.Text = _TestAppointment.LocalApplicationInfo.PersonInfo.FullName;
            LB_Trials.Text = _TestAppointment.LocalApplicationInfo.TotalTrialsPerTest(_TestType).ToString();
            LB_fees.Text = _TestAppointment.Fees.ToString("0.00");
            LB_Date.Text = _TestAppointment.AppointmentDate.ToString("dd/MMM/yyyy");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to save this result ?", "check", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            clsTest TestResult = new clsTest();

            TestResult.TestAppointmentID = _TestAppointment.ID;
            TestResult.Notes = textBox1.Text;
            TestResult.TestResult = RB_Pass.Checked;
            TestResult.CreatedByUserID = clsGlobalUser.GlobalUser.ID;

            if (TestResult.Save())
            {
                _TestAppointment.LockAppointment();
                MessageBox.Show("Test result saved sucessfully.", "Process complete", MessageBoxButtons.OK);
                return;
            }

            MessageBox.Show("Something goes wrong in saving process", "try later", MessageBoxButtons.OK);
            return;
        }
    }
}
