using BussnisLayer;
using MyProject.Licenss;
using MyProject.Local_Driving_Licenses;
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
    public partial class MangeLocalDL : Form
    {
        DataTable AllLocalDrives;
        public MangeLocalDL()
        {
            InitializeComponent();
            UpdateDGV();
        }
        private void UpdateDGV()
        {
             AllLocalDrives =  clsLocalApplications.GetAllApplications();
            dataGridView1.DataSource = AllLocalDrives;
            LB_ApplicationsNum.Text = AllLocalDrives.Rows.Count.ToString();
            clsCommanStyls.StyleDataGridView(dataGridView1);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddUpdateLocalDrivingLecinesApp frm = new AddUpdateLocalDrivingLecinesApp();
            frm.ShowDialog();
            UpdateDGV();
        }
        private void canelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ApplicationID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            clsLocalApplications crntApp = clsLocalApplications.GetFullAppInfoByLocalAppID(ApplicationID);
            if (crntApp != null)
            {
                
                   if ( MessageBox.Show("Do you want to cancel this application ?" , "check" 
                       , MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       if (clsApplication.CancelApplication(crntApp.BaseApplicationID))
                       {
                        MessageBox.Show("Application Canceled Done" , "" , MessageBoxButtons.OK);
                       }
                      
                    }
                
                crntApp = null;
                UpdateDGV();
            }
            else
            {
                MessageBox.Show("Invalied Application ID", "", MessageBoxButtons.OK);

            }

        }

        private void _ListTOschedualTest(clsTestType.enTestType TestType)
        {
            int LocalAppID =int.Parse( dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ListTestAppointments frm = new ListTestAppointments(LocalAppID , TestType);
            frm.ShowDialog();
            UpdateDGV();
        }
        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ListTOschedualTest(clsTestType.enTestType.Vision);
        }
        private void disableAppTests()
        {
            Tst_StreetDialog.Enabled = false;
            TstVisionDialog.Enabled = false;
            TstReadWriteDialog.Enabled = false;
        }

        private void TstReadWriteDialog_Click(object sender, EventArgs e)
        {
            _ListTOschedualTest(clsTestType.enTestType.Writen);
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalAppID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ShowLocalDrivingLicensInfo frm = new ShowLocalDrivingLicensInfo(LocalAppID);
            frm.ShowDialog();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this Application ? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int LocalAppID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            if (clsLocalApplications.Delete(LocalAppID))
                MessageBox.Show("Application Deleted succesfuly" , "Done" , MessageBoxButtons.OK);
            else
                MessageBox.Show("somthing goes wrong in deleting process", "Error", MessageBoxButtons.OK);



            UpdateDGV();


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            // Manipulate => Shecual , Issue , Show Licens info 
            // لو تم اصدار رخصة اعمل show Licens info
            // واخفي Isso licens
            // والعكس صحيح
            int LocalDrivingLicensID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            clsLocalApplications _LocalApplication = clsLocalApplications.GetFullAppInfoByLocalAppID(LocalDrivingLicensID);


            clsLocalApplications.enStatus states = _LocalApplication.Status;

            int PassedTests = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());

            
            bool IsLicensIssued = false;

            if (clsPerson.IsDriver(_LocalApplication.PersonID))
              IsLicensIssued = _LocalApplication.IsLicensIssued();


            if (PassedTests == 3 || states != clsApplication.enStatus.New)
            {
                deleteApplicationToolStripMenuItem.Enabled = false;
                canelApplicationToolStripMenuItem.Enabled = false;
                scheduleTestsToolStripMenuItem.Enabled = false;
             //   return;
            }
            else
            {
                deleteApplicationToolStripMenuItem.Enabled = true;
                canelApplicationToolStripMenuItem.Enabled  = true;
                scheduleTestsToolStripMenuItem.Enabled = true;
            }

             
            issueDrivingLicensFirstTimeToolStripMenuItem.Enabled =( PassedTests==3 && ! IsLicensIssued && states == clsApplication.enStatus.New);

          
            showLicensToolStripMenuItem.Enabled = ( states == clsApplication.enStatus.Completed);

        }

        private void scheduleTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disableAppTests();

            int PassedTests = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());

            switch (PassedTests)
            {

                case 0:
                    TstVisionDialog.Enabled = true;
                    break;
                case 1:

                    TstReadWriteDialog.Enabled = true;
                    break;
                case 2:

                    Tst_StreetDialog.Enabled = true;
                    break;

            }
        }

        private void Tst_StreetDialog_Click(object sender, EventArgs e)
        {
            _ListTOschedualTest(clsTestType.enTestType.Street);

        }

        private void issueDrivingLicensFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalAppID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            Issue_Driving_Licens frm = new Issue_Driving_Licens(LocalAppID);
            frm.ShowDialog();

            UpdateDGV();
        }

        private void showLicensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalAppID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            ShowLicensInfo frm = new ShowLicensInfo(LocalAppID);
            frm.ShowDialog();
        }

        private void showPersonLicensHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NationalNom = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            PersonLicenseHistory frm = new PersonLicenseHistory(NationalNom);
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            AddUpdateLocalDrivingLecinesApp frm = new AddUpdateLocalDrivingLecinesApp();
            frm.ShowDialog();
            UpdateDGV();
        }

        private void MangeLocalDL_Load(object sender, EventArgs e)
        {
        }
    }
}
