using AccessDataLayer;
using DVLD_DataAccess;
using System;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace BussnisLayer
{
    public class clsLocalApplications  :  clsApplication
    {
        public int LocalAppID { get; set; }
        public clsLicensClass LicensClassInfo;



        public clsLocalApplications() : base() 
        {
            this.LocalAppID = -1;
        }

        public clsLocalApplications(int localAppID, int baseApplicationID, int personID,
                                   DateTime appDate, DateTime lastStatusDate,
                                   enApplicationType appType, decimal fees, int userCreatedID,
                                   int licenesClassID,  enStatus stutes)
             : base(baseApplicationID, personID, appDate,(int)appType,  stutes, lastStatusDate,
        (float)fees, userCreatedID)
        {

            //  (baseApplicationID, personID,
            //   appDate, ApplicationTypeID,
            //    (enStatus)ApplicationStatus, LastStatusDate,
            //    PaidFees, DetainByUserID)

            this.LicenesClassID = licenesClassID;
            LicensClassInfo = clsLicensClass.Find(licenesClassID);
            LicensClassInfo = clsLicensClass.Find(LicenesClassID);
            this.LocalAppID = localAppID;
        }


        private bool SaveintoDB()
        {
            this.LocalAppID = AD_LocalApplications.InsertinDB(this.BaseApplicationID , this.LicenesClassID);
            return LocalAppID != -1;
        }
        public bool SaveNewApp()
        {
            if (Status == enStatus.New)
            {
                base.SaveNewApp(this.ApplicationTypeID);
              return  SaveintoDB();
    
            }
            return false;
        }

        public byte GetPassedTestCount()
        {
            return clsTest.GetPassedTestCount(this.LocalAppID);
        }
        public bool IsLicensIssued()
        {
            return ( (AD_Licenses.GetActiveLicensID(this.PersonID, this.LicenesClassID) != -1) );
        }

        public bool IsThereAnActiveScheduledTest(clsTestType.enTestType testTypeID)
        {
            return AD_LocalApplications.IsThereAnActiveScheduledTest(this.LocalAppID, (int)testTypeID);

        }





        #region static Methods
        public static DataTable GetAllApplications() => AD_LocalApplications.GatAllApplications();

        public static clsLocalApplications GetFullAppInfoByLocalAppID(int LocalapplicationID)
        {
            DateTime ApplicationDate = DateTime.UtcNow, lastStatusDate = DateTime.UtcNow;
            decimal fees = 0m;

             int BaseapplicationID = -1, personID = -1, PassedTests = -1,
             LicenseclassID = -1, ApplicationTypeID = -1, appStutes = -1 , userCreatedID = -1;
 



            if (AD_LocalApplications.GetFullAppInfoByLocalAppID(LocalapplicationID, ref BaseapplicationID , ref  personID, ref  PassedTests,
      ref  LicenseclassID, ref  ApplicationTypeID, ref  appStutes, ref ApplicationDate,
      ref  lastStatusDate, ref  fees, ref  userCreatedID))
            {
                return new clsLocalApplications(LocalapplicationID, BaseapplicationID, personID,
                ApplicationDate, lastStatusDate,
                                   (enApplicationType)ApplicationTypeID, fees, userCreatedID,
                                    LicenseclassID,  (enStatus)appStutes);
            }
            return null;

        }

        public static clsLocalApplications FindByApplicationID(int ApplicationID)
        {
            // 
            int LocalDrivingLicenseApplicationID = -1, LicenseClassID = -1;

            bool IsFound = AD_LocalApplications.GetLocalDrivingLicenseApplicationInfoByApplicationID
                (ApplicationID, ref LocalDrivingLicenseApplicationID, ref LicenseClassID);


            if (IsFound)
            {
                //now we find the base application

              return  clsLocalApplications.GetFullAppInfoByLocalAppID(LocalDrivingLicenseApplicationID);
                //we return new object of that person with the right data
               //  new clsLocalApplications();
            }
            else
                return null;


        }


        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            return clsTest.GetPassedTestCount(LocalDrivingLicenseApplicationID);
        }

        public static bool Delete(int LocalDrivingLicenseApplicationID) 
        {
        
        return AD_LocalApplications.DeleteLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);
        }

        public bool DoesAttendTestType(clsTestType.enTestType testTypeID)
        {
            return AD_LocalApplications.DoesAttendTestType(this.LocalAppID, (int)testTypeID);

        }

        public byte TotalTrialsPerTest(clsTestType.enTestType testTypeID)
        {
            return AD_LocalApplications.TotalTrialsPerTest(this.LocalAppID, (int)testTypeID);
        }

        public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)

        {
            return AD_LocalApplications.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public static bool IsThereAnActiveScheduledTest(int localDrivingLicenseApplicationID, clsTestType.enTestType testTypeID)
        {
            return AD_LocalApplications.IsThereAnActiveScheduledTest(localDrivingLicenseApplicationID, (int)testTypeID);
          
        }

        public bool DoesPassTestType(clsTestType.enTestType testTypeID)
        {
            return AD_LocalApplications.DoesPassTestType(this.LocalAppID, (int)testTypeID);
        }

        


        #endregion

    }
}
