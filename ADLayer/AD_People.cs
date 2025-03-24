using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Dynamic;

namespace AccessDataLayer
{
    public class AD_People
    {
        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = "Select * from People";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                    conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                // انشاء الأعمدة في DataTable
                dt.Columns.Add("PersonID", typeof(int));
                dt.Columns.Add("NationalNom", typeof(string));
                dt.Columns.Add("FirstName", typeof(string));
                dt.Columns.Add("SecondName", typeof(string));
                dt.Columns.Add("ThirdName", typeof(string));
                dt.Columns.Add("LastName", typeof(string));
                dt.Columns.Add("DateOfBirth", typeof(DateTime));
                dt.Columns.Add("Gender", typeof(string));
                dt.Columns.Add("Address", typeof(string));
                dt.Columns.Add("Phone", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("Nationality", typeof(int));
                dt.Columns.Add("ImagePath", typeof(string));

                // نقل البيانات من Reader إلى DataTable
                while (reader.Read())
                {
                    DataRow row = dt.NewRow();

                    // التحقق من القيم الفارغة ومعالجتها
                    row["PersonID"] = reader["PersonID"] != DBNull.Value ? reader["PersonID"] : 0;
                    row["NationalNom"] = reader["NationalNo"] != DBNull.Value ? reader["NationalNo"] : "";
                    row["FirstName"] = reader["FirstName"] != DBNull.Value ? reader["FirstName"] : "";
                    row["SecondName"] = reader["SecondName"] != DBNull.Value ? reader["SecondName"] : "";
                    row["ThirdName"] = reader["ThirdName"] != DBNull.Value ? reader["ThirdName"] : "";
                    row["LastName"] = reader["LastName"] != DBNull.Value ? reader["LastName"] : "";
                    row["DateOfBirth"] = reader["DateOfBirth"] != DBNull.Value ? reader["DateOfBirth"] : DateTime.MinValue;

                    row["Gender"] = (Convert.ToBoolean(reader["Gender"]) ? "Femal" : "Male");


                    row["Address"] = reader["Address"] != DBNull.Value ? reader["Address"] : "";
                    row["Phone"] = reader["Phone"] != DBNull.Value ? reader["Phone"] : "";
                    row["Email"] = reader["Email"] != DBNull.Value ? reader["Email"] : "";
                    row["Nationality"] = reader["NationalityCountryID"] != DBNull.Value ? reader["NationalityCountryID"] : "";
                    row["ImagePath"] = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"] : "";

                    dt.Rows.Add(row);
                }

                return dt;
            }
            catch (Exception ex)
            {
                
                return null;
            }
            finally
            {
               conn.Close();
            }
        }

        public static int SaveRec(string firstName, string secondName, string thirdName, string lastName,
            string email, string address, string gender, string phone, 
            string imagePath, string nationalNom, int nationalityCountryID, DateTime dateOfBirth)
        {
            int ID = -1;
            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);

