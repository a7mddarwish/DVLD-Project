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

namespace MyProject.Licenss
{
    public partial class ctrlLicenseInfo : UserControl
    {
        int _ApplicationID = -1;

        clsApplication _Application;
        clsLocalLicens _Licens;
        public ctrlLicenseInfo()
        {
            InitializeComponent();
        }

        public void LoadInfoByApplication(int ApplicationID)
        {
            _ApplicationID = ApplicationID;
            _Application = clsApplication.FindBaseApplication(ApplicationID);
            if (_Application == null) 
            {
                MessageBox.Show($" Application with ID :{_ApplicationID} not found" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }

            _Licens = clsLocalLicens.FindByBaseApplication(_Application.BaseApplicationID);

            if (_Licens == null )
            {
                MessageBox.Show($"Somthing goes wrong during opening License of Application ID :{_Application.BaseApplicationID}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            SetInfo();


        }

        public void LoadByLiceseID(int LiceseID) 
        {

            _Licens = clsLocalLicens.FindByLicenseID(LiceseID);

            if (_Licens == null)
            {
                MessageBox.Show($"License with ID  :{LiceseID} not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SetDefValues();
                return; 

            }
            _Application = clsApplication.FindBaseApplication(_Licens.BaseApplicationID);
            _ApplicationID = _Application.BaseApplicationID;
           
            SetInfo();


        }

        public void SetDefValues()
        {
            LB_Class.Text = "[###]";
            LB_Name.Text = "[###]";
            LB_LicensID.Text = "[###]";
            LB_NN.Text =       "[###]";
            LB_Gender.Text =   "[###]";
            LB_IssueDate.Text= "[###]";
            LB_Notes.Text =    "[###]";
         LB_IssueReason.Text = "[###]";
                            
                            
            LB_IsActive.Text = "[###]";
         LB_DateOFBirth.Text = "[###]";
            LB_DriverID.Text = "[###]";
           LB_Expirdate.Text = "[###]";
            LB_ISDetaind.Text = "[###]";


            pictureBox1.Image = Properties.Resources.Def_Man;
        }

        private void SetInfo()
        {
            LB_Class.Text = clsLicensClass.Find( _Licens.LicenseClassID).ClassName;
            LB_Name.Text = _Application.PersonInfo.FullName;
            LB_LicensID.Text = _Licens.LicenseID.ToString();
            LB_NN.Text = _Application.PersonInfo.NationalNom;
            LB_Gender.Text = _Application.PersonInfo.Gender;
            LB_IssueDate.Text = _Licens.IssueDate.ToString("dd/MM/yyyy");
            LB_Notes.Text = _Licens.Notes;
            LB_IssueReason.Text = _Licens.IssueReason.ToString();
          

            LB_IsActive.Text = (_Licens.IsActive) ? "Yes" : "No";
            LB_DateOFBirth.Text = _Application.PersonInfo.DateOfBirth.ToString("dd/MMM/yyyy");
            LB_DriverID.Text = _Licens.DriverID.ToString();
            LB_Expirdate.Text = _Licens.ExpirationDate.ToString("dd/MMM/yyyy");
            // تعالى هنا 
            LB_ISDetaind.Text = clsDetaindLicense.IsLiceseDetainedString(_Licens.LicenseID);
            if (!String.IsNullOrEmpty(_Application.PersonInfo.ImagePath))
            {
                pictureBox1.ImageLocation = _Application.PersonInfo.ImagePath;
                return;
            }
     
         pictureBox1.Image =(_Application.PersonInfo.Gender == "Male") ?Properties.Resources.Def_Man : Properties.Resources.Def_Woman; 

        }


    }
}
