using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDataLayer
{
    public class AD_InternationalLicense
    {
        public static int InsertIntoDB(int BaseAppID,int DriverID,int LocalLicensID,DateTime IssuedDate
            ,DateTime ExpirDate,bool IsActive,int CreatedByUserID)
        {
            object result = -1;
            // Define the SQL query with parameters
            string query = @"
        INSERT INTO InternationalLicenses 
        (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID) 
        VALUES 
        (@ApplicationID, @DriverID, @LocalLicensID, @IssuedDate, @ExpirDate, @IsActive, @CreatedByUserID);
        SELECT SCOPE_IDENTITY();";

            // Use a connection and command to execute the query
            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@ApplicationID", BaseAppID);
                    command.Parameters.AddWithValue("@DriverID", DriverID);
                    command.Parameters.AddWithValue("@LocalLicensID", LocalLicensID);
                    command.Parameters.AddWithValue("@IssuedDate", IssuedDate);
                    command.Parameters.AddWithValue("@ExpirDate", ExpirDate);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    // Open the connection
                    connection.Open();

                    // Execute the query and retrieve the new ID
                    result = command.ExecuteScalar();
                    connection.Close();

                    // Return the new ID as an integer
                    return Convert.ToInt32(result);
                }
            }
        }
        public static DataTable GetAllInternationalLicenses()
        {
            // Create an empty DataTable to hold the results
            DataTable dataTable = new DataTable();

            // Define the SQL query to select all rows
            string query = "SELECT * FROM InternationalLicenses";

            // Use a connection and command to execute the query
            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Use a DataAdapter to fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        try
                        {
                            // Open the connection
                            connection.Open();

                            // Fill the DataTable with the query results
                            adapter.Fill(dataTable);
                        }
                        catch (Exception ex)
                        {
                            // Handle exceptions (log or rethrow)
                            Console.WriteLine($"Error: {ex.Message}");
                            throw;
                        }
                        finally
                        {
                            // Ensure the connection is closed
                            connection.Close();
                        }
                    }
                }
            }

            // Return the populated DataTable
            return dataTable;
        }
        public static DataTable GetByApplicationID(int applicationID)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM InternationalLicenses WHERE ApplicationID = @ApplicationID";

            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", applicationID);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                        connection.Close();
                    }
                }
            }

            return dataTable;
        }
        public static DataTable GetByDriverID(int driverID)
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM InternationalLicenses WHERE DriverID = @DriverID";

            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DriverID", driverID);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                        connection.Close();
                    }
                }
            }

            return dataTable;
        }
        public static bool GetByInternationalLicenseID(int internationalLicenseID, ref int baseApplicationID, ref int driverID, ref int localLicenseID,
            ref DateTime issueDate, ref DateTime expirationDate, ref bool isActive, ref int createdByUserID)
        {
            bool Success = false;
            string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID";

            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseID);
                   
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if(reader.Read())
                        {
                            //     (, , , , , , )

                            baseApplicationID = (int)reader["ApplicationID"];
                            driverID = (int)reader["DriverID"];
                            localLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                            issueDate = (DateTime)reader["IssueDate"];
                            expirationDate = (DateTime)reader["ExpirationDate"];
                            isActive = (bool)reader["IsActive"];
                            createdByUserID = (int)reader["CreatedByUserID"];

                            Success = true;

                        }

                    }
                    catch(Exception ex)
                    {
                        Success = false;
                    }
                    finally { connection.Close(); }
                    
                }
            }

            return Success;
        }

        public static bool IsDriverHasActiveInternationLicense(int driverID)
        {
            bool IsFound = false;
            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = @" Select 1 from InternationalLicenses where DriverID = @DID and IsActive = 1";
            SqlCommand cmd = new SqlCommand(@query, conn);
            cmd.Parameters.AddWithValue(@"DID" , driverID);

            try
            {
                 conn.Open();
                 object Result = cmd.ExecuteScalar();
                if (Result != null && Result != DBNull.Value)
                {
                    IsFound = true;
                }
            }
            catch
            {
                IsFound = false;
            }
            finally { conn.Close(); }

            return IsFound;
        }

        public static DataTable GetLicesByPersonID(int personID)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("License ID", typeof(int));
            dt.Columns.Add("Application ID", typeof(int));
            dt.Columns.Add("Issue Date", typeof(string));
            dt.Columns.Add("Expire Date", typeof(string));
            dt.Columns.Add("Is Active", typeof(bool));





            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = @"select InternationalLicenses.InternationalLicenseID , InternationalLicenses.ApplicationID , 
 InternationalLicenses.IssueDate ,
InternationalLicenses.ExpirationDate , InternationalLicenses.IsActive
from   InternationalLicenses
inner Join  Drivers on InternationalLicenses.DriverID = Drivers.DriverID 
inner join  People   on Drivers.PersonID = People.PersonID
where People.PersonID = @personid";


            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue(@"personid" , personID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["License ID"] = (int)reader["InternationalLicenseID"];
                    dr["Application ID"] = (int)reader["ApplicationID"];
                    dr["Issue Date"] = ((DateTime)reader["IssueDate"]).ToString("dd/MMM/yyyy");
                    dr["Expire Date"] = ((DateTime)reader["ExpirationDate"]).ToString("dd/MMM/yyyy");
                    dr["Is Active"] = (bool)reader["IsActive"];

                    dt.Rows.Add(dr);

                }

            }
            finally { conn.Close(); }


            return dt;
        }
    }
}
