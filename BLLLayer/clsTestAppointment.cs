using AccessDataLayer;
using System;
using System.Data;

namespace BussnisLayer
{
    public class clsTestAppointment
    {

        public clsTestAppointment()
        {
            this.ID = -1;
            this.LocalDriveApplicationID = -1;
            this.AppointmentDate = DateTime.Now.AddYears(-1000);
            this.CreatedBy = -1;
        }
        private clsTestAppointment(int AppointmentID, int LocalDLID, clsTestType.enTestType TestType, DateTime AppointmentDate, int createdByID,int ? RetakeApplicationID ,  decimal paidfees, bool islock)
        {
            _Mode = enMode.Update;
            this.ID = AppointmentID;
            this.LocalDriveApplicationID = LocalDLID;
            this.LocalApplicationInfo = clsLocalApplications.GetFullAppInfoByLocalAppID(LocalDLID);
            this.TestType = TestType;
            this.TestTypeInfo = clsTestType.Find((int)TestType);
            this.AppointmentDate = AppointmentDate;
            this.CreatedBy = createdByID;
            this.Fees = paidfees;
            this.IsLocked = islock;
            this.RetakeApplicationID = (RetakeApplicationID != null) ? RetakeApplicationID.Value : -1;
        }

      public  enum enMode { New, Update }

        //public enum enTestType { Vision =1 , Writen =2 , Street =3}
        //public enTestType TestType;

        #region Properties
        clsTestType.enTestType _TestType;
        public clsTestType.enTestType TestType 
        { get
            {
               return _TestType;
            }
        
            set
            {
                _TestType = value;
                TestTypeInfo = clsTestType.Find((int) value);
            }

        
        }
        public int ID { get; set; }
        public clsTestType TestTypeInfo { get; set; }
        public int LocalDriveApplicationID { get; set; }
        public clsLocalApplications LocalApplicationInfo;
        public DateTime AppointmentDate { get; set; }
        public decimal Fees { get; set; }
        public int CreatedBy { get; set; }
        public bool IsLocked { get; set; }
        enMode _Mode { get; set; }
        
        // in retake case

        public int RetakeApplicationID { get; set; }
        public clsApplication RetakeApplicationInfo;
        #endregion


        public bool PassTest(string Notes ) => AD_Tests.UpdateStatus(this.ID  ,true);
        public bool FailTest(string Notes ) => AD_Tests.UpdateStatus(this.ID  ,false);
        public bool SaveAppointment()
        {
            if (this._Mode == enMode.New)
            {
                this.ID = AD_TestAppointments.InsertRow(this.LocalDriveApplicationID, this.TestTypeInfo.ID, this.AppointmentDate, this.Fees, this.RetakeApplicationID, this.CreatedBy);

                return this.ID != -1;
            }
            else
            {
                return UpdateDate();
            }

        }
        public bool UpdateDate()
        {
            return AD_TestAppointments.UpdateDate(this.ID, this.AppointmentDate);
        }
        public void LockAppointment() => AD_TestAppointments.LockAppointment(this.ID);

        #region Static methods
        public static DataTable GetAllLocalAppAppointmentsByTestType(int LoaclAppID , clsTestType.enTestType testType) => AD_TestAppointments.GetLocalAppAppointmentsByTestType(LoaclAppID ,(int) testType);
        public static bool? IsAvaliableTobookAppointment(int localAppID , int TestTypeID ) => AD_TestAppointments.IsAvaliableTobookAppointment(TestTypeID , TestTypeID);

        public static clsTestAppointment Find(int AppointmentID)
        {
            int LocalDLID = 0, TestTypeID = 0, createdByID = 0;
            decimal paidfees = 0m;
            int? RetakeApplicationID = -1;
            DateTime AppointmentDate = DateTime.UtcNow;
            bool islock = false;

            if (AD_TestAppointments.GetAppointByID(AppointmentID, ref LocalDLID, ref TestTypeID, ref createdByID, ref AppointmentDate, ref paidfees, ref RetakeApplicationID, ref islock))
            {
                return new clsTestAppointment(AppointmentID, LocalDLID, (clsTestType.enTestType)TestTypeID, AppointmentDate, createdByID, RetakeApplicationID, paidfees, islock);
            }

            return null;

             
        }

        public static clsTestAppointment GetActiveAppointment(int LocalApplicationID , clsTestType.enTestType testtype )
        {
            int AppointmentID = -1, createdByID = -1 ;
            decimal paidfees = 0m;
            DateTime AppointmentDate = DateTime.UtcNow;
            bool islock = true;
            int? RetakeApplicationID = -1;

            if (AD_TestAppointments.GetActiveAppointment(ref AppointmentID, LocalApplicationID,
                (int)testtype, ref createdByID, ref AppointmentDate, ref RetakeApplicationID, ref paidfees, ref islock))
            {
                return new clsTestAppointment(AppointmentID, LocalApplicationID, testtype, AppointmentDate, createdByID, RetakeApplicationID,  paidfees, islock);

            }
            return null;
        }
        #endregion
    }
}
