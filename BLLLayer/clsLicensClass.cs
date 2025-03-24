using AccessDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnisLayer
{
    public class clsLicensClass
    {
        #region Properties 

        public int ID { get; set; }
        public string ClassName { get; set; }
        public string Description { get; set; }
        public int AllowedMinAge { get; set; }
        public int ValidtyLength { get; set; }
        public decimal Fees { get; set; }


        #endregion

        public clsLicensClass(int id , string name , string descriotion , int minage , int validtylength , decimal fees)
        {
            this.ID = id;
            this.ClassName = name;  
            this.Description = descriotion;
            this.AllowedMinAge = minage;
            this.ValidtyLength = validtylength; 
            this.Fees = fees;   
            
        }

        public static List<string> GetAllLiecesNames()
        {

            return AD_LicenesClass.GetLicenesName();

        }
        public static string GetLicenNameByID(int LiceneID)
        {
            return AD_LicenesClass.GetLiceneName(LiceneID);
        }

        public static clsLicensClass Find(int ID)
        {
            string Description = "", ClassName = "";
            int MinAge = 0, ValidtyLength = 0;
            decimal fees = 0;

            if(AD_LicenesClass.GetLicensClassByID(ID ,  ref ClassName ,  ref Description ,ref  MinAge ,  ref ValidtyLength ,ref fees))
            {
                return new clsLicensClass(ID, ClassName, Description, MinAge, ValidtyLength, fees);
            }
            return null;
        }

    }
}
