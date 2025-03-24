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
    public partial class AddUpdateLocalDrivingLecinesApp : Form
    {
        enum enMode { New , Update }
        enMode _Mode = enMode.New;

        int _PersonID = -1;
        clsPerson PersonInfo;

        private clsLocalApplications _Localapp ;
        private int _LocalApplicationID = -1;

        public AddUpdateLocalDrivingLecinesApp(int LocalDrivingLicesnApplication)
        {
            _Mode = enMode.Update;
            _LocalApplicationID = LocalDrivingLicesnApplication;

            _Localapp = clsLocalApplications.GetFullAppInfoByLocalAppID(LocalDrivingLicesnApplication);
        }


        public AddUpdateLocalDrivingLecinesApp()
        {
            InitializeComponent();
            _Mode = enMode.New;
        }

        private void SetDefValues()
        {

            fillLicenClassinComboBox();

            if (_Mode == enMode.New)
            {
                LB_Header.Text = "New local driving licens";
                comboBox1.SelectedIndex = 2;
                LB_AppFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.NewLocal).Fees.ToString();
                LB_AppDate.Text = DateTime.Now.ToString("dd/MMM/yyyy");
                Tab_AppInfo.Enabled = false;
                LB_CreatedBy.Text = clsGlobalUser.GlobalUser.UserName;


            }
            else
            {
                LB_Header.Text = "Update local driving licens Info";
                Tab_AppInfo.Enabled = true;
               

            }

        }

        private void fillLicenClassinComboBox()
        {
            // Set Licens Classes
            foreach (var L in clsLicensClass.GetAllLiecesNames())
            {
                comboBox1.Items.Add(L);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to ignore this application ? " , "Quesstion" , MessageBoxButtons.YesNo , MessageBoxIcon.Warning) == DialogResult.Yes)
            this.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (!find_ShowPerson1.HasPerosn)
            {
                MessageBox.Show("Choice Person who that want application", "Enter correct info"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _PersonID = find_ShowPerson1.PersonID;
            PersonInfo = clsPerson.Find(_PersonID);
            tabControl1.SelectedIndex = 1;

            Tab_AppInfo.Enabled = true;
            btnSave.Enabled = true;



        }

        private void collectApplicationinfo()
        {
            _Localapp = new clsLocalApplications();

            _Localapp.ApplicationTypeID = (int)clsApplication.enApplicationType.NewLocal;
            _Localapp.PersonID = find_ShowPerson1.PersonID;
            _Localapp.AppDate = DateTime.Now;
            _Localapp.LicenesClassID = comboBox1.SelectedIndex+1;
            _Localapp.Fees = Convert.ToDecimal(LB_AppFees.Text);
            _Localapp.UserCreatedID = 1 ;
            _Localapp.Status = clsApplication.enStatus.New;
            _Localapp.lastStatusDate = DateTime.Now;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            if (_Mode == enMode.New)
            {

                int ActiveApplicationID = clsApplication.GetActiveApplicationID(find_ShowPerson1.PersonID, comboBox1.SelectedIndex + 1, clsApplication.enApplicationType.NewLocal);
           
                if (ActiveApplicationID != -1)
                {
                    MessageBox.Show("This person has an application of same type , choice another Application Type if you want ", "Not completed", MessageBoxButtons.OK);
                    return;
                }

                if (clsPerson.IsDriver(_PersonID))
                {
                    if (clsLocalLicens.GetActiveLicensID(PersonInfo.HisIdAsDriver(), comboBox1.SelectedIndex + 1) != -1)
                    {
                        MessageBox.Show("This person acually has an Issued Licens of same type , choice another Application Type if you want ", "Not completed", MessageBoxButtons.OK);
                        return;
                    }
                }    

           

                collectApplicationinfo();

                if (_Localapp.SaveNewApp())
                {
                    MessageBox.Show("Application Saved sucsesfully ", "Done", MessageBoxButtons.OK);
                    LB_Header.Text = "Application Info";
                    comboBox1.Enabled = false;
                    LB_Message.Visible = true;
                    find_ShowPerson1.Enabled = false;
                    LB_AppID.Text = _Localapp.LocalAppID.ToString();
                    return;
                }
                else
                    MessageBox.Show("somthing goes wrong in saving this application");


            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if ( ! find_ShowPerson1.HasPerosn)
            //{
            //    tabControl1.SelectedIndex = 0;
            //}
        }

        private void AddLocalDrivingLecinesApp_Load(object sender, EventArgs e)
        {
            SetDefValues();

            if (_Mode == enMode.Update)
                _LoadInfo();
        }

        private void _LoadInfo()
        {

            if (_Localapp == null)
            {
                MessageBox.Show($"Local Application with ID = {_LocalApplicationID} Dose not exist" , "Not found" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                this.Close();
                return;
            }

            comboBox1.SelectedIndex = _Localapp.LicenesClassID - 1;
            LB_AppDate.Text = _Localapp.AppDate.ToString("dd/MMM/yyyy");
            Tab_AppInfo.Enabled = true;
            find_ShowPerson1.DisableSearch = true;
            find_ShowPerson1.LoadByID(_Localapp.PersonID);
            LB_AppFees.Text = clsApplicationType.Find((int)clsApplication.enApplicationType.NewLocal).Fees.ToString();
            LB_AppID.Text = _Localapp.LocalAppID.ToString();
            LB_CreatedBy.Text = "عدلني هتلاقيني في AddUpdateLocal...App";
        }

        private void AddUpdateLocalDrivingLecinesApp_Activated(object sender, EventArgs e)
        {
            find_ShowPerson1.Focus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!find_ShowPerson1.HasPerosn)
            {
                MessageBox.Show("Choice Person who that want application", "Enter correct info"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _PersonID = find_ShowPerson1.PersonID;
            PersonInfo = clsPerson.Find(_PersonID);
            tabControl1.SelectedIndex = 1;

            Tab_AppInfo.Enabled = true;
            btnSave.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.New)
            {

                int ActiveApplicationID = clsApplication.GetActiveApplicationID(find_ShowPerson1.PersonID, comboBox1.SelectedIndex + 1, clsApplication.enApplicationType.NewLocal);

                if (ActiveApplicationID != -1)
                {
                    MessageBox.Show("This person has an application of same type , choice another Application Type if you want ", "Not completed", MessageBoxButtons.OK);
                    return;
                }

                if (clsPerson.IsDriver(_PersonID))
                {
                    if (clsLocalLicens.GetActiveLicensID(PersonInfo.HisIdAsDriver(), comboBox1.SelectedIndex + 1) != -1)
                    {
                        MessageBox.Show("This person acually has an Issued Licens of same type , choice another Application Type if you want ", "Not completed", MessageBoxButtons.OK);
                        return;
                    }
                }



                collectApplicationinfo();

                if (_Localapp.SaveNewApp())
                {
                    MessageBox.Show("Application Saved sucsesfully ", "Done", MessageBoxButtons.OK);
                    LB_Header.Text = "Application Info";
                    comboBox1.Enabled = false;
                    LB_Message.Visible = true;
                    find_ShowPerson1.Enabled = false;
                    LB_AppID.Text = _Localapp.LocalAppID.ToString();
                    return;
                }
                else
                    MessageBox.Show("somthing goes wrong in saving this application");


            }
        }

        private void btnClose_Click(object sender, EventArgs e)
       => this.Close();
    }
}
