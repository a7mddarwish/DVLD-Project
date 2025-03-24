using AccessDataLayer;
using System.Data;

namespace BussnisLayer
{
    public class clsTestType
    {
        public enum enTestType { Vision=1 , Writen , Street }
       
        public clsTestType(int testID, string title, string description, decimal fees)
        {
            this.ID = testID;
            this.Title = title;
            Description = description;
            Fees = fees;
        }


        public int ID{ get; set; }
        public string Description{ get; set; }
        public decimal Fees { get; set; }
        public string Title { get; set; }

        public bool UpdateInfo()
        {
           return AD_TestTypes.UpdateTestInfo(this.ID , this.Title , this.Description , this.Fees );  
        }


        #region static Methods
       
        public static DataTable GetAllTestTypes()
        {
            return AD_TestTypes.GetAllTestTypes();
        }

        public static clsTestType Find(int TestTypeID)
        {
            string Title = string.Empty , Description = string.Empty ;
            decimal fees = 0;
            if (AD_TestTypes.GetByID(TestTypeID, ref Title ,ref Description ,ref fees))
            {
                return new clsTestType(TestTypeID, Title, Description, fees);
            }

            return null;
        }
        #endregion

      
    }
}
