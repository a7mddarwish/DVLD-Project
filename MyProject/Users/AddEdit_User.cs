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
    public partial class AddEdit_User : Form
    {
        bool HasAUser = false;
        clsUser _User = new clsUser();

        public AddEdit_User(int UserID)
        {
            InitializeComponent();
            SetDefValues();

            if (UserID != -1)
             SetUserInfo(UserID);
           
        }

        private void SetUserInfo(int userID)
        {
            _User = clsUser.Find(userID);
            TB_UserName.Text = _User.UserName;
            find_ShowPerson1.LoadByID(_User.UPerson.ID);
            LB_ID.Text = _User.ID.ToString();
            TB_Confirm.Text =_User.Password;
            TB_Pass.Text = _User.Password;
            ActivationCheck.Checked = _User.IsActive;


            LB_Header.Text = "Update User Info";
            LB_Header.Location = tabControl1.Location;
        }

        private void SetDefValues()
        {

            TB_Confirm.Text = string.Empty;
            TB_UserName.Text = string.Empty;
            TB_Pass.Text = string.Empty;    
            ActivationCheck.Checked = false;
            LB_ID.Text = "[???]";
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
           
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
              

        }

        private void CollectUserData()
        {
            if (! this.ValidateChildren())
            {
                MessageBox.Show("Enter a valid data");
                
                
                return; }

            _User.UPerson = clsPerson.Find(find_ShowPerson1.PersonID);
            _User.UserName = TB_UserName.Text.Trim();
            _User.Password = TB_Pass.Text.Trim();
            _User.IsActive = ActivationCheck.Checked;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("It seems like you're just about to leave." , "Check" , MessageBoxButtons.YesNo , MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void textBox3_Leave(object sender, System.EventArgs e)
        {
            if(TB_Confirm.Text != TB_Confirm.Text)
            {
                errorProvider1.SetError(TB_Confirm, "No match password \n Try Again");
                errorProvider1.SetIconPadding(TB_Confirm, 5);
                TB_Confirm.Text = "";
            }
           else errorProvider1.Clear();
            HasAUser = true;
            TB_Leave(sender , e);
        }

        private void TB_Pass_TextChanged(object sender, System.EventArgs e)
        {
            if ( ((TextBox)sender).Text.Length <4 )
            {
                errorProvider1.SetError(TB_Pass, "Password must be more than 4 digits" );
                errorProvider1.SetIconPadding(TB_Pass, 5);
                
               // errorProvider1.Icon = SystemIcons.Error;

            }
            else errorProvider1.Clear();

        }

        private void TB_Leave(object sender, System.EventArgs e)
        {

                if (clsUser.IsUserNameExists(TB_UserName.Text))
                {
                    errorProvider1.SetError(TB_UserName, "This Username is already existes \n Enter anuther username");
                    errorProvider1.SetIconPadding(TB_UserName, 5);
                    TB_UserName.Focus();
                    TB_UserName.SelectAll();
                }
            
        }

        private void TB_UserName_Validating(object sender, CancelEventArgs e)
        {
            if ( String.IsNullOrEmpty(((TextBox)sender).Text))
            {
                errorProvider1.SetError((TextBox)sender , "Enter a valied value here !");
                errorProvider1.SetIconPadding(TB_Pass, 5);
                ((TextBox)sender).Focus();
                ((TextBox)sender).SelectAll();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CollectUserData();
            if (_User.Save())
            {
                MessageBox.Show("Done الحمد لله");
                LB_ID.Text = _User.ID.ToString();
                LB_Header.Text = "Update User Info";
                btnSave.Enabled = false;
                
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!find_ShowPerson1.HasPerosn)
            {
                MessageBox.Show("Please Choice Person First", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (clsUser.FindByPersonID(find_ShowPerson1.PersonID) != null)
            {
                MessageBox.Show("This Person is already user in the system.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            tab_User.Enabled = true;
            tabControl1.SelectedIndex = 1;

        }

        private void btnClose_Click(object sender, EventArgs e)
       => this.Close();

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddEdit_User_Load(object sender, EventArgs e)
        {
            tab_User.Enabled = false;
        }
    }
}
