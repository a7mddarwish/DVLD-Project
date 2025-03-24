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
    public partial class MangeDetaindLicese : Form
    {
        public MangeDetaindLicese()
        {
            InitializeComponent();
        }

    
        DataTable dt = new DataTable(); 

        private void button1_Click(object sender, EventArgs e)
        {
            RelaseDetainedLicesne frm = new RelaseDetainedLicesne();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Detain_License frm = new Detain_License();
            frm.ShowDialog();
        }

        private void MangeDetaindLicese_Load(object sender, EventArgs e)
        {
            dt = clsDetaindLicense.GetAllDetainLicese();
            dataGridView1.DataSource = dt;
            LB_Count.Text = dt.Rows.Count.ToString();
            clsCommanStyls.StyleDataGridView(dataGridView1);

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int LiceseID = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());

            relaseLicenseToolStripMenuItem.Enabled = clsDetaindLicense.IsLicenseDetained(LiceseID);
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            int PersonID = clsApplication.FindBaseApplication(clsLocalLicens.FindByLicenseID(int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())).BaseApplicationID).PersonID;
            Person_Details frm = new Person_Details(PersonID);
            frm.ShowDialog();
            MangeDetaindLicese_Load(null  , null);
        }

        private void showPersonLicesesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsApplication.FindBaseApplication(clsLocalLicens.FindByLicenseID(int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString())).BaseApplicationID).PersonID;
            PersonLicenseHistory frm = new PersonLicenseHistory(PersonID);
            frm.ShowDialog();
            MangeDetaindLicese_Load(null, null);

        }

        private void relaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelaseDetainedLicesne frm = new RelaseDetainedLicesne(int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()));
            frm.ShowDialog();
            MangeDetaindLicese_Load(null, null);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RelaseDetainedLicesne frm = new RelaseDetainedLicesne();
            frm.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Detain_License frm = new Detain_License();
            frm.ShowDialog();
        }
    }
}
