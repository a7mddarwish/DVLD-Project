using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDataLayer
{
    public class AD_ApplicationTypes
    {

        public static DataTable GetAllApplicationTypes()
        {


            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Titel", typeof(string));
            dt.Columns.Add("Fees", typeof(decimal));

            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = "select * from ApplicationTypes";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DataRow dr = dt.NewRow();

                    dr["ID"] = (int)reader["ApplicationTypeID"];
                    dr["Titel"] = (string)reader["ApplicationTypeTitle"];
                    dr["Fees"] = (decimal)reader["ApplicationFees"];

                    dt.Rows.Add(dr);


                }

            }

            catch (Exception ex) { }

            finally { conn.Close(); }

            return dt;
        }
        public static bool GetAppByID(int appID, ref string title, ref decimal fees)
        {
            bool found = false;

            using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
            {
                string query = @"SELECT ApplicationTypeTitle, ApplicationFees 
                        FROM ApplicationTypes 
                        WHERE ApplicationTypeID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@ID", appID);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                title = reader["ApplicationTypeTitle"].ToString();
                                fees = (decimal)reader["ApplicationFees"];
                                found = true;
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Log the error appropriately
                        throw;
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                            conn.Close();
                    }
                }
            }
            return found;
        }
        public static bool UpdateAppInfo(int id, string title, decimal fees)
        {
            bool success = false;
            using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
            {
                string query = @"UPDATE ApplicationTypes 
                        SET ApplicationTypeTitle = @Title, 
                            ApplicationFees = @Fees 
                        WHERE ApplicationTypeID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Fees", fees);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        success = (rowsAffected > 0);
                    }
                    catch (SqlException ex)
                    {
                        // Log the error appropriately
                        throw;
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                            conn.Close();
                    }
                }
            }
            return success;
        }
        public static int AddApplicationType( string Titel , decimal fees)
        {
            return -1;
        }
    }
}
