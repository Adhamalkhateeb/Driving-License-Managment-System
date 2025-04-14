using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsInternationalLicenseData
    {

       static public bool FindLicense(int internationalLicenseId, ref int applicationId, ref int driverId, ref int issuedUsingLocalLicenseId,
            ref DateTime issueDate, ref DateTime expirationDate, ref bool isActive, ref int createdByUserId)
        {
            bool Found = false;
            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {
                string query = "SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @LicenseID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@LicenseID", internationalLicenseId);
                    try
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                applicationId = (int)reader["ApplicationID"];
                                driverId = (int)reader["DriverID"];
                                issuedUsingLocalLicenseId = (int)reader["IssuedUsingLocalLicenseID"];
                                issueDate = (DateTime)reader["IssueDate"];
                                expirationDate = (DateTime)reader["ExpirationDate"];
                                isActive = (bool)reader["IsActive"];
                                createdByUserId = (int)reader["CreatedByUserID"];
                               

                                Found = true;
                            }
                        }
                    }catch { Found = false; }
                }
            }
            return Found;
        }

        static public int AddInternationalLicense(int applicationId, int driverId, int issuedUsingLocalLicenseId, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserId)
        {
            int InternationlLicenseId = -1;
            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {
                string query = @" Update InternationalLicenses set IsActive = 0 
                          where DriverID = @DriverID;

                     INSERT INTO InternationalLicenses 
                        (ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID) 
               VALUES (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate, @ExpirationDate, @IsActive, @CreatedByUserID);
                Select SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ApplicationID", applicationId);
                    cmd.Parameters.AddWithValue("@DriverID", driverId);
                    cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", issuedUsingLocalLicenseId);
                    cmd.Parameters.AddWithValue("@IssueDate", issueDate);
                    cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                    cmd.Parameters.AddWithValue("@IsActive", isActive);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserId);

                    try
                    {
                        con.Open();

                        if (int.TryParse(cmd.ExecuteScalar().ToString(), out int InsertedLicenseID))
                            InternationlLicenseId = InsertedLicenseID;

                    }
                    catch { InternationlLicenseId = -1; }
                }
            }
            return InternationlLicenseId;
        }

        static public DataTable GetAllLicenses()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {
                string query = @"select InternationalLicenseID,ApplicationID,DriverID,IssuedUsingLocalLicenseID,Cast(IssueDate as date) as IssueDate,
                  Cast(ExpirationDate as date) as ExpirationDate,IsActive from InternationalLicenses order by ExpirationDate desc";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);

                        }

                    }
                    catch { }
                }


            }
            return dt;
        }

        static public bool UpdateLicense(int licenseId, int applicationId, int driverId, int issuedUsingLocalLicenseId, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserId)
        {
            bool Updated = false;
            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {

                string query = @"UPDATE InternationalLicenses SET 
                            ApplicationID=@ApplicationID, DriverID=@DriverID, IssuedUsingLocalLicenseID=@IssuedUsingLocalLicenseID,
                      IssueDate=@IssueDate, ExpirationDate=@ExpirationDate, IsActive=@IsActive, CreatedByUserID=@CreatedByUserID 
                           WHERE InternationalLicenseID=@LicenseID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@LicenseID", licenseId);
                    cmd.Parameters.AddWithValue("@ApplicationID", applicationId);
                    cmd.Parameters.AddWithValue("@DriverID", driverId);
                    cmd.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", issuedUsingLocalLicenseId);
                    cmd.Parameters.AddWithValue("@IssueDate", issueDate);
                    cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                    cmd.Parameters.AddWithValue("@IsActive", isActive);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserId);

                    try
                    {

                        con.Open();

                        if (cmd.ExecuteNonQuery() > 0)
                            Updated = true;
                    }
                    catch { Updated = false; }
                }
            }
            return Updated;
        }


        static public bool DeleteLicense(int licenseId)
        {
            bool Deleted = false;
            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {
                string query = "DELETE FROM InternationalLicenses WHERE InternationalLicenseID=@LicenseID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@LicenseID", licenseId);
                    try
                    {

                        con.Open();

                        if (cmd.ExecuteNonQuery() > 0)
                            Deleted = true;
                    }
                    catch { Deleted = false; }
                }
            }
            return Deleted;
        }

        static public DataTable GetAllDriverLicenses(int DriverID)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {
                string query = @"select InternationalLicenseID,ApplicationID,IssuedUsingLocalLicenseID,Cast(IssueDate as Date) as IssueDate,
          CAST(ExpirationDate AS DATE) AS ExpirationDate, IsActive from InternationalLicenses where DriverID = @DriverID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@DriverID", DriverID);
                    try
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);

                        }

                    }
                    catch { }
                }


            }
            return dt;
        }



        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {
            int internationalLicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string query = @" SELECT InternationalLicenseID
                            FROM InternationalLicenses INNER JOIN
                            Drivers ON InternationalLicenses.DriverID = Drivers.DriverID
                           WHERE Drivers.DriverID = @DriverID and GetDate() Between IssueDate and ExpirationDate and  IsActive = 1;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int FoundID))
                {
                    internationalLicenseID = FoundID;
                }
            }

            catch
            {

            }

            finally
            {
                connection.Close();
            }


            return internationalLicenseID;
        }

        public static bool DeactivateLicense(int InternationalLicenseID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string query = @"update InternationalLicenses set IsActive = 0 
                           where InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch { }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


    }
}
