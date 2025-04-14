using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsCountriesDataLayer
    {
        public static DataTable GetAllCountries()
        {
            DataTable dataTable = new DataTable("Countries");

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = " Select * from Countries order by CountryName";

            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dataTable.Load(reader);

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

            return dataTable;
        }

        static public bool FindCountry(int CountryId,ref string CountryName)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = "Select *  from Countries where CountryID = @CountryID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@CountryID", CountryId);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CountryName = (string)reader["CountryName"];
                    isFound = true;
                }

                    
            }
            catch (Exception ex){ isFound = false;
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

        static public bool FindCountry(string CountryName,ref int CountryID)
        {
            bool found = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = "Select * from Countries where CountryName = @CountryName";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();

                SqlDataReader reader =  command.ExecuteReader();

                if (reader.Read())
                {
                    found = true;
                    CountryID = (int)reader["CountryID"];
                }


            }
            catch (Exception ex) { found = false;
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

            return found;

        }
    }
}
