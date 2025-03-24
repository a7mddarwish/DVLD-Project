using AccessDataLayer;
using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static BussnisLayer.clsLocalLicens;

namespace BussnisLayer
{
    public class clsLocalLicens
     {
        public clsLocalLicens()
        {
            this._Mode = enMode.AddNew;
        }
        private clsLocalLicens(
    enIssueReason issueReason,
    int licenseID,
    int baseApplicationID,
    int driverID,
    int licenseClassID,
    DateTime issueDate,
    DateTime expirationDate,
    string notes,
    decimal paidFees,
    bool isActive,
    int createdByUserID)
        {
            this._Mode = enMode.Update;
            this.IssueReason = issueReason;
            this.LicenseID = licenseID;
            this.BaseApplicationID = baseApplicationID;
            this.DriverID = driverID;
            this.LicenseClassID = licenseClassID;
            this.IssueDate = issueDate;
            this.ExpirationDate = expirationDate;
            this.Notes = notes;
            this.PaidFees = paidFees;
            this.IsActive = isActive;
            this.CreatedByUserID = createdByUserID;
            this._BaseApplicationInfo = clsApplication.FindBaseApplication(baseApplicationID);
        }


        public enum enIssueReason { FirstTime  =1 , Renew = 2 , Damaged =3 ,Lost =4}
        public enum enMode { AddNew , Update}

        #region Properties
        public enMode _Mode;
        public enIssueReason IssueReason { get; set; }
        public int LicenseID { get; set; }
        public int BaseApplicationID { get; set; }
        public clsApplication _BaseApplicationInfo;
        public int DriverID { get; set; }
        public int LicenseClassID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }
        #endregion

        public bool Save()
        {
            if (this._Mode == enMode.AddNew)
            {

                if (InsertIntoDB())
                {
                    this._Mode = enMode.Update;
                    return true;
                }
                return false;

            }

            return false;
        }

        private bool InsertIntoDB()
        {
            this.LicenseID = AD_Licenses.AddNewLicens(this.BaseApplicationID , this.DriverID ,(byte) this.IssueReason , this.LicenseClassID 
                , this.IssueDate , this.ExpirationDate , this.Notes , this.PaidFees ,true , this.CreatedByUserID);

            return this.LicenseID != -1;
        }


        #region static Methods

        public static int GetActiveLicensID(int DriverID , int LicensClassID)
        {
            return AD_Licenses.GetActiveLicensID (DriverID , LicensClassID);    
        }

        public static clsLocalLicens FindByBaseApplication(int BaseApplicationID)
        {
        int licenseID =-1 ,driverID = -1, licenseClassID = -1, createdByUserID = -1, issueReasonID = -1; 
           
            DateTime issueDate = DateTime.UtcNow, expirationDate = DateTime.UtcNow;
            string notes = string.Empty;
            decimal paidFees = -1;
            bool isActive = false;

            if (AD_Licenses.FindByBaseApplication(BaseApplicationID, ref issueReasonID, ref licenseID, ref driverID, ref licenseClassID,
               ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive, ref createdByUserID))
            {

                return new clsLocalLicens( (enIssueReason)issueReasonID , licenseID ,BaseApplicationID ,  driverID , licenseClassID , issueDate , expirationDate , notes , paidFees , isActive , createdByUserID);
            }
            return null;



        }

        public static DataTable GetLocalLicensByPersonID(int PersonID)
        {
            return AD_Licenses.GetLocalLicensByPersonID(PersonID);
        }

        public static clsLocalLicens FindByLicenseID(int licenseID)
        {
            int BaseApplicationID = -1, driverID = -1, licenseClassID = -1, createdByUserID = -1, issueReasonID = -1;

            DateTime issueDate = DateTime.UtcNow, expirationDate = DateTime.UtcNow;
            string notes = string.Empty;
            decimal paidFees = -1;
            bool isActive = false;

            if (AD_Licenses.FindByLicensesID(ref BaseApplicationID, ref issueReasonID, licenseID, ref driverID, ref licenseClassID,
               ref issueDate, ref expirationDate, ref notes, ref paidFees, ref isActive, ref createdByUserID))
            {

                return new clsLocalLicens((enIssueReason)issueReasonID, licenseID, BaseApplicationID, driverID, licenseClassID, issueDate, expirationDate, notes, paidFees, isActive, createdByUserID);
            }
            return null;

        }

        public static bool IsLicenseExist(int LiceseID) => AD_Licenses.IsLicenseExist(LiceseID);

        public static bool DeActivateLicense(int LicenseID) => AD_Licenses.DeActiveLicense(LicenseID);
        

        #endregion
    }
}
