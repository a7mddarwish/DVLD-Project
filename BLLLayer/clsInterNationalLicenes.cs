using AccessDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnisLayer
{
    public class clsInterNationalLicenes 
    {
    
         public clsInterNationalLicenes(int internationalLicenseID, int baseApplicationID, int driverID, int localLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID)
            {
                this.Mode = enMode.Update;    
                this.internationalLicensID = internationalLicenseID;
                this.BaseApplicationID = baseApplicationID;
                this.DriverID = driverID;
                this.LocalLicensID = localLicenseID;
                this.LocalLicenesInfo = clsLocalLicens.FindByLicenseID(localLicenseID);
                this.IssueDate = issueDate;
                this.ExpirationDate = expirationDate;
                this.IsActive = isActive;
                this.CreatedByUserID = createdByUserID;
               this.UserCreatedInfo = clsUser.Find(createdByUserID   );
            }
        
         public enum enMode { New , Update}
         public enMode Mode = enMode.New;
         public static int DefaultValidityLength { get => 5; }
         public int internationalLicensID { get; set; }
         public int BaseApplicationID { get
            {
               return this.BaseApplicationInfo.BaseApplicationID;
            }
            set
            {
                BaseApplicationInfo = clsApplication.FindBaseApplication(value);
            }
        }
         public clsApplication BaseApplicationInfo = new clsApplication();
         public int DriverID { get; set; }
         public  clsDrivers DriverInfo;
         public int LocalLicensID { get; set; }
         public clsLocalLicens LocalLicenesInfo;
         public DateTime IssueDate { get; set; }
         public DateTime ExpirationDate { get; set; }
         public bool IsActive { get; set; }
         public int CreatedByUserID { get; set; }
         public clsUser UserCreatedInfo;

        public clsInterNationalLicenes()
        {
            Mode = enMode.New;
        }
        public bool Save()
        {
            if (BaseApplicationInfo.SaveNewApp((int) clsApplication.enApplicationType.NewInterNAtional))
            {
                return saveintoDB();
            }
            return false;
        }

        private bool saveintoDB()
        {
         this.internationalLicensID =   AD_InternationalLicense.InsertIntoDB(BaseApplicationInfo.BaseApplicationID, DriverID, LocalLicensID,
                IssueDate, ExpirationDate, IsActive, CreatedByUserID);

            return this.internationalLicensID != -1;
        }

        public static bool IsDriverHasActiveInternationLicense(int driverID)
        
           => AD_InternationalLicense.IsDriverHasActiveInternationLicense(driverID);

        public static clsInterNationalLicenes Find(int internationalLicenseID)
        {
            //  public clsInterNationalLicenes(int internationalLicenseID, int baseApplicationID, int driverID, int localLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID)
            int baseApplicationID =-1, driverID=-1, localLicenseID = -1, createdByUserID = -1;
            DateTime issueDate= DateTime.UtcNow, expirationDate = DateTime.UtcNow;
            bool isActive = false;
           if ( AD_InternationalLicense.GetByInternationalLicenseID( internationalLicenseID,ref baseApplicationID, ref driverID, ref localLicenseID, ref issueDate, ref expirationDate, ref isActive, ref createdByUserID))
            {
                return new clsInterNationalLicenes(internationalLicenseID , baseApplicationID , driverID , localLicenseID , issueDate , expirationDate , isActive , createdByUserID);
            }
           return null;

        }

        public static DataTable GetInternationalLicensByPersonID(int personID)
        {
            return AD_InternationalLicense.GetLicesByPersonID(personID);
        }

        public static object GetAllInterNationalLicense()
        {
           return AD_InternationalLicense.GetAllInternationalLicenses();
        }
    }
}
