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
    public partial class MangeTestTypes : Form
    {
        public MangeTestTypes()
        {
            InitializeComponent();
        }

        void UpdateDGV()
        {
            DataTable dt = clsTestType.GetAllTestTypes();
            dataGridView1.DataSource = dt;
            LB_TypesNum.Text = dt.Rows.Count.ToString();
            clsCommanStyls.StyleDataGridView(dataGridView1);
        }
        private void MangeTestTypes_Load(object sender, EventArgs e)
        {
            UpdateDGV();
        }

        private void updateTestDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int.TryParse(dataGridView1.CurrentRow.Cells[0].Value.ToString(), out int TestID);
            EditTestInfo frm = new EditTestInfo(TestID);
            frm.ShowDialog();
            UpdateDGV();

        }

      
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
