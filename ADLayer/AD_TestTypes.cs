using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDataLayer
{
    public  class AD_TestTypes
    {

        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Fees", typeof(decimal));


            using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
            {
                string query = @"select * from TestTypes";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
     
                            while (reader.Read())
                            {
                                DataRow row = dt.NewRow();
                                row["ID"] = reader["TestTypeID"];
                                row["Title"] = reader["TestTypeTitle"];
                                row["Description"] = reader["TestTypeDescription"];
                                row["Fees"] = reader["TestTypeFees"];
                                dt.Rows.Add(row);
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
            return dt;
        }
        public static bool GetByID(int ID, ref string Title, ref string Description, ref decimal fees)
        {
            bool found = false;
            //      SELECT[TestTypeID]
            //,[TestTypeTitle]
            //,[TestTypeDescription]
            //,[TestTypeFees]
            //      FROM[dbo].[TestTypes]

            using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
            {
                string query = @"SELECT* From TestTypes 
                        WHERE TestTypeID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@ID", ID);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Title = reader["TestTypeTitle"].ToString();
                                Description = reader["TestTypeDescription"].ToString();
                                fees = (decimal)reader["TestTypeFees"];
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
        public static bool UpdateTestInfo(int testID, string title, string description, decimal fees)
        {
            bool success = false;

            using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
            {
                string query = @"UPDATE TestTypes 
                        SET TestTypeTitle = @Title,
                            TestTypeDescription = @Description,
                            TestTypeFees = @Fees
                        WHERE TestTypeID = @ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@ID", testID);
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Description", description);
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
    }
}
