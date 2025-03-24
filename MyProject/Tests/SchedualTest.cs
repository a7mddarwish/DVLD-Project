using BussnisLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class SchedualTest : Form
    {
        enum enMode { New , Update}
        enMode _Mode = enMode.New;

        int _LocalDrivingLicensApplicationID = -1;
        clsTestType.enTestType _Testtype;
        clsLocalApplications LocalApplication;
        clsTestAppointment _TestAppointment;
        public SchedualTest(int LoalDrivingLicensApplicationID , clsTestType.enTestType testtype)
        {
            InitializeComponent();
            _LocalDrivingLicensApplicationID = LoalDrivingLicensApplicationID;
            _Testtype = testtype;
            LocalApplication = clsLocalApplications.GetFullAppInfoByLocalAppID(LoalDrivingLicensApplicationID);



        }

        private void SchedualTest_Load(object sender, EventArgs e)
        {
            SetFormHeadLines();
            clsTestAppointment ActiveAppointment = clsTestAppointment.GetActiveAppointment(_LocalDrivingLicensApplicationID, _Testtype);
            ctrlScheduleTest1.TestType = _Testtype;

            if (ActiveAppointment != null)
            {
            _Mode = enMode.Update;
            ctrlScheduleTest1.LoadInfo(_LocalDrivingLicensApplicationID , ActiveAppointment.ID);
                return;
            }


                _Mode = enMode.New; 
               ctrlScheduleTest1.LoadInfo(_LocalDrivingLicensApplicationID );


        }

        private void SetFormHeadLines()
        {
            switch (_Testtype)
            {
                case clsTestType.enTestType.Vision:
                    this.Text = "Schedule Vision test";
                    break;
                case clsTestType.enTestType.Writen:
                    this.Text = "Schedule Written test";
                    break;
                case clsTestType.enTestType.Street:
                    this.Text = "Schedule Street test";
                    break;



            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        => this.Close();

        



        //    clsTestAppointment ListTestAppointments = new clsTestAppointment();
        //    int _LocalAppID = 0;
        //    string _ClassName = string.Empty , _ApplicaiantName = string.Empty;


        //    public SchedualTest(int LoalAppID , string ApplicaintName , string ClassName )
        //    {
        //        InitializeComponent();
        //        _LocalAppID = LoalAppID;
        //        _ClassName = ClassName;
        //        _ApplicaiantName = ApplicaintName;
        //        SetData();
        //    }


        //    public SchedualTest(string ApplicaintName, string ClassName, int AppointmentID)
        //    {
        //        InitializeComponent();
        //        _ClassName = ClassName;
        //        _ApplicaiantName = ApplicaintName;
        //        ListTestAppointments = clsTestAppointment.FindByBaseApplication(AppointmentID);
        //        if (ListTestAppointments.IsLocked)
        //        {
        //            SetLockedAppointmentUI();
        //        }
        //        _LocalAppID = ListTestAppointments.LocalDriveApplicationID;
        //        SetData();
        //        btn_Save.Visible = false;
        //        btn_Update.Visible = true;
        //    }

        //    private void SetLockedAppointmentUI()
        //    {
        //        LB_LockedMessage.Visible = true;
        //        dateTimePicker1.Enabled = false;
        //        btn_Update.Enabled = false;
        //    }

        //    private void SetData()
        //    {
        //        LB_ClassName.Text = _ClassName;
        //        LB_ID.Text = _LocalAppID.ToString();
        //        LB_Name.Text = _ApplicaiantName;

        //        LB_Trial.Text = "0";
        //        LB_Fees.Text = "10";

        //        groupBox2.Enabled = false;
        //    }

        //    private void btn_Save_Click(object sender, EventArgs e)
        //    {
        //        collectData();
        //        if (ListTestAppointments.SaveAppointment())
        //            MessageBox.Show("Appointment has been successfully booked" , "Done" , MessageBoxButtons.OK);

        //        else
        //            MessageBox.Show("Somthing goes wrong", "error", MessageBoxButtons.OK);


        //    }

        //    private void btn_Close_Click(object sender, EventArgs e) => this.Close();

        //    private void btn_Update_Click(object sender, EventArgs e)
        //    {
        //        ListTestAppointments.AppointmentDate = dateTimePicker1.Value;
        //        if (ListTestAppointments.UpdateDate())
        //        {
        //            MessageBox.Show("Date updated successfully" , "Done" , MessageBoxButtons.OK);
        //        }
        //    }


        //    private void collectData()
        //    {
        //        ListTestAppointments.TestTypeInfo = clsTestType.FindByBaseApplication((int)clsTestType.enTestType.Vision);
        //        ListTestAppointments.LocalDriveApplicationID = _LocalAppID;
        //        ListTestAppointments.CreatedBy = 1 ;
        //        ListTestAppointments.AppointmentDate = dateTimePicker1.Value;

        //    }



        //    //private void RetakeInfo()
        //    //{
        //    //    groupBox2.Enabled = true;
        //    //    LB_RFees.Text = $"{5}$";
        //    //    LB_TotalFees.Text = $"{Convert.ToDecimal(5 +ListTestAppointments.Fees)}";
        //    //}

    }
    }
