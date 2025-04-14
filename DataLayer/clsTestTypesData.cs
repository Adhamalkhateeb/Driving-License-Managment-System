using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public  class clsTestTypesData
    {

        static public DataTable GetAllTestTypes()
        {
            DataTable dtAllTestTypes = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = "Select * from TestTypes;";

            SqlCommand Command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                    dtAllTestTypes.Load(reader);

                reader.Close();
            }
            catch
            {

            }
            finally { connection.Close(); }

            return dtAllTestTypes;
        }

        static public bool GetTestTypeInfo(int TestID,ref string TestTitle,ref string TestDescription , ref float TestFees)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = "Select * from TestTypes where TestTypeID = @TestID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    IsFound = true;

                    TestTitle = (string)reader["TestTypeTitle"];
                    TestDescription = (string)reader["TestTypeDescription"];
                    TestFees = Convert.ToSingle(reader["TestTypeFees"]);


                    reader.Close();

                }
            }
            catch { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool UpdateTestInfo(int TestID,string TestTitle,string TestDescription,float TestFees)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"Update TestTypes 
                            set TestTypeTitle = @TestTitle,
                                TestTypeDescription = @TestDescription,
                                TestTypeFees = @TestFees
                                where TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestTitle", TestTitle);
            command.Parameters.AddWithValue("@TestDescription", TestDescription);
            command.Parameters.AddWithValue("@TestFees", TestFees);
            command.Parameters.AddWithValue("@TestTypeID", TestID);

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();

                if (result >0)
                    IsUpdated = true;


            }
            catch { IsUpdated = false; }
            finally { connection.Close(); }

            return IsUpdated;

        }

        public static int AddNewTestType(string TestTitle,string TestDescription,float TestFees)
        {
            int TestID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"insert into TestTypes (TestTypeTitle,TestTypeDescription,TestTypeFees) 
                            Values  (@TestTypeTitle,@TestTypeDescription,@TestTypeFees);
                            Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TestTitle", TestTitle);
            command.Parameters.AddWithValue("@TestDescription", TestDescription);
            command.Parameters.AddWithValue("@TestFees", TestFees);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                    TestID = InsertedID;

            }
            catch { }
            finally { connection.Close(); }

            return TestID;
        }

    }
}
