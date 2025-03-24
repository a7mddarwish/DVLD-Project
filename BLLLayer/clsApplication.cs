using AccessDataLayer;
using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BussnisLayer.clsApplicationType;
using static System.Net.Mime.MediaTypeNames;

namespace BussnisLayer
{
    public class clsApplication
    {
        #region Prop
        public int BaseApplicationID {  get; set; }
        public int PersonID { get => PersonInfo.ID; set => PersonInfo = clsPerson.Find(value); }
        public clsPerson PersonInfo;


        public DateTime AppDate { get; set; }
        public DateTime lastStatusDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public clsApplicationType AppTypeInfo;
        public decimal Fees { get; set; }
        public int UserCreatedID { get; set; }
        public clsUser UserCreated;
        public int LicenesClassID {  get; set; }
        public int PassedTests{ get; set; }

        public enStatus Status { get; set; }

        public string ApplicationStatusText
        {
            get
            {
                switch (this.Status)
                {
                    case enStatus.New:
                        return "New";
                    case enStatus.Canceld:
                        return "Canceld";
                    case enStatus.Completed:
                        return "Complete";
                    default :
                        return "UnKnown";    

                }
            }
        }



        #endregion 
        public enum enStatus { New=1 , Canceld=2 , Completed =3 }
        public enum enApplicationType { NewLocal = 1  , Renew = 2 , ReplaceForLost =3 
                , ReplaceForDamge =4 , RelaseDetained =5 , NewInterNAtional =6 , Retake =8};
        public enum enMode { AddNew, Update }
        public enMode _Mode = enMode.AddNew;

        protected clsApplication(int ApplicationID, int ApplicantPersonID,
            DateTime ApplicationDate, int ApplicationTypeID,
             enStatus ApplicationStatus, DateTime LastStatusDate,
             float PaidFees, int CreatedByUserID)

        {
            this.BaseApplicationID = ApplicationID;
            this.PersonID = ApplicantPersonID;
            this.PersonInfo = clsPerson.Find(ApplicantPersonID);
            this.AppDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.AppTypeInfo = clsApplicationType.Find(ApplicationTypeID);
            this.Status = ApplicationStatus;
            this.lastStatusDate = LastStatusDate;
            this.Fees = (decimal)PaidFees;
            this.UserCreatedID = CreatedByUserID;
            this.UserCreated = clsUser.Find(CreatedByUserID);
            _Mode = enMode.Update;
        }


        public clsApplication()
        {
            this.BaseApplicationID = -1;
            this.PersonID = -1;
            this.AppDate = DateTime.Now;
            this.lastStatusDate = DateTime.Now;
            this.ApplicationTypeID = -1 ;  // Assuming enApplicationType is an enum with New value
            this.Fees = 0m;
            this.UserCreatedID = -1;
            this.LicenesClassID = -1;
            this.PassedTests = 0;
            this.Status = enStatus.New;  // Assuming enStatus is an enum with New value

        }

        private bool SaveAppInfo()
        {

            this.BaseApplicationID = AD_Applications.AddNewApplication(PersonID, AppDate, this.ApplicationTypeID, (byte)Status, this.lastStatusDate,(float)Fees, UserCreatedID);
          //  this.BaseApplicationID = AD_Applications.InsertAppinDB(1, DateTime.Now, 2, 2, DateTime.Now, 200, 1);

            return this.BaseApplicationID != -1;
        }
        public bool SaveNewApp(int applicationType)
        {
            this.ApplicationTypeID = applicationType;

            return (SaveAppInfo());

        }
        public bool Cancel()
        {
            return AD_Applications.UpdateStatus(this.BaseApplicationID, 2);
        }
        public bool SetComplete()
        {
            return AD_Applications.UpdateStatus(this.BaseApplicationID, 3);
        }

        #region Static Methods

        public static int GetActiveApplicationID(int ApplicantID , int LicensClassID, enApplicationType ApplicationTypeID)
        {
            return AD_Applications.GetActiveApplicationIDForLicenseClass(ApplicantID , (int)ApplicationTypeID  , LicensClassID);
        }
      
        public static bool CancelApplication(int ApplicationID) 
        {
         //   1 - New , 2 - Cancelled , 3 - Completed
        return AD_Applications.UpdateStatus(ApplicationID, 2);
        }

        public static clsApplication FindBaseApplication(int applicationID)
        {

            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.Now; int ApplicationTypeID = -1;
            byte ApplicationStatus = 1; DateTime LastStatusDate = DateTime.Now;
            float PaidFees = 0; int CreatedByUserID = -1;

            bool IsFound = AD_Applications.GetApplicationInfoByID
                                (
                                    applicationID, ref ApplicantPersonID,
                                    ref ApplicationDate, ref ApplicationTypeID,
                                    ref ApplicationStatus, ref LastStatusDate,
                                    ref PaidFees, ref CreatedByUserID
                                );

            if (IsFound)
                //we return new object of that person with the right data
                return new clsApplication(applicationID, ApplicantPersonID,
             ApplicationDate, ApplicationTypeID,
              (enStatus)ApplicationStatus, LastStatusDate,
              PaidFees, CreatedByUserID);
            else
                return null;
        }

        public static int GetActiveLicensID(int PersonID, int licenesClassID)
        {


            return AD_Licenses.GetActiveLicensID(PersonID, licenesClassID);
        }

        #endregion


    }
}
