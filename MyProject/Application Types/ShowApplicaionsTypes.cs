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

namespace MyProject
{
    public partial class ShowApplicaionsTypes : Form
    {
        public ShowApplicaionsTypes()
        {
            InitializeComponent();
        }

        void UpdateDGV()
        {
            DataTable ApplicationTypes = clsApplicationType.GetAllApplicationTypes();
            dataGridView1.DataSource = ApplicationTypes;
            LB_AppsNum.Text = ApplicationTypes.Rows.Count.ToString();
            clsCommanStyls.StyleDataGridView(dataGridView1);


        }

        private void ShowApplicaionsTypes_Load(object sender, EventArgs e)
        {

            UpdateDGV();
        }

        private void updateApplicationInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
                return;

            int.TryParse(dataGridView1.CurrentRow.Cells[0].Value.ToString(), out int AppID);
            EditApplicationType frm = new EditApplicationType(AppID);
            frm.ShowDialog();
            UpdateDGV();


        }
    }
}
