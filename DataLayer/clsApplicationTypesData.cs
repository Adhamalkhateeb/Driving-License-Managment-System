using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsApplicationTypesData
    {

        public static DataTable GetAllApplicationsTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = "Select * from ApplicationTypes";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();


            }
            catch (Exception ex){
                if (!EventLog.SourceExists(clsDataAccessSettings.ErrorSource))
                {
                    EventLog.CreateEventSource(clsDataAccessSettings.ErrorSource, "Application");
                }

                EventLog.WriteEntry(clsDataAccessSettings.ErrorSource, ex.Message, EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return dt;
        }

        static public bool GetApplicationTypeInfo(int ApplicationID , ref string ApplicationTitle,ref float ApplicationFees)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = "Select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    IsFound = true;

                    ApplicationTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = Convert.ToSingle(reader["ApplicationFees"]);

                    reader.Close();
                }
                
            }
            catch(Exception ex){
                if (!EventLog.SourceExists(clsDataAccessSettings.ErrorSource))
                {
                    EventLog.CreateEventSource(clsDataAccessSettings.ErrorSource, "Application");
                }

                EventLog.WriteEntry(clsDataAccessSettings.ErrorSource, ex.Message, EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return IsFound;
        }

        static public bool UpdateApplicationTypeInfo(int ApplicationID,string ApplicationTypeTitle,float ApplicationFees)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"Update  ApplicationTypes
                           set [ApplicationTypeTitle] = @ApplicationTypeTitle,
                               [ApplicationFees] = @ApplicationFees
                            where ApplicationTypeID = @ApplicationTypeID";
            SqlCommand command = new SqlCommand(Query,connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

            try
            {
                connection.Open();

                int result = command.ExecuteNonQuery();

                if (result > 0)
                    IsUpdated =true;
            }
            catch (Exception ex){ IsUpdated = false;
                if (!EventLog.SourceExists(clsDataAccessSettings.ErrorSource))
                {
                    EventLog.CreateEventSource(clsDataAccessSettings.ErrorSource, "Application");
                }

                EventLog.WriteEntry(clsDataAccessSettings.ErrorSource, ex.Message, EventLogEntryType.Error);
            }
            finally { connection.Close(); }

            return IsUpdated;
        }
    }
}
