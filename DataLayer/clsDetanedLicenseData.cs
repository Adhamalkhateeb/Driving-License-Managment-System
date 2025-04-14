using Azure.Core;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsDetanedLicenseData
    {
        static public bool GetDetainedLicenseInfoByDetainID(int DetainID,ref int LicenseID , ref DateTime DetainDate,ref float FineFees, ref bool IsReleased,
            ref int CreatedByUserID,ref DateTime ReleasedDate, ref int ReleasedByUserID,ref int ReleaseApplicationID,ref string Notes)
        {
            bool Found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = "Select * from DetainedLicenses where DetainID = @DetainID and IsReleased = 0";
            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@DetainID",DetainID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    LicenseID = (int)reader["LicenseID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = Convert.ToSingle(reader["FineFees"]);
                    IsReleased = (bool)reader["IsReleased"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

                    ReleasedDate = reader["ReleaseDate"] == DBNull.Value ? DateTime.Now : (DateTime)reader["ReleaseDate"];
                    ReleasedByUserID = reader["ReleasedByUserID"] == DBNull.Value ? -1 : (int)reader["ReleasedByUserID"];
                    ReleaseApplicationID = reader["ReleaseApplicationID"] == DBNull.Value ? -1 : (int)reader["ReleaseApplicationID"];
                    Notes = reader["Notes"] == DBNull.Value ? string.Empty : (string)reader["Notes"];

                    Found = true;
                    reader.Close();
                }
            } catch  { Found = false; }
            finally { connection.Close(); }

            return Found;
        }

        static public bool GetDetainedLicenseInfoByLicenseID(int LicenseID, ref int DetainID, ref DateTime DetainDate, ref float FineFees, ref bool IsReleased,
            ref int CreatedByUserID, ref DateTime ReleasedDate, ref int ReleasedByUserID, ref int ReleaseApplicationID,ref string Notes)
        {
            bool Found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = "Select * from DetainedLicenses where LicenseID = @LicenseID and IsReleased = 0";
            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    DetainID = (int)reader["DetainID"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    FineFees = Convert.ToSingle(reader["FineFees"]);
                    IsReleased = (bool)reader["IsReleased"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    ReleasedDate = reader["ReleaseDate"] == DBNull.Value ? DateTime.MinValue: (DateTime)reader["ReleaseDate"];
                    ReleasedByUserID = reader["ReleasedByUserID"] == DBNull.Value ? -1 : (int)reader["ReleasedByUserID"];
                    ReleaseApplicationID = reader["ReleaseApplicationID"] == DBNull.Value ? -1 : (int)reader["ReleaseApplicationID"];
                    Notes = reader["Notes"] == DBNull.Value ? string.Empty : (string)reader["Notes"];


                    Found = true;
                    reader.Close();
                }
            }
            catch { Found = false; }
            finally { connection.Close(); }

            return Found;
        }

        static public int AddNewDetainLicense( int LicenseID,  DateTime DetainDate,  float FineFees,  bool IsReleased,
             int CreatedByUserID,  DateTime ReleasedDate,  int ReleasedByUserID,  int ReleaseApplicationID ,string Notes)
        {
            int DetainID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"insert into DetainedLicenses (LicenseID,DetainDate,FineFees,CreatedByUserID,IsReleased,ReleaseDate,ReleasedByUserID,ReleaseApplicationID,Notes)
                            values (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, @IsReleased, @ReleaseDate, @ReleasedByUserID, @ReleaseApplicationID,@Notes);
                            Select SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@DetainDate", DetainDate );
            cmd.Parameters.AddWithValue("@FineFees", FineFees);
            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            if(ReleasedDate == DateTime.MinValue)
                cmd.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@ReleaseDate", ReleasedDate);

            if(ReleasedByUserID == -1)
                cmd.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);

            if(ReleaseApplicationID == -1)
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

            if(string.IsNullOrEmpty(Notes))
                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@Notes",Notes);


            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedDetainID))
                    DetainID = InsertedDetainID;
            }
            catch { DetainID = -1; }
            finally { connection.Close(); }

            return DetainID;

        }

        static public bool UpdateDetainedLicense(int DetainID,int LicenseID, DateTime DetainDate, float FineFees, bool IsReleased,
             int CreatedByUserID, DateTime ReleasedDate, int ReleasedByUserID, int ReleaseApplicationID,string Notes)
        {
            bool Updated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"update DetainedLicenses set LicenseID = LicenseID ,  DetainDate = DetainDate, 
				FineFees = FineFees ,CreatedByUserID =  CreatedByUserID, IsReleased = IsReleased,
			  ReleaseDate = ReleaseDate, ReleasedByUserID = ReleasedByUserID, ReleaseApplicationID = ReleaseApplicationID , Notes = @Notes
			  where DetainID = DetainDate;";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@DetainID", DetainID);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
            cmd.Parameters.AddWithValue("@FineFees", FineFees);
            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            if (ReleasedDate == DateTime.MinValue)
                cmd.Parameters.AddWithValue("@ReleasedDate", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@ReleasedDate", ReleasedDate);

            if (ReleasedByUserID == -1)
                cmd.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);

            if (ReleaseApplicationID == -1)
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

            if (string.IsNullOrEmpty(Notes))
                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@Notes", Notes);

            try
            {
                connection.Open();
                
                if(cmd.ExecuteNonQuery() > 0)
                    Updated = true;

                
            }
            catch { Updated = false;  }
            finally { connection.Close(); }

            return Updated;
        }

        static public bool DeleteDetainLicense(int DetainID)
        {
            bool Deleted = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = "Delete From DetainedLicenses where DetainID = @DetainID";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@DetainID", DetainID);

            try
            {
                connection.Open();
                if (cmd.ExecuteNonQuery() > 0)
                    Deleted = true;
            }catch { Deleted = false; }
            finally { connection.Close(); }

            return Deleted;
        }

        static public DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"select DetainID,DetainedLicenses.LicenseID,DetainDate, IsReleased ,FineFees ,ReleaseDate, NationalNo ,
                CONCAT(FirstName,' ',SecondName,' ', ISNULL(ThirdName,''),' ',LastName) as FullName , ReleaseApplicationID from DetainedLicenses
                 left join Licenses on DetainedLicenses.LicenseID = Licenses.LicenseID inner join Drivers on Drivers.DriverID = Licenses.DriverID
                    inner join People on People.PersonID = Drivers.PersonID order by IsReleased Asc ;";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();

            }
            catch { }
            finally { connection.Close(); }

            return dt;
        }

        static public bool IsLicenseDetained(int LicenseID)
        {
            bool Detained = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = "Select Found = 1 from DetainedLicenses where LicenseID =  @LicenseID and IsReleased = 0";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();
                if(Result!= null && int.TryParse(Result.ToString(),out int ISDetained ))
                {
                    if (ISDetained > 0)
                        Detained = true;
                }
            }
            catch (Exception ex) { Detained = false; }
            finally { connection.Close(); }

            return Detained;
        }

        static public bool ReleaseDetainedLicense(int DetainID, int ReleasedByUserID, int ReleaseApplicationID)
        {
            bool released = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"update DetainedLicenses set IsReleased = 1 ,  ReleaseDate = @ReleaseDate,
		ReleasedByUserID = @ReleasedByUserID ,ReleaseApplicationID = @ReleaseApplicationID
		where DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            command.Parameters.AddWithValue("ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseDate",DateTime.Now);

            try
            {
                connection.Open();

                if (command.ExecuteNonQuery() > 0)
                    released = true;
            }
            catch (Exception ex) { released = false; }
            finally { connection.Close(); }

            return released;
        }
    }
}
