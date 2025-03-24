using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDataLayer
{
    public class AD_LocalApplications
    {



        public static int InsertinDB(int AppID, int LiecensClassID)
        {

            object R = -1;
            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = @"Insert into LocalDrivingLicenseApplications (ApplicationID, LicenseClassID) 
                      values (@P1 , @P2); 
                  Select  SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("P1", AppID);
            cmd.Parameters.AddWithValue("P2", LiecensClassID);

            try
            {
                conn.Open();
                 R = cmd.ExecuteScalar();
                
            }
            finally { conn.Close(); }


            return int.Parse(R.ToString()) ;
        }

        public static DataTable GatAllApplications()
        {



            //   FROM[dbo].[LocalDrivingLicenseApplications_View]

            DataTable dt = new DataTable();
            dt.Columns.Add("L.Application ID", typeof(int));
            dt.Columns.Add("Class Name", typeof(string));
            dt.Columns.Add("National Nom.", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Application Date", typeof(string));
            dt.Columns.Add("Passed Tests Count", typeof(int));
            dt.Columns.Add("Stutus", typeof(String));



            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = @"Select * from LocalDrivingLicenseApplications_View ";
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {


                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DataRow dr = dt.NewRow();

                    dr["L.Application ID"] = (int)reader["LocalDrivingLicenseApplicationID"];
                    dr["Class Name"] = AD_LicenesClass.GetLiceneName((int)reader["LicenseClassID"]);

                    dr["Name"] = (string)reader["FullName"];
                    dr["National Nom."] = (string)reader["NationalNo"];
                    dr["Application Date"] = ((DateTime)reader["ApplicationDate"]).ToString("dd/MM/yyyy");
                    dr["Passed Tests Count"] = (int)reader["PassedTestCount"];

                 //   dr["Stutus"] = reader["StatusID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["StatusID"]);

                    if (reader["StatusID"] != DBNull.Value)
                    {
                        switch (Convert.ToInt32(reader["StatusID"]))
                            {
                            case 1:
                                dr["Stutus"] = "New";
                                break; 
                            case 2:
                                dr["Stutus"] = "Cancelled";
                                break; 
                            case 3:
                                dr["Stutus"] = "Completed";
                                break;

                            default:
                                dr["Stutus"] = "Unknown";
                                break;

                             }

                    }


                    dt.Rows.Add(dr);
                }

            }
            //catch (Exception e)
            //{
            //    throw e.InnerException;
            //}
            finally { conn.Close(); }


            return dt;
        }

        public static int IsAppHere(int PersonID, int LeciecsclassID)
        {

            int AppID = -1;
            // Validate input parameters
            if (PersonID < 0)
            {
                throw new ArgumentNullException(nameof(PersonID), "National number cannot be null or empty");
            }

            if (LeciecsclassID < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(LeciecsclassID), "Selected index must be non-negative");
            }

            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = @"select LocalDrivingLicenseApplicationID,  LicenseClassID , ApplicantPersonID from 
(LocalDrivingLicenseApplications l INNER JOIN 
Applications a ON
a.ApplicationID = l.ApplicationID)
where ApplicantPersonID =@PID AND LicenseClassID = @LID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue(@"PID", PersonID);
            cmd.Parameters.AddWithValue(@"LID", LeciecsclassID);
            try
            {
                conn.Open();
                object R = cmd.ExecuteScalar();

                AppID = (R == DBNull.Value || R == null) ? -1 : int.Parse(R.ToString());


            }
            finally
            {
                conn.Close();
            }

            return AppID;
        }

        public static bool GetAppByPersonIDandLClass(int personID, int appClass, ref int LocalAppID, ref int appID, ref int appStutes, ref DateTime appDate, ref DateTime lastStatusDate, ref decimal fees, ref int userCreated)
        {
            bool success = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
                {
                    string query = @"select LocalDrivingLicenseApplicationID,  LicenseClassID ,  a.* from 
(LocalDrivingLicenseApplications l INNER JOIN 
Applications a ON
a.ApplicationID = l.ApplicationID)
where ApplicantPersonID =@PID AND LicenseClassID = @LClass";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        // Add input parameters
                        cmd.Parameters.AddWithValue("@PID", personID);
                        cmd.Parameters.AddWithValue("@LClass", appClass);

                        // Add output parameters


                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Check if we got results
                        if (reader.Read())
                        {
                            LocalAppID = (int)reader[0];
                            appID = (int)reader["ApplicationID"];
                            appStutes = (byte)reader["ApplicationStatus"];

                            appDate = (DateTime)reader["ApplicationDate"];
                            lastStatusDate = (DateTime)reader["LastStatusDate"];
                            fees = (decimal)reader["PaidFees"];
                            userCreated = (int)reader["CreatedByUserID"];
                            success = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception details here
                success = false;
            }

            return success;
        }

        public static bool GetAppByLocalAppID(int lapplicationID, ref int personID, ref int LecsClassID,
            ref int appID, ref int appStutes, ref DateTime appDate, ref DateTime lastStatusDate, ref decimal fees, ref int userCreated)
        {
            bool success = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
                {
                    string query = @"select LocalDrivingLicenseApplicationID,  LicenseClassID ,  a.* from 
(LocalDrivingLicenseApplications l INNER JOIN 
Applications a ON
a.ApplicationID = l.ApplicationID)
where LocalDrivingLicenseApplicationID = @LDLI";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        // Add input parameters
                        cmd.Parameters.AddWithValue("@LDLI", lapplicationID);

                        // Add output parameters


                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Check if we got results
                        if (reader.Read())
                        {
                            LecsClassID = (int)reader["LicenseClassID"];
                            personID = (int)reader["ApplicantPersonID"];
                            appID = (int)reader["ApplicationID"];
                            appStutes = (byte)reader["ApplicationStatus"];
                            appDate = (DateTime)reader["ApplicationDate"];
                            lastStatusDate = (DateTime)reader["LastStatusDate"];
                            fees = (decimal)reader["PaidFees"];
                            userCreated = (int)reader["CreatedByUserID"];
                            success = true;
                        }

                    }
                }


            }
            catch (Exception ex)
            {
                // Log the exception details here
                success = false;
            }




            return success;

        }

        public static bool GetFullAppInfoByLocalAppID(int lapplicationID, ref int applicationID, ref int personID, ref int PassesTests,
        ref int LicenseclassID, ref int ApplicationTypeID, ref int appStutes, ref DateTime appDate,
        ref DateTime lastStatusDate, ref decimal fees, ref int userCreated)
        {
            bool success = false;

            using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
            {
                string query = @"SELECT 
            BaseApplicationID,
            PersonID,
            LicenseClassID,
			PassedTestCount,
            StatusID,
			ApplicationTypeID,
            ApplicationDate,
            LastStatusDate,
            PaidFees,
            CreatedByUserID
        FROM LocalDrivingLicenseApplications_View
        WHERE LocalDrivingLicenseApplicationID = @LDLI";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LDLI", lapplicationID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                applicationID = (int)reader["BaseApplicationID"];
                                personID = (int)reader["PersonID"];
                                LicenseclassID = reader.GetInt32(reader.GetOrdinal("LicenseClassID"));
                                PassesTests = reader.GetInt32(reader.GetOrdinal("PassedTestCount"));
                                //  int R = appStutes = ((int)reader["StatusID"]  ) ? 0 : (int)reader["StatusID"] ;
                                appStutes = reader["StatusID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["StatusID"]);
                                ApplicationTypeID = reader.GetInt32(reader.GetOrdinal("ApplicationTypeID"));
                                appDate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
                                lastStatusDate = reader.GetDateTime(reader.GetOrdinal("LastStatusDate"));
                                fees = reader.GetDecimal(reader.GetOrdinal("PaidFees"));
                                userCreated = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));

                                success = true;

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        success = false;
                    }
                }
            }

            return success;
        }

        public static bool GetLocalDrivingLicenseApplicationInfoByApplicationID(
          int ApplicationID, ref int LocalDrivingLicenseApplicationID,
          ref int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring);

            string query = @"SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID = @AppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AppID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring);

            string query = @"Delete LocalDrivingLicenseApplications 
                                where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }

        public static bool DoesAttendTestType(object localDrivingLicenseApplicationID, int testTypeID)
        {


            bool IsFound = false;

            SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring);

            string query = @" SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", testTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    IsFound = true;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static byte TotalTrialsPerTest(int localAppID, int testTypeID)
        {

            byte TotalTrialsPerTest = 0;

            SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring);

            //string query = @" SELECT TotalTrialsPerTest = count(TestID)
            //                FROM LocalDrivingLicenseApplications INNER JOIN
            //                     TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
            //                     Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
            //                WHERE
            //                (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
            //                AND(TestAppointments.TestTypeID = @TestTypeID)
            //           ";

            string query = @"
							SELECT TotalTrialsPerTest = (count(TestAppointmentID ))
							from TestAppointments where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID    AND(TestTypeID = @tettypeID)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localAppID);
            command.Parameters.AddWithValue("@tettypeID", testTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte Trials))
                {
                    TotalTrialsPerTest = Trials;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return TotalTrialsPerTest;

        }

        public static bool IsThereAnActiveScheduledTest(int localDrivingLicenseApplicationID, int testTypeID)
        {
            bool Result = false;

            SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring);

            string query = @" select 1 from TestAppointments  WHERE
                            (LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)  
                            AND(TestTypeID = @TestTypeID) and isLocked=0
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", testTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null)
                {
                    Result = true;
                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return Result;

        }

        public static bool DoesPassTestType(int localAppID, int testTypeID)
        {
            bool Result = false;

            SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring);

            string query = @" SELECT top 1 TestResult
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localAppID);
            command.Parameters.AddWithValue("@TestTypeID", testTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && bool.TryParse(result.ToString(), out bool returnedResult))
                {
                    Result = returnedResult;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return Result;

        }
    }
}
