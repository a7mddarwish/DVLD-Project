using AccessDataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnisLayer
{
    public class clsApplicationType
    {

        public enum enMode { AddNew , Update }
        public enMode Mode = enMode.AddNew;

        public int ID { get; set; }
        public string Title { get; set; }

        public decimal Fees { get; set; }

        public clsApplicationType()
        {
            Mode = enMode.AddNew;
            this.ID = -1;
            this.Title = String.Empty;
            this.Fees = 0m;
        }

        private clsApplicationType(int id , string title , decimal fees )
        {
            Mode = enMode.Update;
            this.ID = id;   
            this.Title = title;
            this.Fees   = fees;
            
        }

        public bool Save () 
        {

            if (this.Mode == enMode.AddNew)
            {
                if (SaveRecinDB())
                {
                    Mode = enMode.Update;
                    return true;
                }
                else return false;


            }
            else
                return UpdateAppTypeInfo();

        
        }

        private bool UpdateAppTypeInfo()
        {
            return AD_ApplicationTypes.UpdateAppInfo(this.ID, this.Title, this.Fees );
        }

        private bool SaveRecinDB()
        {
            //AD_ApplicationTypes.AddApplicationType => this is a stub method code it if you want to turn it on
            // will return -1 now , you can change it قولتلك
            this.ID = AD_ApplicationTypes.AddApplicationType(this.Title, this.Fees);
            return this.ID != -1;


        }

        #region Static Methods 

        public static clsApplicationType Find(int ID)
        {
            string Description = String.Empty;
            decimal fees = 0m;
            if ( AD_ApplicationTypes.GetAppByID(ID, ref Description , ref fees))
            {
                return new clsApplicationType(ID , Description, fees );
            }
            return null;
        }

        public static DataTable GetAllApplicationTypes()
            => AD_ApplicationTypes.GetAllApplicationTypes();


        #endregion
    }
}
