using AccessDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussnisLayer
{
    public class clsCountry
    {
        private clsCountry(int CountryID, string countryName)
        {
            this.ID = CountryID;
            this.Name = clsCountry.GetCountyByID(CountryID);
        }

        


        public int ID{ get; set; }
        public string Name{ get; set; }


        #region Static Methods
        public static List<string> GetAllCountriesName()
        {
            return AD_Countries.GetAllCountries();
        }
        public static string GetCountyByID(int countryID)
        {
            return AD_Countries.GetCountryName(countryID);
        }
        
        public static clsCountry Find(int nationalityCountryID)
        {
            string CountryName = String.Empty;
            int Id = nationalityCountryID;

            if (AD_Countries.GetByID(nationalityCountryID, ref CountryName))
            {
                return new clsCountry(nationalityCountryID, CountryName);
            }
            else
                return null;
        }
        public static clsCountry Find(string CountryName)
        {
            int nationalityCountryID = -1 ;

            if (AD_Countries.GetByCountryName(ref nationalityCountryID,  CountryName))
            {
                return new clsCountry(nationalityCountryID, CountryName);
            }
            else
                return null;
        }


        #endregion

    }
}
