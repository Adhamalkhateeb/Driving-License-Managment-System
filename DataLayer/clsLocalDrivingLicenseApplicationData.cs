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
    public class clsLocalDrivingLicenseApplicationData
    {
        static public DataTable RetrieveAllLocalDrivingLicenseApplications()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"SELECT * from LocalDrivingLicenseApplications_View order by ApplicationDate desc;";

            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);

                reader.Close();


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        static public bool GetLocalDrivingLicenseApplicationInfoByLDL_AppID(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool Found = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"SELECT * from LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];

                    Found = true;

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Found = false;
            }
            finally
            {
                connection.Close();
            }

            return Found;
        }

        static public bool GetLocalDrivingLicenseApplicationInfoByApplicationID(int ApplicationID,ref int LocalDrivingLicenseApplicationID,ref int LicenseClassID)
        {
            bool Found = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"SELECT * WHERE ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];

                    Found = true;

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Found = false;
            }
            finally
            {
                connection.Close();
            }

            return Found;
        }

        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {
            int InsertedLocalAppID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"INSERT INTO LocalDrivingLicenseApplications (ApplicationID,LicenseClassID) VALUES (@ApplicationID,@LicenseClassID);
                            Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedLDLAppID))
                    InsertedLocalAppID = InsertedLDLAppID;

            }
            catch (Exception ex)
            {
                InsertedLocalAppID = -1;
            }
            finally
            {
                connection.Close();
            }
            return InsertedLocalAppID;
        }

        static public bool UpdateLocalDrivngLicenseApplication(int LocalDrivingApplicationID, int ApplicationID, int LicenseClassID)
        {
            bool Updated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"UPDATE LocalDrivingLicenseApplications SET
                        ApplicationID = @ApplicationID, LicenseClassID = @LicenseClassID
                           WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingApplicationID);

            try
            {
                connection.Open();

                if (command.ExecuteNonQuery() > 0)
                    Updated = true;


            }
            catch (Exception ex)
            {
                Updated = false;
            }
            finally
            {
                connection.Close();
            }

            return Updated;
        }

        static public bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            bool Deleted = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                connection.Open();
                if (command.ExecuteNonQuery() > 0)
                    Deleted = true;


            }
            catch { }
            finally
            {
                connection.Close();
            }

            return Deleted;
        }

        static public bool IsTestPassedBefore(int LocalDrivingLicenseID, int TestTypeID)
        {
            bool Passed = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"Select Found =1 from  TestAppointments inner join Tests on 
                        TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                        where TestResult = 1 and LocalDrivingLicenseApplicationID = @LocalDrivingLicenseID and TestTypeID =@TestTypeID ;";

            SqlCommand command = new SqlCommand(Query, connection); ;


            command.Parameters.AddWithValue("@LocalDrivingLicenseID", LocalDrivingLicenseID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    Passed = true;

                reader.Close();
            }
            catch (Exception)
            {
                Passed = false;
            }
            finally
            {
                connection.Close();
            }
            return Passed;
        }

        public static bool DoesAttendTest(int LocalDrivingLicenseApplicationID, int TestTypeID)

        {


            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string query = @" SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
              

            }

            finally
            {
                connection.Close();
            }

            return IsFound;

        }

        static public byte GetNumberOfTrialsForTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            byte TotalTrialsPerTest = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @" SELECT TotalTrialsPerTest = count(TestID)
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                 Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                            AND(TestAppointments.TestTypeID = @TestTypeID)";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte Trials))
                {
                    TotalTrialsPerTest = Trials;
                }


            }
            catch { TotalTrialsPerTest = 0; }
            finally { connection.Close(); }

            return TotalTrialsPerTest;
        }

        static public bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseID, int TestTypeID)
        {
            bool IsActive = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)  
                            AND(TestAppointments.TestTypeID = @TestTypeID) and isLocked = 0
                            ORDER BY TestAppointments.TestAppointmentID desc";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                

                object result = command.ExecuteScalar();


                if (result != null)
                {
                    IsActive = true;
                }


            }
            catch { IsActive = false; }
            finally { connection.Close(); }

            return IsActive;
        }

        

    }
}
