using System.ComponentModel.Design;
using System.Data;
using System.IO.IsolatedStorage;
using System.Text;
using Azure.Core;
using Microsoft.Data.SqlClient;
namespace DataLayer
{

    public class clsPeopleDataLayer
    {

       static public DataTable GetAllPeople()
        {
            DataTable datatable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string query =
               @"SELECT PersonID, NationalNo, FirstName, SecondName,  ThirdName, LastName,
			  DateOfBirth, Gendor =
				  CASE
                  WHEN People.Gendor = 0 THEN 'M'

                  ELSE 'F'

                  END ,
			  Address, Phone, Email, 
              NationalityCountryID, CountryName, ImagePath
              FROM   People INNER JOIN Countries 
               ON People.NationalityCountryID = Countries.CountryID
                ORDER BY People.FirstName";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    datatable.Load(reader);
                }
                reader.Close();
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }
            return datatable;
        }

        static public bool IsPersonExist(string NationalNo)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = "Select R=1 from People where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                IsFound = reader.HasRows;
                reader.Close();
            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        static public bool IsPersonExist(int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = "Select R=1 from People where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                IsFound = reader.HasRows;
                reader.Close();
            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static  bool GetPersonInfoByID(int PersonID,ref string NationalNumber, ref string FirstName, ref string SecondName, ref string ThirdName,
            ref string lastName, ref DateTime DateOfBirth,ref  byte Gendor, ref string Address, ref string Phone,
            ref string Email, ref int NationalCountryID, ref string ImagePath)
        {

            bool IsFound = false ;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string query = "Select * from People Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    IsFound = true;

                    NationalNumber = (string)reader["NationalNo"];
                    FirstName = (string)reader["FirstName"];
                    SecondName= (string)reader["SecondName"];

                    if (reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)reader["ThirdName"];
                    else
                        ThirdName = string.Empty;

                    lastName = (string)reader["lastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = Convert.ToByte(reader["Gendor"]);
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = string.Empty;   
                    
                    NationalCountryID = (int)reader["NationalityCountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                  

                    reader.Close();
                }

            }
            catch(Exception ex)
            { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool GetPersonInfoByNationalNo( string NationalNumber, ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName,
            ref string lastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address, ref string Phone,
            ref string Email, ref int NationalCountryID, ref string ImagePath)
        {

            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string query = "Select * from People Where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName= (string)reader["SecondName"];
                    if (reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)reader["ThirdName"];
                    else
                        ThirdName = string.Empty;
                    lastName = (string)reader["lastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = Convert.ToByte(reader["Gendor"]);
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = string.Empty;
                    NationalCountryID = (int)reader["NationalityCountryID"];
                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];


                    reader.Close();
                }

            }
            catch (Exception ex)
            { IsFound = false; }
            finally { connection.Close(); }

            return IsFound;
        }

        public static int AddNewPerson(string NationalNumber,  string FirstName,  string SecondName,  string ThirdName,
             string lastName,  DateTime DateOfBirth,  byte Gendor,  string Address,  string Phone,
             string Email,  int NationalCountryID,  string ImagePath)
        {
            int PersonID = -1;
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = @"INSERT INTO People (NationalNo,FirstName,SecondName,ThirdName,LastName,DateOfBirth,Gendor,Address,
                                          Phone,Email,NationalityCountryID,ImagePath)     
                                            VALUES(@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth, 
                                            @Gendor,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath);
                                            Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNumber);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);

            if(string.IsNullOrEmpty(ThirdName))
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ThirdName", ThirdName);

            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if (string.IsNullOrEmpty(ThirdName))
                command.Parameters.AddWithValue("@Email", DBNull.Value);
            else
                command.Parameters.AddWithValue("@Email", Email);

            command.Parameters.AddWithValue("@NationalityCountryID", NationalCountryID);

            if (string.IsNullOrEmpty(ImagePath))
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(),out int InsertedID))
                    PersonID = InsertedID;
            }
            catch { }
            finally
            { connection.Close(); }

            return PersonID;
          

        }

        public static bool UpdatePerson(int PersonID,string NationalNo,string FirstName,string SecondName,
            string ThirdName,string LastName,DateTime DateOfBirth,byte Gendor,string Address,string Phone,string Email,
            int NationalCountryID,string ImagePath)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = @"Update People set NationalNo = @NationalNo, FirstName = @FirstName, SecondName = @SecondName,
                             ThirdName = @ThirdName, LastName = @LastName , DateOfBirth = @DateOfBirth , Gendor = @Gendor
                             ,Address = @Address, Email = @Email, Phone = @Phone, NationalityCountryID = @NationalityCountryID,
                             ImagePath = @ImagePath where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName",FirstName);
            command.Parameters.AddWithValue("SecondName",SecondName);

            if(ThirdName != string.Empty) 
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
               else
                command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);

            if(Email != string.Empty)
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", DBNull.Value);

            command.Parameters.AddWithValue("@NationalityCountryID", NationalCountryID);

            if(ImagePath != string.Empty)
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            try
            {
                connection.Open();
               int result =  command.ExecuteNonQuery();
                if(result> 0)
                    IsUpdated = true;
            }
            catch (Exception)
            {

                IsUpdated = false;
            }
            finally { connection.Close(); }

            return IsUpdated;


        }

        public static bool DeletePerson(int personID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = "Delete from People where PersonID = @PersonID";

            SqlCommand command =new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();

                if (result> 0)
                    IsDeleted = true;

            }
            catch (Exception) { IsDeleted = false; }
            finally { connection.Close(); }

            return IsDeleted;
        }
    }

   
}
