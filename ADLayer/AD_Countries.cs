using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDataLayer
{
    public class AD_Countries
    {

        static public List<String> GetAllCountries()
        {
            List<String> Countries = new List<String>();
            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);

            string query = @"SELECT CountryName FROM Countries";

            SqlCommand cmd = new SqlCommand(@query, conn);

          try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Countries.Add(reader.GetString(0));


                }

            }

            finally { conn.Close(); }

            return Countries;
        }

        public static bool GetByID(int ID ,ref  string CountryName )
        {
            CountryName = GetCountryName(ID);
            return (CountryName == null) ? false : true;

        
        }

        public static string GetCountryName(int countryID)
        {
            object CountryName = null;
            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = "Select CountryName from Countries where CountryID = @id";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id" , countryID);

            try
            {
                conn.Open();
                CountryName = cmd.ExecuteScalar();
            }
        
            finally
            {
                conn.Close();
            }
       
            return CountryName.ToString();

        
        }
        public static bool GetByCountryName( ref int CountryID, string CountryName)
        {
            bool Success = false;
            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = "Select CountryID  from Countries where Result = @CName";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@CName", CountryName);

            try
            {
                conn.Open();
             object   Result = cmd.ExecuteScalar();
                if (Result != null || Result != DBNull.Value)
                {
                    CountryID = Convert.ToInt32(Result);
                    Success = true;
                }
            }
            catch (Exception ex){ 
            Success = false;    
            }
        
            finally
            {
                conn.Close();
            }

            return Success;

        
        }
    }
}
