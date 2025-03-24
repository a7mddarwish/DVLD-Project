using BussnisLayer;
using DVLD.Classes;
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
    public partial class UsersMainfrm : Form
    {
        DataView FilterView = new DataView();
        DataTable AllUsers;

        public UsersMainfrm()
        {
            InitializeComponent();
        }
        private void UploadDGV()
        {
            AllUsers = clsUser.GetAllUsers();
            FilterView = AllUsers.DefaultView;
            UsersDGV.DataSource = AllUsers;
            LB_RecNom.Text = UsersDGV.RowCount.ToString(); 
            clsCommanStyls.StyleDataGridView(UsersDGV);
        }
        private void UserMainfrm_Load(object sender, EventArgs e)
        {
            UploadDGV();
            CB_Filter.SelectedIndex = 1;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddEdit_User frm = new AddEdit_User(-1);
            frm.ShowDialog();
            UploadDGV();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender , e);
        }

        private void updateUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int.TryParse(UsersDGV.CurrentRow.Cells[0].Value.ToString() , out int UserID);
            AddEdit_User frm = new AddEdit_User(UserID);
            frm.ShowDialog();
            UploadDGV();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            TB_Search.Visible = (CB_Filter.SelectedIndex != 0);
            

        }

        private void FilterByint(string FilterByColumn, string FilterByValue)
        {
            //FilterView.RowFilter = $"CONVERT({FilterByColumn}, 'System.String') LIKE '%{FilterByValue}%'";

            if (String.IsNullOrEmpty(FilterByValue))
                return;
            FilterView.RowFilter = string.Format("[{0}] = {1}", FilterByColumn, FilterByValue);

            UsersDGV.DataSource = FilterView;
            LB_RecNom.Text = FilterView.Count.ToString();

        }
        private void FilterByString(string FilterByColumn, string FilterByValue)
        {
            //FilterView.RowFilter = $"{FilterByColumn} LIKE '%{FilterByValue}%'";

            if (String.IsNullOrEmpty(FilterByValue))
                return;

            FilterView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterByColumn, FilterByValue);
            UsersDGV.DataSource = FilterView;
            LB_RecNom.Text = FilterView.Count.ToString();
        }    
     

        private void TB_Search_TextChanged(object sender, EventArgs e)
        {
            // Combo box filter ordering 
            // 0 => None , 1 => Person ID , 2 => Person Name , 3 => User ID , 4 => UserName

            if (String.IsNullOrEmpty(TB_Search.Text.Trim()))

            {
                AllUsers = clsUser.GetAllUsers();
               

                UsersDGV.DataSource = AllUsers;
                clsCommanStyls.StyleDataGridView(UsersDGV);
                LB_RecNom.Text = UsersDGV.Rows.Count.ToString();
                return;
            }

            switch (CB_Filter.SelectedIndex)
            {

                case 1:

                    FilterByint("PersonID", TB_Search.Text);
                    break;

                case 2:
                  FilterByString("FullName", TB_Search.Text);
                    
                    break;

                case 3:
                    FilterByint("ID", TB_Search.Text);

                    break;

                case 4:
                    FilterByString("UserName", TB_Search.Text);

                    break;

            }
        }

        private void TB_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((CB_Filter.SelectedIndex == 1 || CB_Filter.SelectedIndex == 3) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Cancel the key press event to prevent non-numeric characters from being entered
                e.Handled = true;
            }
        }

        private void UsersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LB_RecNom_Click(object sender, EventArgs e)
        {

        }

        private void LAbel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            AddEdit_User frm = new AddEdit_User(-1);
            frm.ShowDialog();
            UploadDGV();
        }
    }
}
