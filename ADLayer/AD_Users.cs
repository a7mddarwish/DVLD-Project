using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace AccessDataLayer
{
    public class AD_Users
    {
        public static DataTable GetAllUsers()
        {
            DataTable AllUsers = new DataTable();
            AllUsers.Columns.Add("ID", typeof(int));
            AllUsers.Columns.Add("PersonID", typeof(int));
            AllUsers.Columns.Add("FullName", typeof(string));
            AllUsers.Columns.Add("UserName", typeof(string));
            AllUsers.Columns.Add("IsActive", typeof(bool));

            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = "SELECT * FROM Users";

            SqlCommand cmd =new SqlCommand(query , conn);

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {

                    DataRow row = AllUsers.NewRow();

                    row["ID"] = reader["UserID"];
                    row["PersonID"] = reader["PersonID"];
                    row["UserName"] = reader["UserName"];
                    row["IsActive"] = reader["IsActive"];

                    AllUsers.Rows.Add(row); 

                
                }


            }
            catch (Exception ex) { }
            finally
            {
                conn.Close();
            }

            return AllUsers;
        }
       
        public static bool GetByID(int userID, ref int personID, ref string userName, ref string password, ref bool isActive)
        {
            bool ProcessDone = false;
            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {

                string query = "SELECT * FROM Users WHERE UserID = @UserID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", userID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            personID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                            userName = reader.GetString(reader.GetOrdinal("UserName"));
                            password = reader.GetString(reader.GetOrdinal("Password"));
                            isActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                            ProcessDone = true;
                        }

                    }
                }
                catch (Exception ex)
                {
                    // Handle exception (e.g., log it)
                    //  Console.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }

                return ProcessDone;
            }
        } 
        public static bool GetByUserNameAndPass(ref int userID, ref int personID,  string userName,  string password, ref bool isActive)
        {
            bool ProcessDone = false;
            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {

                string query = "SELECT * FROM Users WHERE UserName = @Uname and Password = @Pass";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Uname", userName);
                command.Parameters.AddWithValue("@Pass", password);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userID = reader.GetInt32(reader.GetOrdinal("UserID"));
                            personID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                            isActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                            ProcessDone = true;
                        }

                    }
                }
                catch (Exception ex)
                {
                    // Handle exception (e.g., log it)
                    //  Console.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }

                return ProcessDone;
            }
        } 
     
        public static bool GetByUserName(ref int userID, ref int personID, string userName, ref string password, ref bool isActive)
        {
            bool ProcessDone = false;
            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {

                string query = "SELECT * FROM Users WHERE UserName = @UN";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UN", userName);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userID = reader.GetInt32(reader.GetOrdinal("UserID"));
                            personID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                          //  userName = reader.GetString(reader.GetOrdinal("UserName"));
                            password = reader.GetString(reader.GetOrdinal("Password"));
                            isActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                            ProcessDone = true;
                        }

                    }
                }
                catch (Exception ex)
                {
                    // Handle exception (e.g., log it)
                    //  Console.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }

                return ProcessDone;
            }
            }
        
        public static bool GetByPersonID(ref int userID,  int personID, ref string userName, ref string password, ref bool isActive)
        {
            bool ProcessDone = false;
            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {

                string query = "SELECT * FROM Users WHERE PersonID = @PID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PID", personID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userID = reader.GetInt32(reader.GetOrdinal("UserID"));
                            userName = reader.GetString(reader.GetOrdinal("UserName"));
                            password = reader.GetString(reader.GetOrdinal("Password"));
                            isActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                            ProcessDone = true;
                        }

                    }
                }
                catch (Exception ex)
                {
                    // Handle exception (e.g., log it)
                    //  Console.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }

                return ProcessDone;
            }
        }

        public static int SaveUserInDB(int PersonID, string UserName, string Password, bool IsActive)
        {
            object result = -1;

            // Hash password before storing

            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {
                string query = @"INSERT INTO Users (PersonID, UserName, Password, IsActive) 
                        VALUES (@PersonID, @UserName, @Password, @IsActive);
                        SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@IsActive", IsActive);

                        connection.Open();

                        result = command.ExecuteScalar();

                        if (result == null) { result = -1; }
                     
                    }
                    catch (SqlException ex)
                    {
                        // Log the error
                        throw new Exception("Error saving user to database", ex);
                    }
                }
            }

            return int.Parse(result.ToString());
        }

        public static bool UpdateUserInfo(int ID1, int PersonID, string userName, string password, bool isActive)
        {
            bool success = false;

            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {
                string query = @"UPDATE Users 
                        SET PersonID = @PersonID, 
                            UserName = @UserName,
                            Password = @Password,
                            IsActive = @IsActive
                        WHERE UserID = @ID1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        // Add parameters
                        command.Parameters.AddWithValue("@ID1", ID1);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Password", password);  // Consider hashing password
                        command.Parameters.AddWithValue("@IsActive", isActive);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        success = (rowsAffected > 0);
                    }
                    catch (SqlException ex)
                    {
                        // Handle or log the exception appropriately
                        throw;
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                            connection.Close();
                    }
                }
            }

            return success;
        }

        public static bool CheckIfUserNameHere(string UserName)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = @"SELECT 1 from Users Where UserName = @UN";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@UN", UserName);

            try
            {
                conn.Open();

                object obj = cmd.ExecuteScalar();

                success = (obj != null);
            }

            finally
            {
                conn.Close();
            }

           return success;
        }

        public static bool ChangePaaword(int UserID ,  string NewPassword)
        {
            int RowsAfficted = -1 ;
            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);

            string query = @"UPDATE Users 
SET Password = '@Pass' 
WHERE UserID = @UID;";

            SqlCommand cmd = new SqlCommand(query , conn);
            cmd.Parameters.AddWithValue(@"Pass" , NewPassword);
            cmd.Parameters.AddWithValue(@"UID", UserID);

            try
            {

                conn.Open();
                RowsAfficted = cmd.ExecuteNonQuery();   

            }
            catch(SqlException ex)
            {
                return false;
            }

            finally { conn.Close(); }

            return RowsAfficted != -1;
        }

    }
}
