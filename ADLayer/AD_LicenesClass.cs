using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace AccessDataLayer
{
    public class AD_LicenesClass
    {
      
        public static string GetLiceneName(int liceneID)
            {
                string licenseName = string.Empty;
                SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
                string query = @"select ClassName from LicenseClasses where LicenseClassID = @liceneID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@liceneID", liceneID);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        licenseName = reader[0].ToString();
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception as needed
                }
                finally
                {
                    conn.Close();
                }

                return licenseName;
            
        }

        public static List<string> GetLicenesName() 
        {
            List<string> licenes = new List<string>();

            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);

            string query = @"select ClassName from LicenseClasses";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) 
                {
                    licenes.Add(reader[0].ToString());
                
                }
            }
            catch(Exception ex) 
            {
       

            }

            finally { conn.Close(); }

            return licenes;

        }

        public static DataTable GetAllLicensClasses()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Class Name", typeof(string));
            dt.Columns.Add("Class Name", typeof(string));
            dt.Columns.Add("Description" , typeof(string));
            dt.Columns.Add("Min. age", typeof(int));
            dt.Columns.Add("Validty length", typeof(int));
            dt.Columns.Add("Fees", typeof(decimal));

            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = "Select * from LicenseClasses";

            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    DataRow dr = dt.NewRow();
                    dr["ID"] = (int)reader["LicenseClassID"];
                    dr["Class Name"] = (string)reader["ClassName"];
                    dr["Class Name"] = (string)reader["ClassName"];
                    dr["Min. age"] = (string)reader["MinimumAllowedAge"];
                    dr["Validty length"] = (string)reader["DefaultValidityLength"];
                    dr["Fees"] = (string)reader["ClassFees"];
                    dt.Rows.Add(dr);    
                }
            }
           catch(Exception ex)
            { 

            }
            finally { conn.Close(); }   

            return dt;
        }

        public static bool GetLicensClassByID(int ID , ref string ClassName , ref string Description ,
            ref int MinAge , ref int ValidityLength , ref decimal Fees)
        {
            bool success = false;

            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {
                string query = @"
            SELECT  ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees
            FROM LicenseClasses
            WHERE LicenseClassID = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", ID);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            ClassName = (string)reader["ClassName"];
                                Description = (string)reader["ClassDescription"];
                            MinAge = Convert.ToInt32(reader["MinimumAllowedAge"]);
                            ValidityLength = Convert.ToInt32(reader["DefaultValidityLength"]);
                            Fees = Convert.ToDecimal(reader["ClassFees"]);

                            success = true;

                        }
                    }
                }
            }

            return success;
        }




    }


}
