using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.Intrinsics.Arm;
using System.Diagnostics;
namespace DataLayer
{
    public class clsUserDataLayer
    {
        static public DataTable GetAllUsers()
        {

            DataTable dtUser = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string query = @"SELECT Users.UserID, Users.PersonID,
                            FullName = People.FirstName + ' ' + People.SecondName + ' ' + ISNULL( People.ThirdName,'') +' ' + People.LastName,
                             Users.UserName, Users.IsActive
                             FROM  Users INNER JOIN
                                    People ON Users.PersonID = People.PersonID";


            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                    dtUser.Load(reader);
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return dtUser;
        }

        static public bool GetUserInfoByUserID(int UserID,ref int PersonID,ref string UserName,ref string Password,ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = "Select * from Users where UserID = @UserID";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];

                    reader.Close();
                }
            }
            catch (Exception)
            {

              IsFound = false;
            }
            finally { connection.Close(); }

            return IsFound;

        }

        static public bool GetUserInfoByPersonID(int PersonID , ref int UserID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = "Select * from Users where PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    UserID = (int)reader["UserID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];

                    reader.Close();
                }
            }
            catch (Exception)
            {

                IsFound = false;
            }
            finally { connection.Close(); }

            return IsFound;

        }

        static public bool GetUserInfoByUserNameandPassword(string UserName,  string Password, ref int PersonID,
            ref int UserID, ref bool IsActive)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = "Select * from Users where UserName = @UserName and Password = @Password";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonID = (int)reader["PersonID"];
                    UserID = (int)reader["UserID"];
                    IsActive = (bool)reader["IsActive"];

                    reader.Close();
                }
            }
            catch (Exception)
            {

                IsFound = false;
            }
            finally { connection.Close(); }

            return IsFound;

        }

        static public bool IsUserExistByUserName(string UserName)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = "Select Found =1  from Users where UserName = @UserName";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();


                IsFound = reader.HasRows;
                reader.Close();

            }
            catch (Exception)
            {

                IsFound = false;
            }
            finally { connection.Close(); }

            return IsFound;

        }
        static public bool IsUserExistByUserID(int UserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = "Select Found =1  from Users where UserID = @UserID";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                
                IsFound = reader.HasRows;
                reader.Close();

            }
            catch (Exception)
            {

                IsFound = false;
            }
            finally { connection.Close(); }

            return IsFound;

        }

        static public bool IsUserExistByPersonID(int PersonID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = "Select Found =1  from Users where PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(Query, connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                
                    IsFound = reader.HasRows;
                reader.Close();

            }
            catch (Exception)
            {

                IsFound = false;
            }
            finally { connection.Close(); }

            return IsFound;

        }

        static public int AddNewUser(int PersonID,string UserName,string Password,bool IsActive)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"Insert Into Users (PersonID,UserName,Password,IsActive)
                           Values (@PersonID,@UserName,@Password,@IsActive);
                           Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID",PersonID);  
            using (SHA256 sha = SHA256.Create())
            {
                byte[] HashedPass = sha.ComputeHash(Encoding.UTF8.GetBytes(Password));
                Password = BitConverter.ToString(HashedPass).Replace("-", "").ToLower();
                command.Parameters.AddWithValue("@Password", Password);
            }
           
            command.Parameters.AddWithValue("@UserName", UserName);
            if (IsActive)
                command.Parameters.AddWithValue("@IsActive", 1);
            else
                command.Parameters.AddWithValue("@IsActive", 0);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedUserID))
                    UserID = insertedUserID;
            }
            catch (Exception) { }
            finally { connection.Close(); }
            return UserID;
        }

        public static bool UpdateUser(int UserID,string UserName,string Password,bool IsActive)
        {
            bool IsUpdated = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"Update  Users set UserName = @UserName,
                           Password = @Password, IsActive = @IsActive
                           Where UserID = @UserID";

            SqlCommand command = new SqlCommand(Query, connection);


            command.Parameters.AddWithValue("userID", UserID);
            using (SHA256 sha = SHA256.Create())
            {
                byte[] HashedPass = sha.ComputeHash(Encoding.UTF8.GetBytes(Password));
                Password = BitConverter.ToString(HashedPass).Replace("-", "").ToLower();
                command.Parameters.AddWithValue("@Password", Password);
            }
            command.Parameters.AddWithValue("@UserName", UserName);
            if (IsActive)
                command.Parameters.AddWithValue("@IsActive", 1);
            else
                command.Parameters.AddWithValue("@IsActive", 0);


            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();

               if(result > 0)
                    IsUpdated = true;
                   
            }
            catch (Exception) { IsUpdated = false; }
            finally { connection.Close(); }
            return IsUpdated;

        }

        public static bool DeleteUser(int UserID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = "Delete from Users where UserID = @UserID";
            SqlCommand Command = new SqlCommand(Query, connection);

            Command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                int result = Command.ExecuteNonQuery();

                if (result > 0)
                { IsDeleted = true; }
            }
            catch (Exception) { IsDeleted = false; }
            finally { connection.Close(); }

            return IsDeleted;
        }

        public static bool ChangePassword(int UserID, string NewPassword)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string query = @"Update  Users  
                            set Password = @Password
                            where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            using (SHA256 sha = SHA256.Create())
            {
                byte[] HashedPass = sha.ComputeHash(Encoding.UTF8.GetBytes(NewPassword));
                NewPassword = BitConverter.ToString(HashedPass).Replace("-", "").ToLower();
                command.Parameters.AddWithValue("@Password", NewPassword);
            }

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
              if(!EventLog.SourceExists(clsDataAccessSettings.ErrorSource))
                {
                    EventLog.CreateEventSource(clsDataAccessSettings.ErrorSource,"Application");
                }
              EventLog.WriteEntry(clsDataAccessSettings.ErrorSource,ex.Message);
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }
    }
}
