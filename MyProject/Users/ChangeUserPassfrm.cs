using BussnisLayer;
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
    public partial class ChangeUserPassfrm : Form
    {

        public ChangeUserPassfrm()
        {
            InitializeComponent();
            showUserInfo1.LoadUserInfo(clsGlobalUser.GlobalUser.ID);
        }

        private void ChangeUserPassfrm_Load(object sender, EventArgs e)
        {
            TB_CrntPass.Focus();      }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clsGlobalUser.GlobalUser.Password != TB_CrntPass.Text.Trim())
            {
                MessageBox.Show("Invaled password ! Enter current password again ", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                TB_CrntPass.SelectAll();
                return;
            }

            if (TB_newPass.Text.Trim() != TB_Confirm.Text.Trim())
            {
                MessageBox.Show("Enter confirm password correctly ", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                TB_Confirm.SelectAll();
                return;
            }

            clsGlobalUser.GlobalUser.Password = TB_newPass.Text.Trim();
            clsGlobalUser.GlobalUser.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (clsGlobalUser.GlobalUser.Password != TB_CrntPass.Text.Trim())
            {
                MessageBox.Show("Invaled password ! Enter current password again ", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                TB_CrntPass.SelectAll();
                return;
            }

            if (TB_newPass.Text.Trim() != TB_Confirm.Text.Trim())
            {
                MessageBox.Show("Enter confirm password correctly ", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                TB_Confirm.SelectAll();
                return;
            }

            clsGlobalUser.GlobalUser.Password = TB_newPass.Text.Trim();

           if ( clsGlobalUser.GlobalUser.Save())
            {
                MessageBox.Show("Password changed succesfully" , "Complete process" , MessageBoxButtons.OK);
                btnSave.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
       
    }
}
