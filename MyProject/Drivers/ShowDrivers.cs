using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BussnisLayer;

namespace MyProject.Drivers
{
    public partial class ShowDrivers : Form
    {
        DataTable AllDrivers;
        DataView FilterView = new DataView();
        public ShowDrivers()
        {
            InitializeComponent();
            AllDrivers = clsDrivers.GetAllDrivers();
            CB_Filter.SelectedItem = 0;
        }

        private void ShowDrivers_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = AllDrivers;
            FilterView = AllDrivers.DefaultView;
            clsCommanStyls.StyleDataGridView(dataGridView1);
            LB_RecNom.Text = AllDrivers.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e) => this.Close();

        private void btnClose_Click(object sender, EventArgs e)
        => this.Close();

        private void TB_Filter_TextChanged_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TB_Filter.Text.Trim()))
            {
                AllDrivers = clsDrivers.GetAllDrivers();
                dataGridView1.DataSource = AllDrivers;
                clsCommanStyls.StyleDataGridView(dataGridView1);
                LB_RecNom.Text = dataGridView1.Rows.Count.ToString();
                return;
            }
      
           
            switch (CB_Filter.SelectedIndex)
            {
                case 1:
                    FilterByint("DriverID", TB_Filter.Text.Trim());

                    break;
                case 2:
                    FilterByint("PersonID", TB_Filter.Text.Trim());
                    break;
                case 3:
                    FilterByString("FullName", TB_Filter.Text.Trim());
                    break;

            }
        }


        private void FilterByint(string FilterByColumn, string FilterByValue)
        {
            //FilterView.RowFilter = $"CONVERT({FilterByColumn}, 'System.String') LIKE '%{FilterByValue}%'";


            FilterView.RowFilter = string.Format("[{0}] = {1}", FilterByColumn, FilterByValue);

            dataGridView1.DataSource = FilterView;
            LB_RecNom.Text = FilterView.Count.ToString();

        }
        private void FilterByString(string FilterByColumn, string FilterByValue)
        {
            //FilterView.RowFilter = $"{FilterByColumn} LIKE '%{FilterByValue}%'";

            FilterView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterByColumn, FilterByValue);
            dataGridView1.DataSource = FilterView;
            LB_RecNom.Text = FilterView.Count.ToString();
        }

        private void CB_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_Filter.Visible = (CB_Filter.SelectedIndex != 0);

        }

    }
}
