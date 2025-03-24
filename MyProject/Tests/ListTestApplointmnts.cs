using BussnisLayer;
using MyProject.Tests;
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
    public partial class ListTestAppointments : Form
    {
        clsTestType.enTestType _TestType;
        clsLocalApplications _LocalApplication;
        int _LocalApplicationID = -1;
        public ListTestAppointments(int LocalAppID , clsTestType.enTestType testtype)
        {
            InitializeComponent();
            _LocalApplicationID = LocalAppID;
            _LocalApplication = clsLocalApplications.GetFullAppInfoByLocalAppID(_LocalApplicationID);
            _TestType = testtype;
        }

        private void LoadDGV(clsTestType.enTestType testtype)
        {


            DataTable dt = clsTestAppointment.GetAllLocalAppAppointmentsByTestType(_LocalApplicationID , testtype);
            DGV1.DataSource = dt;
            lblAppoiintmentsNom.Text = dt.Rows.Count.ToString();
            clsCommanStyls.StyleDataGridView(DGV1);



        }

        private void Vision_Test_Appointments_Load(object sender, EventArgs e)
        {
            _LoadInfo(_LocalApplicationID);
            clsCommanStyls.StyleDataGridView(DGV1);



        }

        private void _LoadInfo(int localApplicationID)
        {
            LoadDGV(_TestType);
            _SetFormDetails();
            ctrlDrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalDrivingAppID( localApplicationID);
        }

        private void _SetFormDetails()
        {

            switch (_TestType)
            {
                case clsTestType.enTestType.Vision:
                    this.Text = "Vision test appointment";
                    label1.Text = this.Text;
                    break;
                case clsTestType.enTestType.Writen:
                    this.Text = "Written test appointment";
                    label1.Text = this.Text;
                    break;
                case clsTestType.enTestType.Street:
                    this.Text = "Street test appointment";
                    label1.Text = this.Text;
                    break;



            }
        }

     

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppointmentID = int.Parse( DGV1.CurrentRow.Cells[0].Value.ToString());
           bool.TryParse(DGV1.CurrentRow.Cells[6].Value.ToString() , out bool IsLooked);

            if (IsLooked)
            {
                MessageBox.Show("This appointment is locked , you can not edit it's data");
                return;
            }

            SchedualTest frm = new SchedualTest(_LocalApplicationID, _TestType);
            frm.ShowDialog();

            LoadDGV(_TestType);

        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool.TryParse(DGV1.CurrentRow.Cells[6].Value.ToString(), out bool IsLooked);

            if (IsLooked) 
            {
                MessageBox.Show("This Appointment is look , Maybe you already take it");

                return;
            
            }
            int AppointmentID = int.Parse(DGV1.CurrentRow.Cells[0].Value.ToString());
            if (AppointmentID > 0)
            {
                TakeTest frm = new TakeTest(AppointmentID);
                frm.ShowDialog();
                LoadDGV(_TestType);

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (_LocalApplication.IsThereAnActiveScheduledTest(_TestType))
            {
                MessageBox.Show("This Application has a schedualed Appointment , finish it first", "Not complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_LocalApplication.DoesPassTestType(_TestType))
            {
                MessageBox.Show("Person Passed this test succesfully", "Not complete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SchedualTest frm = new SchedualTest(_LocalApplicationID, _TestType);
            frm.ShowDialog();
            LoadDGV(_TestType);
        }
    }
}
