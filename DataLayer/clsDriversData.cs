using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsDriversData
    {
        static public bool GetDriverInfoByDriverID(int DriverID,ref int PersonID,ref int CreatedByUserID,ref DateTime CreatedDate)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = "Select * from Drivers Where DriverID = @DriverID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    IsFound= true;

                    PersonID = (int)reader["PersonID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];

                    reader.Close();

                }
            }
            catch { IsFound = false; }
            finally { connection.Close(); }
            return IsFound;
        }

        static public bool GetDriverInfoByPersonID( int PersonID, ref int DriverID,  ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);
            string Query = "Select * from Drivers Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound= true;

                    DriverID = (int)reader["DriverID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];

                    reader.Close();

                }
            }
            catch { IsFound = false; }
            finally { connection.Close(); }
            return IsFound;
        }

        static public DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @"  
           select Drivers.DriverID,Drivers.PersonID,NationalNo,Concat(FirstName,' ',SecondName,' ',ISNULL(ThirdName,''),' ',LastName) as FullName,
            CreatedDate,
           count(Licenses.LicenseID) as ActiveLicenses from Drivers inner join People on People.PersonID = Drivers.PersonID left join
            Licenses on Licenses.DriverID = Drivers.DriverID and IsActive = 1  group by Drivers.DriverID , Drivers.PersonID,NationalNo,
            FirstName, SecondName ,ThirdName, LastName,CreatedDate;";

            SqlCommand command = new SqlCommand(Query,connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);
            }
            catch { }
            finally { connection.Close(); }

            return dt;
        }

        static public  int AddNewDriver(int PersonID,int CreatedByUserID,DateTime CreateDate)
        {
            int DriverID = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring);

            string Query = @" insert into Drivers (PersonID,CreatedByUserID,CreatedDate)
                              values (@PersonID,@CreatedByUserID,@CreatedDate);
                              Select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query,connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreateDate);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int InsertedDriverID))
                    DriverID = InsertedDriverID;
            }
            catch { DriverID = -1; }
            finally { connection.Close(); }

            return DriverID;
        }

        public static bool UpdateDriverInfo(int DriverID, int PersonID, int CreatedByUserID, DateTime CreateDate)
        {
            bool Updated = false;

            string query = @"
        UPDATE Drivers 
        SET 
            PersonID = @PersonID,
            CreatedByUserID = @CreatedByUserID,
            CreatedDate = @CreateDate
        WHERE 
            DriverID = @DriverID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                       
                        cmd.Parameters.AddWithValue("@DriverID", DriverID);
                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        cmd.Parameters.AddWithValue("@CreateDate", CreateDate);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        Updated = (rowsAffected > 0); 
                    }
                }
                catch 
                {
                    Updated = false;
                }
            }
            return Updated;
        }

        public static bool DeleteDriver(int DriverID)
        {
            bool deleted = false;

            string query = "DELETE FROM Drivers WHERE DriverID = @DriverID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.Connectionstring))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                       
                        cmd.Parameters.AddWithValue("@DriverID", DriverID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        deleted = (rowsAffected > 0); 
                    }
                }
                catch 
                {
                    deleted = true;
                }
            }
            return deleted;
        }

       

      



    }
}
