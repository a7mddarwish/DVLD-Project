using AccessDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BussnisLayer
{
    public class clsDetaindLicense
    {
        public clsDetaindLicense()
        {
            
        }
        enum enMode { New , Update}

        enMode _Mode = enMode.New;
        public int DetainID { get; set; }
        public int LicenseID { get; set; }
        public DateTime DetainDate { get; set; }
        public decimal FineFees { get; set; }
        public int DetainByUserID { get; set; }
        public bool IsReleased { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? ReleasedByUserID { get; set; }
        public int? ReleaseApplicationID { get; set; }

        private clsDetaindLicense(int detainID, int licenseID, DateTime detainDate, decimal fineFees, int createdByUserID, 
            bool isReleased, DateTime? releaseDate, int? releasedByUserID, int? releaseApplicationID)
        {
            _Mode = enMode.Update;
            DetainID = detainID;
            LicenseID = licenseID;
            DetainDate = detainDate;
            FineFees = fineFees;
            DetainByUserID = createdByUserID;
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            ReleaseApplicationID = releaseApplicationID;
        }

        public bool Save()
        {
            if (this._Mode == enMode.New)
            {
                if (SaveintoDB())
                {
                    _Mode = enMode.Update;
                    return true;
                }
                return false;
            }
            else
            {
                return UpdateInfo();
            }
        }

        private bool SaveintoDB ()
        {
            this.DetainID = AD_DetainLicense.AddNew(this.LicenseID, this.DetainDate, this.FineFees, this.DetainByUserID, false,
                this.ReleaseDate , this.ReleasedByUserID , this.ReleaseApplicationID);

            return this.DetainID != -1;
        }

        private bool UpdateInfo()
        => AD_DetainLicense.Update(this.DetainID, this.LicenseID, this.DetainDate, this.FineFees, this.DetainByUserID, this.IsReleased,
                this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);


        #region Static Methodes

        public static bool IsLicenseDetained(int LiceseID)
        {
            return AD_DetainLicense.IsLicenseDetained(LiceseID);   
        }
        public static string IsLiceseDetainedString(int LiceseID) => (clsDetaindLicense.IsLicenseDetained(LiceseID))? "Yes" : "No";

         public static clsDetaindLicense FindDetainByLiceseID(int liceseId)
        {
            int detainID =-1,  createdByUserID=-1;
            bool isReleased = false;
            DateTime detainDate = DateTime.UtcNow;
            decimal fineFees = 0m;

            if (AD_DetainLicense.FindDetainByLicenseID(ref detainID , liceseId ,  ref detainDate ,ref  fineFees ,ref createdByUserID))
            {
                return new clsDetaindLicense(detainID, liceseId, detainDate, fineFees, createdByUserID,
             isReleased, null, null, null);
            }
           return null;
        }
         public static clsDetaindLicense FindDetainByDetainID(int detainID )
        {
            int liceseId = -1,  createdByUserID=-1;
            bool isReleased = false;
            DateTime detainDate = DateTime.UtcNow;
            decimal fineFees = 0m;

            if (AD_DetainLicense.FindDetainByDetainID( detainID ,ref liceseId ,  ref detainDate ,ref  fineFees ,ref createdByUserID))
            {
                return new clsDetaindLicense(detainID, liceseId, detainDate, fineFees, createdByUserID,
             isReleased, null, null, null);
            }
           return null;
        }

        public static DataTable GetAllDetainLicese() => AD_DetainLicense.GetAllDetainLicese();

        #endregion
    }
}