            string query = @"INSERT INTO People (
                        FirstName,
                        SecondName,
                        ThirdName,
                        LastName,
                        Email,
                        Address,
                        Gender,
                        Phone,
                        ImagePath,
                        NationalNo,
                        NationalityCountryID,
                        DateOfBirth
                    )
                    VALUES (
                        @FirstName,
                        @SecondName,
                        @ThirdName,
                        @LastName,
                        @Email,
                        @Address,
                        @Gender,
                        @Phone,
                        @ImagePath,
                        @NationalNom,
                        @NationalityCountryID,
                        @DateOfBirth
                    );
                    SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query , conn);

            // adding parametes
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@SecondName", secondName);

            if (!String.IsNullOrEmpty(thirdName))
                cmd.Parameters.AddWithValue("@ThirdName", thirdName);
            else
                cmd.Parameters.AddWithValue("@ThirdName", DBNull.Value);

            cmd.Parameters.AddWithValue("@LastName", lastName);

            if (!String.IsNullOrEmpty( email ))
            cmd.Parameters.AddWithValue("@Email", email);
            else
                cmd.Parameters.AddWithValue("@Email", DBNull.Value);


            cmd.Parameters.AddWithValue("@Address", address);

            if (gender.ToLower() == "female") cmd.Parameters.AddWithValue("@Gender", true);
            else cmd.Parameters.AddWithValue("@Gender", false);


            cmd.Parameters.AddWithValue("@Phone", phone);

            if (!String.IsNullOrEmpty(imagePath))
                cmd.Parameters.AddWithValue("@ImagePath", imagePath);
            else
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
          

            cmd.Parameters.AddWithValue("@NationalNom", nationalNom);
            cmd.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);
            cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);



            try 
            {
                conn.Open();
                object obj = cmd.ExecuteScalar();
                if (obj != DBNull.Value) 
                {

                    int.TryParse(obj.ToString(), out  ID);
                }

            }
            catch (Exception ex) 
            { }
            finally
            { conn.Close(); }

            return ID;
        }

        public static bool UpdateRec(int ID , string firstName, string secondName, string thirdName, string lastName,
            string email, string address, string gender, string phone,
            string imagePath, string nationalNom, int nationalityCountryID, DateTime dateOfBirth)
        {
            int RowsAffected = 0;
            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);

            string query = @"Update People 
                                  set 
                                  FirstName = @FirstName ,
                                  SecondName = @SecondName,
                                  ThirdName = @ThirdName,
                                  LastName =@LastName,
                                  Email =@Email,
                                  Address =@Address,
                                  Gender = @Gender,
                                  Phone = @Phone,
                                  ImagePath = @ImagePath,
                                  NationalNo=@NationalNom,
                                  NationalityCountryID =@NationalityCountryID,
                                  DateOfBirth=@DateOfBirth
                                  
                                  where People.PersonID = @ID;";


            SqlCommand cmd = new SqlCommand(query, conn);

            // adding parametes
            cmd.Parameters.AddWithValue("@ID", ID);


            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@SecondName", secondName);

            if (!String.IsNullOrEmpty(thirdName))
                cmd.Parameters.AddWithValue("@ThirdName", thirdName);
            else
                cmd.Parameters.AddWithValue("@ThirdName", DBNull.Value);

            cmd.Parameters.AddWithValue("@LastName", lastName);

            if (!String.IsNullOrEmpty(email))
                cmd.Parameters.AddWithValue("@Email", email);
            else
                cmd.Parameters.AddWithValue("@Email", DBNull.Value);

            cmd.Parameters.AddWithValue("@Address", address);

            if (gender.ToLower() == "female") cmd.Parameters.AddWithValue("@Gender", true);
            else cmd.Parameters.AddWithValue("@Gender", false);


            cmd.Parameters.AddWithValue("@Phone", phone);

            if (!String.IsNullOrEmpty(imagePath))
                cmd.Parameters.AddWithValue("@ImagePath", imagePath);
            else
                cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);


            cmd.Parameters.AddWithValue("@NationalNom", nationalNom);
            cmd.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);
            cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);

            try
            {
                conn.Open();

              RowsAffected = cmd.ExecuteNonQuery();

            }

            finally { conn.Close(); }

            return RowsAffected != 0;

        }

        public static bool GetPersonByID(int ID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName,
      ref string email, ref string address, ref string gender,ref string phone,
      ref string imagePath, ref string nationalNom,ref int nationalityCountryID,ref DateTime dateOfBirth)
        {
            bool personExists = false;

            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {

                string query = @"SELECT * FROM People WHERE PersonID = @ID";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@ID", ID);
                   

                    try
                    {
                        connection.Open();
                        SqlDataReader reader =  command.ExecuteReader();
                        if (reader.Read())
                        {
                            firstName = (string)reader["FirstName"];
                            secondName = (string)reader["SecondName"];

                            thirdName = (reader["ThirdName"] != DBNull.Value) ? (string)reader["ThirdName"] : "";

                            

                            lastName = (string)reader["LastName"];
                            dateOfBirth = (DateTime)reader["DateOfBirth"];

                            bool.TryParse( reader["Gender"].ToString() , out bool G );
                            gender = (G== true) ? "Femal" : "Male";


                            address = (string)reader["Address"];
                            phone = (string)reader["Phone"];
                            nationalNom = (string)reader["NationalNo"];
                            email = (reader["Email"] != DBNull.Value) ? (string)reader["Email"] : "";


                            nationalityCountryID = (int)reader["NationalityCountryID"];
                            imagePath = (reader["ImagePath"] != DBNull.Value) ? (string)reader["ImagePath"] : "";

                            personExists = true;
                        }

                    }
                    catch (SqlException ex)
                    {
                        // Log the exception details
                        Console.WriteLine($"Database error: {ex.Message}");
                        throw;
                    }
                    catch (Exception ex)
                    {
                        // Log the exception details
                        Console.WriteLine($"General error: {ex.Message}");
                        throw;
                    }
                }
            }

            return personExists;
        }

           public static bool GetPersonByNationalNumber(ref int ID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName,
      ref string email, ref string address, ref string gender,ref string phone,
      ref string imagePath, string nationalNom,ref int nationalityCountryID,ref DateTime dateOfBirth)
        {
            bool personExists = false;

            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {

                string query = @"SELECT * FROM People WHERE NationalNo = @NN";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@NN", nationalNom);
                   

                    try
                    {
                        connection.Open();
                        SqlDataReader reader =  command.ExecuteReader();
                        if (reader.Read())
                        {
                            ID = (int)reader["PersonID"];
                            firstName = (string)reader["FirstName"];
                            secondName = (string)reader["SecondName"];
                            thirdName = (reader["ThirdName"] != DBNull.Value) ? (string)reader["ThirdName"] : "";
                            lastName = (string)reader["LastName"];
                            dateOfBirth = (DateTime)reader["DateOfBirth"];

                            //  gender = (bool.Parse(reader["Gender"].ToString()) == true) ? "Femal" : "Male";

                            bool.TryParse(reader["Gender"].ToString(), out bool G);
                            gender = (G == true) ? "Femal" : "Male";

                            address = (string)reader["Address"];
                            phone = (string)reader["Phone"];
                           // nationalNom = (string)reader["NationalNo"];
                            email = (reader["Email"] != DBNull.Value) ? (string)reader["Email"] : "";


                            nationalityCountryID = (int)reader["NationalityCountryID"];
                            imagePath = (reader["ImagePath"] != DBNull.Value) ? (string)reader["ImagePath"] : "";

                            personExists = true;
                        }

                    }
                    catch (SqlException ex)
                    {
                        // Log the exception details
                        Console.WriteLine($"Database error: {ex.Message}");
                        throw;
                    }
                    catch (Exception ex)
                    {
                        // Log the exception details
                        Console.WriteLine($"General error: {ex.Message}");
                        throw;
                    }
                }
            }
            


            return personExists;
        }


        public static bool DeleteByID(int ID)
        {
            bool ProcessDone = false;

            try
            {
                // Open the database connection
                using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
                {
                    connection.Open();

                    // Create a SQL command to delete the record
                    string deleteQuery = "DELETE FROM People WHERE PersonID = @ID";
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        // Set the parameter value
                        command.Parameters.AddWithValue("@ID", ID);

                        // Execute the delete command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if the delete was successful
                        if (rowsAffected > 0)
                        {
                            ProcessDone = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the delete operation
                Console.WriteLine($"Error deleting record: {ex.Message}");
            }

            return ProcessDone;
        }

        public static bool IsPersonHere(string NationalNumber)
        {
            bool ProcessResult = false;
            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = "Select 1 from People where NationalNo = @NN";
            SqlCommand cmd = new SqlCommand(query , conn);
            cmd.Parameters.AddWithValue("@NN", NationalNumber);

            try
            {
                conn.Open();

                ProcessResult =  (cmd.ExecuteScalar() != null)? true : false;

            }
            catch(Exception ex)
            {
                ProcessResult = false;
            }
            finally { conn.Close(); }   
            
            return ProcessResult;   
        }  
        public static bool IsPersonHere(int PersonID)
        {
            bool ProcessResult = false;
            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = "Select 1 from People where PersonID = @PID";
            SqlCommand cmd = new SqlCommand(query , conn);
            cmd.Parameters.AddWithValue("@PID", PersonID);

            try
            {
                conn.Open();

                ProcessResult =  (cmd.ExecuteScalar() != null)? true : false;

            }
            catch(Exception ex)
            {
                ProcessResult = false;
            }
            finally { conn.Close(); }   
            
            return ProcessResult;   
        }
    }
}
