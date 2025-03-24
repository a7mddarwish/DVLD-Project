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
using System.IO;
using DVLD.Classes;

namespace MyProject
{
    public partial class AddEdit_Person : Form

    {
        public delegate void GetPersonEventHandler(clsPerson Person, int PersonID);
        public event GetPersonEventHandler GetPersonDone;

        private clsPerson ThisPerson = new clsPerson();
        string ImgOldPath = null;
        public AddEdit_Person(int ID)
        {
            InitializeComponent();

            
            SetDefaultValues();

            if (ID != -1)
                 SetPersonData(ID);
          
        }

        private void SetPersonData(int ID)
        {
            ThisPerson = new clsPerson();
          
            ThisPerson = clsPerson.Find(ID);
            if (ThisPerson == null)
            {
                MessageBox.Show("This person doese not here !" , "Error" , MessageBoxButtons.OK ,MessageBoxIcon.Error);
                this.Close();
            }
            LB_Header.Text = "Update Person Info";
            if (! string.IsNullOrEmpty(ThisPerson.ImagePath))
            lLB_remove.Visible = true;

            LB_ID.Text = ThisPerson.ID.ToString();
            TB_FN.Text = ThisPerson.FirstName;
            TB_SN.Text = ThisPerson.SecondName;
            TB_TN.Text = ThisPerson.ThirdName;
            TB_LN.Text = ThisPerson.LastName;

            TB_Mail.Text = ThisPerson.Email;
            TB_Ph.Text = ThisPerson.Phone;
            TB_Adrs.Text = ThisPerson.Address;

            TB_NN.Text = ThisPerson.NationalNom;
            DateTB.Value = ThisPerson.DateOfBirth;
            if (ThisPerson.Gender.ToLower() == "male")
                RB_M.Checked = true;
            else
                RB_F.Checked = true;

            CB_Cntry.SelectedIndex = ThisPerson.CountryInfo.ID;
            if (!String.IsNullOrEmpty(PB_img.ImageLocation))
            {
                PB_img.ImageLocation=PB_img.ImageLocation;
            }
            ImgOldPath = PB_img.ImageLocation;

        }

