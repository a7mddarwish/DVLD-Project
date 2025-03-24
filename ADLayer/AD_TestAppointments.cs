using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDataLayer
{
    public class AD_TestAppointments
    {

        public static DataTable GetLocalAppAppointmentsByTestType(int LocalApp , int TestTypeID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {
                // SQL query to get appointments for the specified LocalApp
                string query = @"SELECT TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID, 
                        AppointmentDate, PaidFees, CreatedByUserID, IsLocked
                        FROM TestAppointments 
                        WHERE LocalDrivingLicenseApplicationID = @LocalApp and TestTypeID = @tsttypeID;";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter to prevent SQL injection
                    command.Parameters.AddWithValue("@LocalApp", LocalApp);
                    command.Parameters.AddWithValue("@tsttypeID", TestTypeID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        dt.Load(reader);



                    }
                    catch (Exception ex)
                    {
                        // Log the exception details
                        Console.WriteLine($"Error retrieving appointments: {ex.Message}");
                        throw; // Re-throw the exception for proper error handling
                    }
                }
            }

            return dt;
        }

        public static bool LockAppointment(int AppointmentID)
        {
            try
            {
                // استعلام SQL لتحديث IsLocked
                string query = "UPDATE TestAppointments SET IsLocked = 1 WHERE TestAppointmentID = @AppointmentID";

                using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // تحقق إذا تم التحديث
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // معالجة الخطأ (تسجيل الخطأ مثلاً)
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static int InsertRow(int LocalDLID, int TestType,
            DateTime AppointmentDate, decimal Fees,  int? RetakeApplicationsID ,  int createdByID)
        {


            int ID = -1;
            string insertQuery = @"
INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, RetakeApplicationID, CreatedByUserID ,IsLocked )
VALUES (@TestType, @LocalDLID, @AppointmentDate, @Fees, @RTestID,@createdByID , @IsLocked)
SELECT SCOPE_IDENTITY()";

            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@TestType", TestType);
                    command.Parameters.AddWithValue("@LocalDLID", LocalDLID);
                 
                    if (RetakeApplicationsID != null)
                    command.Parameters.AddWithValue("@RTestID", RetakeApplicationsID);
                    else
                        command.Parameters.AddWithValue("@RTestID", DBNull.Value);


                    command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                    command.Parameters.AddWithValue("@Fees", Fees);
                    command.Parameters.AddWithValue("@createdByID", createdByID);
                    command.Parameters.AddWithValue("@IsLocked", false);



                    connection.Open();



                    object obj = command.ExecuteScalar();
                    if (obj != null) { ID = int.Parse(obj.ToString()); }
                    // newId contains the ID of the newly inserted row
                }
            }
            return ID;
        }

        public static bool UpdateDate(int AppointmentID, DateTime AppointmentnewDate)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {
                connection.Open();

                string updateQuery = "UPDATE TestAppointments SET AppointmentDate = @AppointmentNewDate WHERE TestAppointmentID = @AppointmentID";

                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@AppointmentNewDate", AppointmentnewDate);
                    cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public static bool? IsAvaliableTobookAppointment(int localAppID, int TestTypeID)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = @"(select  TestResult  from Tests INNER JOIN TestAppointments on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                             where TestAppointments.LocalDrivingLicenseApplicationID = @LocalID and TestAppointments.TestTypeID= @tsttypeID )order by TestResult desc;";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LocalID", localAppID);
            cmd.Parameters.AddWithValue("@tsttypeID", TestTypeID);

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    i++;
                }
                //object Result = cmd.ExecuteScalar();

                //if (Result == DBNull.Value || Result == null)
                //{
                //    return null;
                //}
                //else
                //{
                //     int R = int.Parse(Result.ToString());
                //    success = !(R == 1);
                //}

            }
            catch (Exception ex)
            {
                success = false;
            }

            finally
            {
                conn.Close();
            }

            return success;

        }

        public static bool GetAppointByID(int appointmentID, ref int localDLID, ref int testTypeID, ref int createdByID, ref DateTime appointmentDate, ref decimal paidfees, ref int? RetakeApplicationsID , ref bool islock)
        {
            bool success = false;

            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = @"select * from TestAppointments where TestAppointmentID = @AppointmentID";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    localDLID = (int)reader["LocalDrivingLicenseApplicationID"];
                    testTypeID = (int)reader["TestTypeID"];
                    appointmentDate = (DateTime)reader["AppointmentDate"];
                    createdByID = (int)reader["CreatedByUserID"];
                    paidfees = (decimal)reader["PaidFees"];
                    islock = (bool)reader["IsLocked"];
                    if ((object)reader["RetakeApplicationID"] == DBNull.Value)
                        RetakeApplicationsID = null;
                    else
                        RetakeApplicationsID = (int)reader["RetakeApplicationID"];

                    success = true;
                }

            }
            catch (Exception ex) { }

            finally { conn.Close(); }

            return success;

        }

        public static bool GetActiveAppointment(ref int appointmentID, int localApplicationID, int testtype, ref int createdByID, ref DateTime appointmentDate, ref int? RetakeApplicationsID, ref decimal paidfees, ref bool islock)
        {

            bool success = false;

            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = @"select * from TestAppointments 
                             where LocalDrivingLicenseApplicationID  = @LocalAppID and TestTypeID = @tsttype and IsLocked = 0";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@LocalAppID", localApplicationID);
            cmd.Parameters.AddWithValue("@tsttype", testtype);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                { 
                    appointmentID = (int)reader["TestAppointmentID"];    
                    appointmentDate = (DateTime)reader["AppointmentDate"];
                    createdByID = (int)reader["CreatedByUserID"];
                    paidfees = (decimal)reader["PaidFees"];
                
                    //    RetakeApplicationsID = ((object)reader["RetakeApplicationID"] == DBNull.Value) ? null : ;

                    if ((object)reader["RetakeApplicationID"] == DBNull.Value)
                        RetakeApplicationsID = null;
                    else
                        RetakeApplicationsID = (int)reader["RetakeApplicationID"];
                   

                    success = true;
                }

            }
            catch (Exception ex) {
                success = false;

            }

            finally { conn.Close(); }

            return success;

        }
    }
    }

