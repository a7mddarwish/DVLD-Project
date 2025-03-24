using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDataLayer
{
    public class AD_Drivers
    {
        public static bool PersonIsDriver(int PersonID)
        {
            bool IsDriver = false;

            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = @"select 1 from Drivers WHERE PersonID = @PID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue(@"PID", PersonID);

            try
            {
                conn.Open();
                object obj = cmd.ExecuteScalar();

                if (obj != null && obj != DBNull.Value)
                    IsDriver = true;



            }
            catch (Exception ex)
            {
                IsDriver = false;
            }

            finally { conn.Close(); }

            return IsDriver;

        }

        public static int AddNewDriver(int PersonID, int CreatedBy, DateTime CreatedDate)
        {
            int newDriverID;
            using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate) VALUES (@PersonID, @CreatedBy, @CreatedDate); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                        newDriverID = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {


                    newDriverID = -1;
                }
                finally { conn.Close(); }
            }
            return newDriverID;
        }
        public static int GetDriverID(int PersonID)
        {
            int driverID = -1 ;
            using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT DriverID FROM Drivers WHERE PersonID = @PersonID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        object Result= cmd.ExecuteScalar();
                        if (Result != null && Result != DBNull.Value)
                        {
                            driverID = (int)Result;
                        }
                    }
                }
                catch (Exception ex)
                {


                    driverID = -1;
                }
                finally { conn.Close(); }
            }
            return driverID;

        }
        public static int GetPersonID(int DriverID)
        {
            int PersonID = -1;
            using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT PersonID FROM Drivers WHERE DriverID = @DID";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@DID", DriverID);
                        object Result = cmd.ExecuteScalar();
                        if (Result != null && Result != DBNull.Value)
                        {
                            PersonID = (int)Result;
                        }
                    }
                }
                catch (Exception ex)
                {


                    PersonID = -1;
                }
                finally { conn.Close(); }
            }
            return PersonID;
        }
        public static DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = @"select * from Drivers_View";

            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                dt.Load(cmd.ExecuteReader());
            }
            finally { conn.Close(); }

            return dt;
        }
    }
}
