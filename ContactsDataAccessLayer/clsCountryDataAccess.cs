using System;
using System.Data;
using System.Data.SqlClient;

namespace ContactsDataAccessLayer
{
    public class clsCountryDataAccess
    {
        public static bool GetCountryInfoByID(int countryID, ref string countryName , ref string countryCode , ref string countryPhoneCode)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            string query = "select * from Countries where CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", countryID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    countryName = (string)reader["CountryName"];

                    if (reader["CountryCode"] != DBNull.Value) countryCode = (string)reader["CountryCode"];
                    else countryCode = "";

                    if (reader["CountryPhoneCode"] != DBNull.Value)
                        countryPhoneCode = (string)reader["CountryPhoneCode"];
                    else countryPhoneCode = "";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error : {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool GetCountryInfoByName(string countryName, ref int countryID , ref string countryCode , ref string countryPhoneCode )
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            string query = "select * from Countries where CountryName = @CountryName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", countryName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    countryID = (int)reader["CountryID"];

                    if (reader["CountryCode"] != DBNull.Value) countryCode = (string)reader["CountryCode"];
                    else countryCode = "";

                    if (reader["CountryPhoneCode"] != DBNull.Value)
                        countryPhoneCode = (string)reader["CountryPhoneCode"];
                    else countryPhoneCode = "";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error : {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static int InsertIntoCountries(string countryName , string countryCode = "", string countryPhoneCode = "")
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            string query = "INSERT INTO [dbo].[Countries] (CountryName, CountryCode, CountryPhoneCode) " +
                "VALUES (@CountryName, @CountryCode, @CountryPhoneCode);" +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", countryName);

            if(countryCode == "") command.Parameters.AddWithValue("@CountryCode", DBNull.Value);
            else command.Parameters.AddWithValue("@CountryCode", countryCode);

            if (countryPhoneCode == "") command.Parameters.AddWithValue("@CountryPhoneCode", DBNull.Value);
            else command.Parameters.AddWithValue("@CountryPhoneCode", countryPhoneCode);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    ID = insertedID;
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error :( {ex.Message}");
            }
            finally { connection.Close(); }
            return ID;
        }

        public static int UpdateCountryWithID(int countryID, string countryName, string countryCode = "", string countryPhoneCode = "")
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            string query = "UPDATE [dbo].[Countries] " +
                "SET [CountryName] = @CountryName, [CountryCode] = @CountryCode," +
                "[CountryPhoneCode] = @CountryPhoneCode  WHERE CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", countryName);
            command.Parameters.AddWithValue("@CountryID", countryID);

            if (countryCode == "") command.Parameters.AddWithValue("@CountryCode", DBNull.Value);
            else command.Parameters.AddWithValue("@CountryCode", countryCode);

            if (countryPhoneCode == "") command.Parameters.AddWithValue("@CountryPhoneCode", DBNull.Value);
            else command.Parameters.AddWithValue("@CountryPhoneCode", countryPhoneCode);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                //Console.WriteLine($"Error :( {ex.Message}");
                rowsAffected = 0;
            }
            finally { connection.Close(); }
            return rowsAffected;
        }

        public static int DeleteCountryWithID(int countryID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            string query = "DELETE FROM [dbo].[Countries] WHERE CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", countryID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                //Console.WriteLine($"Error :( {ex.Message}");
                rowsAffected = 0;
            }
            finally { connection.Close(); }
            return rowsAffected;
        }

        public static DataTable GetAllCountriesInfo()
        {
            DataTable countriesTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            string query = "select * from Countries";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    countriesTable.Load(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error : {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return countriesTable;
        }

        public static bool IsCountryWithIDExist(int countryID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            string query = "select Found=1 from Countries where CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryID", countryID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error : {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool IsCountryWithNameExist(string countryName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            string query = "select Found=1 from Countries where CountryName = @CountryName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CountryName", countryName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error : {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
    }
}