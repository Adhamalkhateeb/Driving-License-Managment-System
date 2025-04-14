using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsApplicationData
    {
        static public bool FindApplicationByID(int AppID, ref int PersonID, ref int AppTypeID, ref int UserID, ref DateTime AppDate,
            ref DateTime LastStatusDate, ref byte AppStatus, ref float PaidFees)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = "Select * from Applications where ApplicationID = @AppID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@AppID", AppID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["ApplicantPersonID"];
                    AppDate = (DateTime)reader["ApplicationDate"];
                    AppTypeID = (int)reader["ApplicationTypeID"];
                    AppStatus = (Byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    UserID = (int)reader["CreatedByUserID"];

                    reader.Close();
                }

            }
            catch(Exception ex) { 
                IsFound = false;
                if(!EventLog.SourceExists(clsDataAccessSettings.ErrorSource))
                {
                    EventLog.CreateEventSource(clsDataAccessSettings.ErrorSource, "Application");
                }

                EventLog.WriteEntry(clsDataAccessSettings.ErrorSource,ex.Message, EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return IsFound;
        }

        public static DataTable GetAllApplications()
        {
            DataTable _dtAllApplications = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = "Select * from Applications order by ApplicationDate desc";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    _dtAllApplications.Load(reader);

                reader.Close();

            }
            catch (Exception ex) 
            {
                if (!EventLog.SourceExists(clsDataAccessSettings.ErrorSource))
                {
                    EventLog.CreateEventSource(clsDataAccessSettings.ErrorSource, "Application");
                }

                EventLog.WriteEntry(clsDataAccessSettings.ErrorSource, ex.Message, EventLogEntryType.Error);

            }
            finally
            {
                connection.Close();
            }

            return _dtAllApplications;
        }

        public static int AddNewApplication(int PersonID, int AppTypeID, int UserID, DateTime AppDate, DateTime LastStatusDate, byte AppStatus, float PaidFees)
        {
            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = @"Insert into Applications (ApplicantPersonID,ApplicationTypeID,CreatedByUserID,ApplicationDate,LastStatusDate,ApplicationStatus,PaidFees)
                Values (@PersonID,@AppTypeID,@UserID,@AppDate,@LastStatusDate,@AppStatus,@PaidFees);
                 Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@AppTypeID", AppTypeID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@AppDate", AppDate);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@AppStatus", AppStatus);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedAppID))
                    ApplicationID = InsertedAppID;
            }
            catch(Exception ex) {
                if (!EventLog.SourceExists(clsDataAccessSettings.ErrorSource))
                {
                    EventLog.CreateEventSource(clsDataAccessSettings.ErrorSource, "Application");
                }

                EventLog.WriteEntry(clsDataAccessSettings.ErrorSource, ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return ApplicationID;
        }

        public static bool UpdateApplication(int ApplicationID, int PersonID, int UserID, int ApplicationTypeID,
            DateTime ApplicationDate, DateTime LastStatusDate, byte ApplicationStatus, float PaidFees)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"Update Applications set ApplicantPersonID = @PersonID, ApplicationTypeID = @AppTypeID, CreatedByUserID = @UserID,
                ApplicationDate = @AppDate, LastStatusDate = @LastStatusDate, ApplicationStatus = @AppStatus, PaidFees = @PaidFees
                where ApplicationID = @AppID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@AppTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@AppDate", ApplicationDate);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@AppStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@AppID", ApplicationID);
            try
            {
                connection.Open();
                int AffectedRows = command.ExecuteNonQuery();
                if (AffectedRows > 0)
                    IsUpdated = true;
            }
            catch (Exception ex) { IsUpdated = false;
                if (!EventLog.SourceExists(clsDataAccessSettings.ErrorSource))
                {
                    EventLog.CreateEventSource(clsDataAccessSettings.ErrorSource, "Application");
                }

                EventLog.WriteEntry(clsDataAccessSettings.ErrorSource, ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }
            return IsUpdated;
        }

        public static bool DeleteApplication(int ApplicationID)
        {

            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string query = @"Delete Applications 
                                where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                if (!EventLog.SourceExists(clsDataAccessSettings.ErrorSource))
                {
                    EventLog.CreateEventSource(clsDataAccessSettings.ErrorSource, "Application");
                }

                EventLog.WriteEntry(clsDataAccessSettings.ErrorSource, ex.Message, EventLogEntryType.Error);
            }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }

        public static bool IsApplicationExist(int ApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string query = "SELECT Found=1 FROM Applications WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                
                isFound = false;
                if (!EventLog.SourceExists(clsDataAccessSettings.ErrorSource))
                {
                    EventLog.CreateEventSource(clsDataAccessSettings.ErrorSource, "Application");
                }

                EventLog.WriteEntry(clsDataAccessSettings.ErrorSource, ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int GetActiveApplicationID(int PersonID, int ApplicationTypeID)
        {
            int ActiveApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string query = "SELECT ActiveApplicationID = ApplicationID FROM Applications WHERE ApplicantPersonID = @ApplicantPersonID and ApplicationTypeID=@ApplicationTypeID and ApplicationStatus = 1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ActiveApplicationID = AppID;
                }
            }
            catch (Exception ex)
            {

                ActiveApplicationID = -1;
                if (!EventLog.SourceExists(clsDataAccessSettings.ErrorSource))
                {
                    EventLog.CreateEventSource(clsDataAccessSettings.ErrorSource, "Application");
                }

                EventLog.WriteEntry(clsDataAccessSettings.ErrorSource, ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return ActiveApplicationID;
        }

        public static bool DoesPersonHaveActiveApplication(int PersonID, int ApplicationTypeID)
        {

            return (GetActiveApplicationID(PersonID, ApplicationTypeID) != -1);
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, int ApplicationTypeID, int LicenseClassID)
        {
            int ActiveApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string query = @"SELECT ActiveApplicationID=Applications.ApplicationID  
                            From
                            Applications INNER JOIN
                            LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                            WHERE ApplicantPersonID = @ApplicantPersonID 
                            and ApplicationTypeID=@ApplicationTypeID 
							and LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                            and ApplicationStatus = 1";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();


                if (result != null && int.TryParse(result.ToString(), out int AppID))
                {
                    ActiveApplicationID = AppID;
                }
            }
            catch (Exception ex)
            {
                ActiveApplicationID = -1;
                if (!EventLog.SourceExists(clsDataAccessSettings.ErrorSource))
                {
                    EventLog.CreateEventSource(clsDataAccessSettings.ErrorSource, "Application");
                }

                EventLog.WriteEntry(clsDataAccessSettings.ErrorSource, ex.Message, EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }

            return ActiveApplicationID;
        }

        public static bool UpdateStatus(int ApplicationID, short NewStatus)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string query = @"Update  Applications  
                            set 
                                ApplicationStatus = @NewStatus, 
                                LastStatusDate = @LastStatusDate
                            where ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@NewStatus", NewStatus);
            command.Parameters.AddWithValue("LastStatusDate", DateTime.Now);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                rowsAffected =0;
                if (!EventLog.SourceExists(clsDataAccessSettings.ErrorSource))
                {
                    EventLog.CreateEventSource(clsDataAccessSettings.ErrorSource, "Application");
                }

                EventLog.WriteEntry(clsDataAccessSettings.ErrorSource, ex.Message, EventLogEntryType.Error);
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

    }
}
