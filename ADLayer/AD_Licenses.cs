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
    public class AD_Licenses
    {
        public static int AddNewLicens(int baseApplicationID, int driverID, byte IssueReason,  int licenseClassID, DateTime issueDate
            , DateTime expirationDate, string notes, decimal paidFees, bool isActive, int createdByUserID)
        {
            int newLicenseId = -1;
            using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
            {


                string sql = "INSERT INTO Licenses (ApplicationID, DriverID, IssueReason, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, CreatedByUserID) " +
                             "VALUES (@ApplicationID, @DriverID, @issuereason ,@LicenseClassID, @IssueDate, @ExpirationDate, @Notes, @PaidFees, @IsActive, @CreatedByUserID); " +
                             "SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ApplicationID", baseApplicationID);
                cmd.Parameters.AddWithValue("@DriverID", driverID);
                cmd.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
                cmd.Parameters.AddWithValue("@IssueDate", issueDate);
                cmd.Parameters.AddWithValue("@issuereason", IssueReason);
                cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                if (! String.IsNullOrEmpty(notes))
                cmd.Parameters.AddWithValue("@Notes", notes);

                else
                    cmd.Parameters.AddWithValue("@Notes", DBNull.Value);

                cmd.Parameters.AddWithValue("@PaidFees", paidFees);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                try
                {
                    conn.Open();

                     newLicenseId = Convert.ToInt32(cmd.ExecuteScalar());

                }
                catch (Exception ex) 
                {
                newLicenseId = -1;
                
                }
                finally { conn.Close(); }


                return newLicenseId;
            }
        }

        public static bool DeActiveLicense(int licenseID)
        {
            int RowsAffected = 0;
            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = @"update Licenses set IsActive = 0 where LicenseID = @LID;";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue(@"LID" , licenseID);

            try
            {
                conn.Open();

                 RowsAffected = cmd.ExecuteNonQuery();

            }
            catch
            {
                RowsAffected = 0;
            }
            finally { conn.Close(); }

            return RowsAffected != 0;

        }

        public static bool FindByBaseApplication(int baseApplicationID, ref int issueReason, ref int licenseID, ref int driverID, ref int licenseClassID, 
            ref DateTime issueDate, ref DateTime expirationDate, ref string notes, ref decimal paidFees, ref bool isActive, ref int createdByUserID)
        {
            bool success = false;

            string query = "select * from Licenses where ApplicationID = @BaseAppID";

            using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BaseAppID", baseApplicationID);

                try
                {

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    licenseID = (int)reader["LicenseID"];
                    licenseClassID = (int)reader["LicenseClassID"];
                    driverID = (int)reader["DriverID"];
                    issueDate = (DateTime)reader["IssueDate"];
                    expirationDate = (DateTime)reader["ExpirationDate"];

                    if (reader["Notes"] != DBNull.Value)
                        notes = (string)reader["Notes"];
                    else notes = "";


                    paidFees = (decimal)reader["PaidFees"];
                    isActive = (bool)reader["IsActive"];
                    issueReason = (byte)reader["IssueReason"];
                    createdByUserID = (int)reader["CreatedByUserID"];
                     
 
                        success = true;
                }

                }
                catch(Exception ex) 
                {
                    // log it 
                    success = false;


                }
                finally { conn.Close(); }
            }
            return success;


        }

        public static bool FindByLicensesID(ref int baseApplicationID, ref int issueReasonID, int licenseID, ref int driverID, ref int licenseClassID
            , ref DateTime issueDate, ref DateTime expirationDate, ref string notes, ref decimal paidFees, ref bool isActive, ref int createdByUserID)
        {
            bool success = false;

            string query = "select * from Licenses where LicenseID = @LicensID";

            using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LicensID", licenseID);

                try
                {

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {

                        baseApplicationID = (int)reader["ApplicationID"];
                        licenseClassID = (int)reader["LicenseClassID"];
                        driverID = (int)reader["DriverID"];
                        issueDate = (DateTime)reader["IssueDate"];
                        expirationDate = (DateTime)reader["ExpirationDate"];

                        if (reader["Notes"] != DBNull.Value)
                            notes = (string)reader["Notes"];
                        else notes = "";


                        paidFees = (decimal)reader["PaidFees"];
                        isActive = (bool)reader["IsActive"];
                        issueReasonID = (byte)reader["IssueReason"];
                        createdByUserID = (int)reader["CreatedByUserID"];


                        success = true;
                    }

                }
                catch (Exception ex)
                {
                    // log it 
                    success = false;


                }
                finally { conn.Close(); }
            }
            return success;

        }

        public static int GetActiveLicensID(int personID, int licenseClassID)
        {
            object result = -1;
            using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
            {

                string sql = @"SELECT Top 1 LicenseID 
                             FROM Licenses
                             WHERE DriverID = @PersonID
                               AND LicenseClassID = @LicenseClassID
                               AND IsActive = 1
                             ORDER BY ExpirationDate DESC
                             ";
        
        SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PersonID", personID);
                cmd.Parameters.AddWithValue("@LicenseClassID", licenseClassID);

                conn.Open(); 

                 result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    return (int)result;
                else
                    return -1;
            }
        }
         
        public static DataTable GetLocalLicensByPersonID(int PersonID)
        {
             DataTable dt = new DataTable();
            dt.Columns.Add("License ID" , typeof(int));
            dt.Columns.Add("Application ID" , typeof(int));
            dt.Columns.Add("Class Name" , typeof(string));
            dt.Columns.Add("Issue Date" , typeof(string));
            dt.Columns.Add("Expire Date" , typeof(string));
            dt.Columns.Add("Is Active" , typeof(bool));





            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
                string query = @"select Licenses.LicenseID , Licenses.ApplicationID , 
LicenseClasses.ClassName , Licenses.IssueDate ,
Licenses.ExpirationDate , Licenses.IsActive
from   Licenses
inner Join  Drivers on Licenses.DriverID = Drivers.DriverID 
inner join  People   on Drivers.PersonID = People.PersonID
inner Join  LicenseClasses on LicenseClasses.LicenseClassID = Licenses.LicenseClassID
where People.PersonID = @personid ";


            SqlCommand cmd = new SqlCommand(query , conn);
            cmd.Parameters.AddWithValue(@"personid" , PersonID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(); 
                while (reader.Read()) 
                {
                   DataRow dr = dt.NewRow();
                    dr["License ID"] = (int)reader["LicenseID"];
                    dr["Application ID"] = (int)reader["ApplicationID"];
                    dr["Class Name"] = (string)reader["ClassName"];
                    dr["Issue Date"] = ((DateTime)reader["IssueDate"]).ToString("dd/MMM/yyyy");
                    dr["Expire Date"] = ((DateTime)reader["ExpirationDate"]).ToString("dd/MMM/yyyy");
                    dr["Is Active"] = (bool)reader["IsActive"];
                
                dt.Rows.Add(dr);
                
                }

            }
           finally { conn.Close(); }    


            return dt;
        }

        public static bool IsLicenseExist(int liceseID)
        {
            bool IsFound = false;

            SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring);
            string query = @"select 1 from Licenses Where LicenseID = @LID";
            SqlCommand cmd = new SqlCommand(query , conn);

            cmd.Parameters.AddWithValue(@"LID" , liceseID);
            try
            {
                conn.Open();
                object Result = cmd.ExecuteScalar();

                if (Result != null && Result != DBNull.Value)
                    IsFound = true;

            }
            catch { IsFound = false; }
            finally { conn.Close(); }

            return IsFound;

        }

        public static bool UpdateLicens(int licenseID, int baseApplicationID, int driverID, int licenseClassID, DateTime issueDate
            , DateTime expirationDate, string notes, decimal paidFees, bool isActive, int createdByUserID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionSettings.connectionstring))
            {

                string sql = @"UPDATE Licenses 
                             SET ApplicationID = @ApplicationID, 
                                 DriverID = @DriverID,  
                                 LicenseClassID = @LicenseClassID, 
                                 IssueDate = @IssueDate,  
                                 ExpirationDate = @ExpirationDate, 
                                 Notes = @Notes, 
                                 PaidFees = @PaidFees,  
                                 IsActive = @IsActive, 
                                 CreatedByUserID = @CreatedByUserID
                             WHERE LicenseID = @LicenseID"; 

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@LicenseID", licenseID);
                cmd.Parameters.AddWithValue("@ApplicationID", baseApplicationID);
                cmd.Parameters.AddWithValue("@DriverID", driverID);
                cmd.Parameters.AddWithValue("@LicenseClassID", licenseClassID);
                cmd.Parameters.AddWithValue("@IssueDate", issueDate);
                cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                cmd.Parameters.AddWithValue("@Notes", notes);
                cmd.Parameters.AddWithValue("@PaidFees", paidFees);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery() != 1;
                }
                catch (Exception ex) 
                {
                    return false;
                }
            }
        }
    }
}
