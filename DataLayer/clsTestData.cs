using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsTestData
    {
        static public bool GetTestInfoByID(int TestID, ref int TestAppointmentID, ref int CreatedByUserID, ref bool PassedTest, ref string Notes)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = "Select * from Tests where TestID = @TestID";

            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    TestAppointmentID =(int)reader["TestAppointmentID"];
                    CreatedByUserID =(int)reader["CreatedByUserID"];
                    PassedTest = (bool)reader["TestResult"];
                    if (reader["Notes"] == DBNull.Value)
                        Notes = string.Empty;
                    else
                        Notes = (string)reader["Notes"];



                    reader.Close();
                }

            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        static public DataTable GetAllTests()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = "Select * from Tests";

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

        static public int AddNewTest(int TestAppointmentID,int CreatedByUserID,bool IsPassed,string Notes )
        {
            int TestID = -1;

            SqlConnection connection = new SqlConnection( clsDataAccessSettings.Connectionstring);

            string Query = @"Insert into Tests (TestAppointmentID,CreatedByUserID,TestResult,Notes)
                             Values (@TestAppointmentID,@CreatedByUserID,@TestResult,@Notes);
                              Update TestAppointments SET 
                              IsLocked = 1
                               WHERE TestAppointmentID = @TestAppointmentID;
                            Select Scope_IDENTITY();";


            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            if(string.IsNullOrEmpty(Notes))
                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@Notes", Notes);
            if (IsPassed)
                cmd.Parameters.AddWithValue("@TestResult", 1);
            else
                cmd.Parameters.AddWithValue("@TestResult", 0);
           
            try
            {
                connection.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedTestID))
                    TestID = InsertedTestID;
            }
            catch { TestID = -1; }
            finally { connection.Close(); }

            return TestID;
        }

        static public bool UpdateTestInfo(int TestID,int TestAppointmentID, int CreatedByUserID, bool IsPassed, string Notes)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"Update Tests set TestAppointmentID = @TestAppointmentID,
                                  CreatedByUserID = @CreatedByUserID, TestResult = @IsPassed,Notes = @Notes
                                     where TestID = @TestID";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsPassed", IsPassed);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();

                if(command.ExecuteNonQuery() > 0)
                    IsUpdated = true;
            }
            catch (Exception)
            {

                IsUpdated = false;
            }
            finally { connection.Close(); }

            return IsUpdated;
        }

        static public bool DeleteTest(int TestID)
        {
            bool Deleted = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = "Delete from Tests where TestsID = @TestID";

            SqlCommand command = new SqlCommand(Query,connection);
            command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();
                if (command.ExecuteNonQuery() > 0)
                    Deleted = true;
            }
            catch { Deleted = false; }
            finally { connection.Close(); }

            return Deleted;


        }

        static public byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {

            byte PassedTestCount = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"Select count(TestResult) from Tests inner join TestAppointments on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                                     where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestResult = 1";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && byte.TryParse(result.ToString(), out byte ptCount))
                {
                    PassedTestCount = ptCount;
                }
            }

            catch (Exception ex)
            {
               

            }

            finally
            {
                connection.Close();
            }

            return PassedTestCount;



        }
    }
    }

