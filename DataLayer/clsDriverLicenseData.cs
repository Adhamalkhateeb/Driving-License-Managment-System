using DataLayer;
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;


namespace DataLayer
{
    public class clsDriverLicenseData
    {


        public static int AddLicense(int applicationID, int driverID, byte licenseClass, DateTime issueDate, DateTime expirationDate,
                                      string Notes,float paidFees, bool isActive, byte issueReason, int createdByUserID)
        {
            int LicneseID = -1;
            string query = @"
            INSERT INTO Licenses (ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate,Notes,PaidFees, IsActive, IssueReason, CreatedByUserID) 
            VALUES (@ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate,@Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID)
             Select Scope_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Notes",Notes);
                        cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                        cmd.Parameters.AddWithValue("@DriverID", driverID);
                        cmd.Parameters.AddWithValue("@LicenseClass", licenseClass);
                        cmd.Parameters.AddWithValue("@IssueDate", issueDate);
                        cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                        cmd.Parameters.AddWithValue("@PaidFees", paidFees);
                        cmd.Parameters.AddWithValue("@IsActive", isActive);
                        cmd.Parameters.AddWithValue("@IssueReason", issueReason);
                        cmd.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedLicneseID))
                            LicneseID = InsertedLicneseID;        
                        
                    }
                }
                catch
                {
                    LicneseID = -1;
                }
              
            }
            return LicneseID;
        }

        public static bool UpdateLicense(int licenseID, byte licenseClass,string Notes, DateTime expirationDate, float paidFees, bool isActive, byte issueReason)
        {
            bool updated = false;
            string query = @"
            UPDATE Licenses 
            SET LicenseClass = @LicenseClass,Notes = @Notes ExpirationDate = @ExpirationDate, PaidFees = @PaidFees, IsActive = @IsActive, IssueReason = @IssueReason
            WHERE LicenseID = @LicenseID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@LicenseID", licenseID);
                        cmd.Parameters.AddWithValue("@LicenseClass", licenseClass);
                        cmd.Parameters.AddWithValue("@ExpirationDate", expirationDate);
                        cmd.Parameters.AddWithValue("@PaidFees", paidFees);
                        cmd.Parameters.AddWithValue("@IsActive", isActive);
                        cmd.Parameters.AddWithValue("@IssueReason", issueReason);

                        if (string.IsNullOrEmpty(Notes))
                            cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@Notes", Notes);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        updated = (rowsAffected > 0);
                    }
                }
                catch 
                {
                    updated =  false;
                }
            }
            return updated;
        }

       
        public static bool DeleteLicense(int licenseID)
        {
            bool deleted = false;
            string query = "DELETE FROM Licenses WHERE LicenseID = @LicenseID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@LicenseID", licenseID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        deleted = (rowsAffected > 0);
                    }
                }
                catch 
                {
                    deleted = false;
                }
            }
            return deleted;
        }


        public static bool FindLicenseByID(int licenseID, ref int ApplicationID, ref int DriverID,
    ref byte licenseClass, ref DateTime IssueDate, ref string Notes,
    ref bool isActive, ref byte issueReason, ref int CreatedByUserID,ref DateTime ExpirationDate)
        {
            bool Found = false;
            string query = "SELECT * FROM Licenses WHERE LicenseID = @LicenseID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@LicenseID", licenseID);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read()) 
                            {
                                ApplicationID = (int)dr["ApplicationID"];
                                DriverID = (int)dr["DriverID"];
                                licenseClass =Convert.ToByte(dr["LicenseClass"]);
                                IssueDate = (DateTime)dr["IssueDate"];
                                Notes = dr["Notes"] != DBNull.Value ? (string)dr["Notes"] : string.Empty;
                                isActive = Convert.ToBoolean(dr["IsActive"]);
                                issueReason = (byte)dr["IssueReason"];
                                CreatedByUserID = (int)dr["CreatedByUserID"];
                                ExpirationDate =(DateTime)dr["ExpirationDate"];

                                Found = true; 
                            }
                        }
                    }
                }
                catch 
                {
                    Found = false;
                }
            }

            return Found; 
        }

        static public DataTable GetAllDriverLicense(int DriverID)
        {
            DataTable dtAllLicense = new DataTable();
            string Query = @"Select LicenseID,ApplicationID,LicenseClasses.ClassName,Cast(IssueDate as Date) as IssueDate,CAST(ExpirationDate AS DATE) AS ExpirationDate ,IsActive from Licenses
                          inner join LicenseClasses on Licenses.LicenseClass = LicenseClasses.LicenseClassID where DriverID = @DriverID
                           order by IssueDate desc";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {
                try
                {

                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(Query, connection))
                    {
                        cmd.Parameters.AddWithValue("@DriverID", DriverID);

                        using (SqlDataReader reader  = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtAllLicense.Load(reader);
                        }


                    }
                }
                catch { }

                return dtAllLicense;
            }

            
        }

        public static DataTable GetAllLicense()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Licenses Order by IssueDate desc";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            dt.Load(dr);
                        }
                    }
                }
                catch {}

            }
            return dt;
        }

        public static bool DeactivateLicense(int LicenseID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string query = @"UPDATE Licenses
                           SET  IsActive = 0 WHERE LicenseID=@LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch{ }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID)
        {
            int LicenseID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string query = @"SELECT LicenseID
                            FROM Licenses INNER JOIN
                            Drivers ON Licenses.DriverID = Drivers.DriverID
                            WHERE  Licenses.LicenseClass = @LicenseClass AND Drivers.PersonID = @PersonID And IsActive=1;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int FoundID))
                {
                    LicenseID = FoundID;
                }
            }

            catch 
            {
            
            }

            finally
            {
                connection.Close();
            }


            return LicenseID;
        }

       

    }
}
