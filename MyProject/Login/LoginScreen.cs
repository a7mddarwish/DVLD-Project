using BussnisLayer;
using System;
using System.IO;
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
    public partial class LoginScreen : Form
    {

        string RemeberMeFilePath = "RememberMe.txt";
        public LoginScreen()
        {
            InitializeComponent();
            LoadSavedCredentials();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                      
            


        }
        private void SaveCredentials(string username, string password)
        {
            try
            {
                // تشفير بسيط للبيانات (يمكنك استخدام طريقة تشفير أكثر أماناً)
                string encodedUsername = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(username));
                string encodedPassword = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));

                string credentials = $"{encodedUsername}|{encodedPassword}";
                File.WriteAllText(RemeberMeFilePath, credentials);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء حفظ البيانات: {ex.Message}");
            }
        }

        private void LoadSavedCredentials()
        {
            try
            {
                if (File.Exists(RemeberMeFilePath))
                {
                    string credentials = File.ReadAllText(RemeberMeFilePath);
                    string[] parts = credentials.Split('|');

                    if (parts.Length == 2)
                    {
                        // فك تشفير البيانات
                        string username = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(parts[0]));
                        string password = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(parts[1]));

                        TB_UserName.Text = username;
                        TB_Pass.Text = password;
                        checkBox1.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل البيانات المحفوظة: {ex.Message}");
            }
        }

        private void ClearSavedCredentials()
        {
            try
            {
                if (File.Exists(RemeberMeFilePath))
                {
                    File.WriteAllText(RemeberMeFilePath, string.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء مسح البيانات المحفوظة: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.Find(TB_UserName.Text.Trim(), TB_Pass.Text.Trim());


            if (user == null)
            {
                MessageBox.Show("Somthing goes wrong in login process");
                return;
            }

            if (checkBox1.Checked)
                SaveCredentials(TB_UserName.Text.Trim(), TB_Pass.Text.Trim());
            else
                ClearSavedCredentials();

            if (!user.IsActive)
            {
                MessageBox.Show("Your Account is not active , Contact Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            clsGlobalUser.GlobalUser = clsUser.Find(user.ID);

            // MainForm frm = new MainForm(this);
            Form1 frm = new Form1(this);
            this.Hide();
            frm.ShowDialog();

        }
    }

}

