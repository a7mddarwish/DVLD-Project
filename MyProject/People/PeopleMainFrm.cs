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
using System.Linq;
using System.Security.Policy;

namespace MyProject
{
    public partial class PeopleMainFrm : Form
    {
        DataView FilterView = new DataView();
        DataTable AllPeople =new DataTable();
        public PeopleMainFrm()
        {
            InitializeComponent();
            SetDefValues();
        }

        private void SetDefValues()
        {
            CB_Filter.SelectedIndex = 0;
        }

        private void ReloadDGV()
        {
            AllPeople = clsPerson.GetAllPeople();
            dataGridView1.DataSource = AllPeople;
            LB_RecNom.Text = dataGridView1.RowCount.ToString();
            FilterView = AllPeople.DefaultView;
            clsCommanStyls.StyleDataGridView( dataGridView1);
        }

        private void PeopleMainFrm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ReloadDGV();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEdit_Person frm = new AddEdit_Person(-1);  
            frm.ShowDialog();
            ReloadDGV();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEdit_Person frm = new AddEdit_Person(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            frm.ShowDialog();
            ReloadDGV();

        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender , e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this person ?" , "Question", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                if (clsPerson.DeleteByID(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())))
                {
                    notifyIcon1.Icon = SystemIcons.Application;
                    notifyIcon1.Visible = true;
                    notifyIcon1.BalloonTipText = "Deleted Sucssefully";
                    notifyIcon1.BalloonTipTitle = "Done";
                    notifyIcon1.ShowBalloonTip(2000);
                    ReloadDGV();

                }
                else
                    MessageBox.Show("Cannot delete this Person");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_Filter.Visible = (CB_Filter.SelectedIndex != 0);
        }

        private void TB_Filter_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TB_Filter.Text.Trim()))

            {
                AllPeople = clsPerson.GetAllPeople();
                dataGridView1.DataSource = AllPeople;
                clsCommanStyls.StyleDataGridView(dataGridView1);
                LB_RecNom.Text = dataGridView1.Rows.Count.ToString();
                return;
            }

            switch (CB_Filter.SelectedIndex)
            {
                case 1:
                    FilterByint("PersonID",TB_Filter.Text.Trim());

                    break;
                case 2:
                    FilterByString("FirstName" , TB_Filter.Text.Trim());
                    break;
                case 3:
                    FilterByString("SecondName" , TB_Filter.Text.Trim());
                    break;
                case 4:
                    FilterByString("ThirdName" , TB_Filter.Text.Trim());
                    break;

                 case 5:
                 FilterByString("LastName" , TB_Filter.Text.Trim());
               
                    break; 
                case 6:
                    FilterByString("Email" , TB_Filter.Text.Trim());

                    break;  
                case 7:
                    FilterByString("Phone", TB_Filter.Text.Trim());
                    break;
                
                case 8:
                    FilterByString("Address", TB_Filter.Text.Trim());
                    break;

                 case 9:
                    FilterByint("Nationality", TB_Filter.Text.Trim());
                break;

                 case 10:
                FilterByString("DateOfBirth", TB_Filter.Text.Trim());
                break;

            }
        }
      
        private void FilterByint(string FilterByColumn , string FilterByValue)
        {
            //FilterView.RowFilter = $"CONVERT({FilterByColumn}, 'System.String') LIKE '%{FilterByValue}%'";


            FilterView.RowFilter = string.Format("[{0}] = {1}"  , FilterByColumn, FilterByValue);

            dataGridView1.DataSource = FilterView;
            LB_RecNom.Text = FilterView.Count.ToString();

        }
        private void FilterByString(string FilterByColumn,string FilterByValue )
        {
            //FilterView.RowFilter = $"{FilterByColumn} LIKE '%{FilterByValue}%'";

            FilterView.RowFilter = string.Format("[{0}] LIKE '{1}%'" , FilterByColumn  , FilterByValue );
            dataGridView1.DataSource = FilterView;
            LB_RecNom.Text = FilterView.Count.ToString();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Person_Details frm = new Person_Details(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            frm.ShowDialog();
            ReloadDGV();

        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("هنعملها بعدين يا نجم");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddEdit_Person frm = new AddEdit_Person(-1);
            frm.ShowDialog();
            ReloadDGV();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
