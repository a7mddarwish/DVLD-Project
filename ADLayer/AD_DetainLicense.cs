using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDataLayer
{
    public class AD_DetainLicense
    {

        public static int AddNew(int licenseID, DateTime detainDate, decimal fineFees, int createdByUserID, bool isReleased, DateTime? releaseDate, int? releasedByUserID, int? releaseApplicationID)
        {
            int newId = -1;
            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {

                string sql = "INSERT INTO DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID) " +
                             "VALUES (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID); " +
                             "SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@LicenseID", licenseID);
                command.Parameters.AddWithValue("@DetainDate", detainDate);
                command.Parameters.AddWithValue("@FineFees", fineFees);
                command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                command.Parameters.AddWithValue("@IsReleased", isReleased);
                command.Parameters.AddWithValue("@ReleaseDate", releaseDate ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ReleasedByUserID", releasedByUserID ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ReleaseApplicationID", releaseApplicationID ?? (object)DBNull.Value);

                try
                {
                    connection.Open();
                    newId = Convert.ToInt32(command.ExecuteScalar());

                }
                catch (Exception ex)
                {

                    newId = -1;
                }
                finally { connection.Close(); }

                return newId;
            }
        }

        public static bool IsLicenseDetained(int licenseID)
        {
            int count = -1;
            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {

                string sql = "SELECT COUNT(*) FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@LicenseID", licenseID);
                try
                {
                    connection.Open();
                    count = Convert.ToInt32(command.ExecuteScalar());

                }
                catch (Exception ex)
                {

                    count = -1;
                }
                finally { connection.Close(); }

                return count > 0;
            }
        }

        public static bool Update(int detainID, int licenseID, DateTime detainDate, decimal fineFees, int createdByUserID, bool isReleased, DateTime? releaseDate, int? releasedByUserID, int? releaseApplicationID)
        {
            int rowsAffected = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionSettings.connectionstring))
            {

                string sql = @"UPDATE DetainedLicenses 
                             SET LicenseID = @LicenseID,
                                 DetainDate = @DetainDate, 
                                 FineFees = @FineFees, 
                                 CreatedByUserID = @CreatedByUserID, 
                                 IsReleased = @IsReleased, 
                                 ReleaseDate = @ReleaseDate,
                                 ReleasedByUserID = @ReleasedByUserID,
                                 ReleaseApplicationID = @ReleaseApplicationID 
                             WHERE DetainID = @DetainID";

                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@LicenseID", licenseID);
                command.Parameters.AddWithValue("@DetainDate", detainDate);
                command.Parameters.AddWithValue("@FineFees", fineFees);
                command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                command.Parameters.AddWithValue("@IsReleased", isReleased);
                command.Parameters.AddWithValue("@ReleaseDate", releaseDate ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ReleasedByUserID", releasedByUserID ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ReleaseApplicationID", releaseApplicationID ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@DetainID", detainID);

                try
                {
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();

                }
                catch { rowsAffected = -1; }
                finally { connection.Close(); }

                return rowsAffected > 0;
            }
        }


        public static bool FindDetainByLicenseID(ref int detainID, int licenseID, ref DateTime detainDate, ref decimal fineFees, ref int createdByUserID)
        {
            bool Success = false;
            using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
            {

                string sql = @"SELECT DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID
                               FROM DetainedLicenses 
                             WHERE LicenseID = @LicenseID and IsReleased = 0 ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@LicenseID", licenseID);

                try
                {
                        conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {

                        detainID = reader.GetInt32(reader.GetOrdinal("DetainID"));
                        detainDate = reader.GetDateTime(reader.GetOrdinal("DetainDate"));
                        fineFees = reader.GetDecimal(reader.GetOrdinal("FineFees"));
                        createdByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                        Success = true;
                    }
                }
                catch { Success = false; }

                finally { conn.Close(); }


            }
            return Success;
        }
        public static bool FindDetainByDetainID(int detainID, ref int licenseID, ref DateTime detainDate, ref decimal fineFees, ref int createdByUserID)
        {
            bool Success = false;
            using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
            {

                string sql = @"SELECT DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID
                               FROM DetainedLicenses 
                             WHERE LicenseID = @detainid and IsReleased = 0 ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@detainid", detainID);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {

                        licenseID = reader.GetInt32(reader.GetOrdinal("LicenseID"));
                        detainDate = reader.GetDateTime(reader.GetOrdinal("DetainDate"));
                        fineFees = reader.GetDecimal(reader.GetOrdinal("FineFees"));
                        createdByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                        Success = true;
                    }
                }
                catch { Success = false; }

                finally { conn.Close(); }


            }
            return Success;
        }

        public static DataTable GetAllDetainLicese()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
            {

                string sql = @"SELECT * FROM DetainedLicenses";


                SqlCommand cmd = new SqlCommand(sql, conn);

                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        dt.Load(reader);
                    }
                }

                finally { conn.Close(); }

            }
            return dt;

        }
    }
}
