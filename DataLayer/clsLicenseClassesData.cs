using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsLicenseClassesData
    {

        static public bool GetLicenseClassInfo(int LicenseClassID, ref string ClassName, ref string ClassDescription, ref byte MinimumAllowedAge,
            ref byte DefaultValidityLiength, ref float ClassFees)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = "SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    ClassName = (string)reader["ClassName"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = Convert.ToByte(reader["MinimumAllowedAge"]);
                    DefaultValidityLiength = Convert.ToByte(reader["DefaultValidityLength"]);
                    ClassFees = Convert.ToSingle(reader["ClassFees"]);

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        static public bool GetLicenseClassInfo(string LicenseClassName, ref int LicenseClassID, ref string ClassDescription, ref byte MinimumAllowedAge,
    ref byte DefaultValidityLiength, ref float ClassFees)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = "SELECT * FROM LicenseClasses WHERE ClassName = @ClassName";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ClassName", LicenseClassName);
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;

                    LicenseClassID = (int)reader["LicenseClassID"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = Convert.ToByte(reader["MinimumAllowedAge"]);
                    DefaultValidityLiength = Convert.ToByte(reader["DefaultValidityLength"]);
                    ClassFees = Convert.ToSingle(reader["ClassFees"]);

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        static public DataTable GetAllClasses()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = "SELECT * FROM LicenseClasses";

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

        static public bool UpdateClassInfo(int ClassID, string ClassName, string ClassDescription, byte MinmumAge, byte ValidityLength, float classFess)
        {
            bool IsUpdated = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"UPDATE LicenseClasses SET 
                                     ClassName = @ClassName, ClassDescription = @ClassDescription,
                                     MinimumAllowedAge = @MinimumAllowedAge, DefaultValidityLength = @DefaultValidityLength,
                                     ClassFees = @ClassFees 
                                     WHERE LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", MinmumAge);
            command.Parameters.AddWithValue("@DefaultValidityLength", ValidityLength);
            command.Parameters.AddWithValue("@ClassFees", classFess);
            command.Parameters.AddWithValue("@LicenseClassID", ClassID);

            try
            {
                connection.Open();

                if (command.ExecuteNonQuery() > 0)
                    IsUpdated = true;


            } catch (Exception ex)
            {
                IsUpdated = false;
            }
            finally
            {
                connection.Close();
            }

            return IsUpdated;
        }
        


        static public int AddNewClass(string ClassName, string ClassDescription, byte MinmumAge, byte ValidityLength, float classFess)
        {
            int ClassID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = @"INSERT INTO LicenseClasses (ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees)
                             VALUES (@ClassName, @ClassDescription, @MinimumAllowedAge, @DefaultValidityLength, @ClassFees);
                             SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", MinmumAge);
            command.Parameters.AddWithValue("@DefaultValidityLength", ValidityLength);
            command.Parameters.AddWithValue("@ClassFees", classFess);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertClassID))
                    ClassID = InsertClassID;
            }
            catch (Exception ex)
            {
                ClassID = -1;
            }
            finally
            {
                connection.Close();
            }
            return ClassID;
        }
    }
}