        private void SetDefaultValues()
        {
            DateTB.MaxDate= DateTime.Now.AddYears(-18);

            foreach(string Country in clsCountry.GetAllCountriesName())
            {
             CB_Cntry.Items.Add(Country);
            }
            CB_Cntry.SelectedIndex = CB_Cntry.Items.IndexOf("Egypt");

            RB_M.Checked = true;

            PB_img.Image = Image.FromFile("C:\\Users\\METRA\\Desktop\\Pics\\Def_Man.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private bool CollectData()
        {
            
            ThisPerson.FirstName = TB_FN.Text;
            ThisPerson.SecondName = TB_SN.Text;
            ThisPerson.ThirdName = TB_TN.Text;
            ThisPerson.LastName = TB_LN.Text;

            if (! String.IsNullOrEmpty(TB_Mail.Text))
            {
             
                if (! clsValidatoin.ValidateEmail(TB_Mail.Text))
                {
                    errorProvider1.SetError(TB_Mail, "Enter valied Email Address !");
                    return false;
                }
                else
                {
                    ThisPerson.Email = TB_Mail.Text;
                }

            }
            ThisPerson.Phone = TB_Ph.Text;
            ThisPerson.Address = TB_Adrs.Text;


            ThisPerson.NationalNom = TB_NN.Text;
            ThisPerson.Gender = (RB_F.Checked) ? "female" : "male";

            ThisPerson.DateOfBirth = DateTB.Value;
            
            ThisPerson.CountryInfo = clsCountry.Find(CB_Cntry.SelectedIndex+1); 

            return _HandlePersonImage();

        }

        private bool _HandlePersonImage()
        {

            //this function will handle the person image,
            //it will take care of deleting the old image from the folder
            //in case the image changed. and it will rename the new image with guid and 
            // place it in the images folder.


            //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
            if (ThisPerson.ImagePath != PB_img.ImageLocation)
            {
            
                if (! String.IsNullOrEmpty(ThisPerson.ImagePath))
                {
                    //first we delete the old image from the folder in case there is any.

                    try
                    {
                        File.Delete(ThisPerson.ImagePath);
                    }
                    catch (IOException)
                    {
                        // We could not delete the file.
                        //log it later   
                    }
                }

                if (PB_img.ImageLocation != null)
                {
                    //then we copy the new image to the image folder after we rename it
                    string SourceImageFile = PB_img.ImageLocation;

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                      
                        PB_img.ImageLocation = SourceImageFile;
                        ThisPerson.ImagePath = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }


        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void TB_Mail_Leave(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)sender;

            if (!String.IsNullOrEmpty(TB.Text))
            {
                if (!TB.Text.Contains('@') || !TB.Text.Contains('.'))
                {
                    errorProvider1.DataSource = TB;
                    errorProvider1.SetError(TB, "Please enter valied email");
                    TB.Focus();
                }
                else errorProvider1.Clear();



            }
            else errorProvider1.Clear();
                
        }

        private void SetDefImage()
        {
           
              
                if (RB_F.Checked)
                    PB_img.Image = Image.FromFile("C:\\Users\\METRA\\Desktop\\Pics\\Def_Woman.png");
                else
                    PB_img.Image = Image.FromFile("C:\\Users\\METRA\\Desktop\\Pics\\Def_Man.png");
            
            // Image location here is empty عشان أما أخزن صورة هخزنها فيها وتبقا بيان ليا أنا معايا صورة ولا لا
        }

        private void RB_F_CheckedChanged(object sender, EventArgs e)
        {
            if (ThisPerson == null || ThisPerson.ImagePath == null) SetDefImage();

        }

        private void lLB_Set_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "C:\\";

            dlg.Filter = "(*.*)|*.*";
            dlg.Title = "Chose your image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
               
                //if (PB_img.ImageLocation != null)
                //    DeleteImge();
                PB_img.ImageLocation = dlg.FileName;
            //    PB_img.Image = Image.FromFile(PB_img.ImageLocation);
                lLB_remove.Visible = true;
            }
        }

        private void DeleteImge()
        {
            if (ThisPerson == null || ThisPerson.ImagePath == null)
            {
                SetDefImage();
                return;
            }
            if (String.IsNullOrEmpty(PB_img.ImageLocation))
                return;
            
            File.Delete(PB_img.ImageLocation);
            PB_img.ImageLocation = null;
            SetDefImage();
        }

        private void lLB_remove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteImge();
            PB_img.ImageLocation = null;
            lLB_remove.Visible=false;
            RB_F_CheckedChanged(sender  , e);
        }

        private string CopyImage()
        {
            if (PB_img.ImageLocation == null )
                return null;
            string NewFileName = $"D:\\PeoplePics\\{Guid.NewGuid()}.{Path.GetExtension(PB_img.ImageLocation)}";
            
            File.Copy(PB_img.ImageLocation , NewFileName);

            return NewFileName;
        }

        private void TB_NN_Leave(object sender, EventArgs e)
        {
            if (clsPerson.IsPersonExist(((TextBox)sender).Text))
            {
                TB_NN.Focus();
                errorProvider1.SetIconPadding((TextBox)sender , 5);
                errorProvider1.SetError(TB_NN, "this National number is alredy existes \n Enter Your National Number carfuly");
            }
            else
             {
                errorProvider1.Clear();

            }
        }

        private void RB_M_CheckedChanged(object sender, EventArgs e)
        {
             if (ThisPerson == null || ThisPerson.ImagePath == null) SetDefImage();
            
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (TB_Mail.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidatoin.ValidateEmail(TB_Mail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(TB_Mail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(TB_Mail, null);
            };

        }

        private void TB_FN_Validating(object sender, CancelEventArgs e)
        {
            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
               // e.Cancel = false;
                errorProvider1.SetError(Temp, null);
               
            }
        }

        private void TB_NN_Leave(object sender, CancelEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
                return;

            CollectData();


            if (ThisPerson.Save())
            {
                LB_Header.Text = "Update Person Info";
                LB_ID.Text = ThisPerson.ID.ToString();
                MessageBox.Show("Updated Done");
            }
            else
            {
                if (ThisPerson.Stutes == clsPerson.enStutes.Update)
                    MessageBox.Show("sothing faild in update processing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("sothing faild in AddNew processing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


            GetPersonDone?.Invoke(ThisPerson, ThisPerson.ID);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
