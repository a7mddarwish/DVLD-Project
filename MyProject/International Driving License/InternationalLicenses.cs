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
    public partial class InternationalLicenses : Form
    {
        public InternationalLicenses()
        {
            InitializeComponent();
        }

        

        private void InternationalLicense_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsInterNationalLicenes.GetAllInterNationalLicense();
            clsCommanStyls.StyleDataGridView(dataGridView1);
            LB_LicensCount.Text = dataGridView1.RowCount.ToString();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsDrivers.GetPersonIDByDriverID(int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()));
            Person_Details frm = new Person_Details(PersonID);
            frm.ShowDialog();
        }

        private void showLicesesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = clsDrivers.GetPersonIDByDriverID(int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString()));
            PersonLicenseHistory frm = new PersonLicenseHistory(PersonID);
            frm.ShowDialog();
        }

        private void showLicensDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            InternationalLicensInfo frm = new InternationalLicensInfo(LicenseID);
            frm.ShowDialog();
        }
    }
}
