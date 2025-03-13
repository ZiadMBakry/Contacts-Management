using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace ContactsDataAccessLayer
{
    public class clsContactDataAccess
    {
        public static bool GetContactInfoByID(int contactID, ref string firstName, ref string lastName, ref string email,
            ref string phone, ref string address, ref DateTime birthDate, ref int countryID, ref string imagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            string query = "select * from Contacts where ContactID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", contactID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    firstName = (string)reader["FirstName"];
                    lastName = (string)reader["LastName"];
                    email = (string)reader["Email"];
                    phone = (string)reader["Phone"];
                    address = (string)reader["Address"];
                    birthDate = (DateTime)reader["DateOfBirth"];
                    countryID = (int)reader["CountryID"];

                    if (reader["ImagePath"] != DBNull.Value)
                        imagePath = (string)reader["ImagePath"];
                    else
                        imagePath = "";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static int InsertIntoContacts(string firstName,string lastName,string email,string phone,string address,
            DateTime birthDate, int countryID, string imagePath)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            string query = "INSERT INTO [dbo].[Contacts] (FirstName,LastName,Email,Phone,Address,DateOfBirth,CountryID,ImagePath) " +
                "VALUES (@FirstName,@LastName,@Email,@Phone,@Address,@BirthDate,@CountryID,@ImagePath);" +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@BirthDate", birthDate);
            command.Parameters.AddWithValue("@CountryID", countryID);

            if (imagePath != "")
                command.Parameters.AddWithValue("@ImagePath", imagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                    ID = insertedID;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { connection.Close(); }
            return ID;
        }

        public static int UpdateContactWithID(int contactID, string firstName, string lastName, string email, 
            string phone, string address,DateTime birthDate, int countryID, string imagePath)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            string query = "UPDATE [dbo].[Contacts] " +
                "SET [FirstName] = @FirstName , [LastName] = @LastName , [Email] = @Email , [Phone] = @Phone ," +
                "[Address] = @Address , [DateOfBirth] = @BirthDate , [CountryID] = @CountryID ," +
                "[ImagePath] = @ImagePath WHERE ContactID = @ContactID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@BirthDate", birthDate);
            command.Parameters.AddWithValue("@CountryID", countryID);

            if (imagePath != "")
                command.Parameters.AddWithValue("@ImagePath", imagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            command.Parameters.AddWithValue("@ContactID", contactID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
               // MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rowsAffected = 0;
            }
            finally { connection.Close(); }
            return rowsAffected;
        }

        public static int DeleteContactWithID(int contactID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            string query = "DELETE FROM [dbo].[Contacts] WHERE ContactID = @ContactID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ContactID", contactID);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rowsAffected = 0;
            }
            finally { connection.Close(); }
            return rowsAffected;
        }

        public static DataTable GetAllContactsInfo()
        {
            DataTable contactsTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            string query = "select * from Contacts";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    contactsTable.Load(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return contactsTable;
        }

        public static DataTable GetAllContactsInfoWhere(string ColumnName, string CellValue, bool isLike = true)
        {
            DataTable contactsTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            SqlCommand command;

            if (isLike)
            {
                string query = $"select * from Contacts WHERE {ColumnName} LIKE @CellValue";

                command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@CellValue", CellValue + "%");
            }
            else
            {
                string query = $"select * from Contacts WHERE {ColumnName} = @CellValue";

                command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@CellValue", CellValue);
            }

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    contactsTable.Load(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return contactsTable;
        }

        public static DataTable GetAllDetails()
        {
            DataTable contactsTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            string query = "SELECT Contacts.ContactID, Contacts.FirstName, Contacts.LastName, Contacts.Email, " +
                "Contacts.Phone, Contacts.Address, Contacts.DateOfBirth, Contacts.ImagePath, Countries.CountryID, " +
                "Countries.CountryName, Countries.CountryCode, Countries.CountryPhoneCode " +
                "FROM Contacts INNER JOIN Countries ON Contacts.CountryID = Countries.CountryID";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    contactsTable.Load(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return contactsTable;
        }

        public static DataTable GetAllDetailsWhere(string ColumnName, string CellValue, bool isLike = true)
        {
            DataTable contactsTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            SqlCommand command;

            if (isLike)
            {
                string query = "SELECT Contacts.ContactID, Contacts.FirstName, Contacts.LastName, Contacts.Email, " +
                    "Contacts.Phone, Contacts.Address, Contacts.DateOfBirth, Contacts.ImagePath, Countries.CountryID, " +
                    "Countries.CountryName, Countries.CountryCode, Countries.CountryPhoneCode " +
                    $"FROM Contacts INNER JOIN Countries ON Contacts.CountryID = Countries.CountryID WHERE Contacts.{ColumnName} LIKE @CellValue";

                command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@CellValue", CellValue + "%");
            }
            else
            {
                string query = "SELECT Contacts.ContactID, Contacts.FirstName, Contacts.LastName, Contacts.Email, " +
                   "Contacts.Phone, Contacts.Address, Contacts.DateOfBirth, Contacts.ImagePath, Countries.CountryID, " +
                   "Countries.CountryName, Countries.CountryCode, Countries.CountryPhoneCode " +
                   $"FROM Contacts INNER JOIN Countries ON Contacts.CountryID = Countries.CountryID WHERE Contacts.{ColumnName} = @CellValue";

                command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@CellValue", CellValue);
            }

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    contactsTable.Load(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return contactsTable;
        }

        public static bool IsContactWithIDExist(int contactID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            string query = "select Found=1 from Contacts where ContactID = @ContactID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ContactID", contactID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

        public static DataTable GetAllColumnsName()
        {
            DataTable columns = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            string query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Contacts';";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    columns.Load(reader);

                reader.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return columns;
        }

        public static int NumberOfContacts()
        {
            int count = 0;

            SqlConnection connection = new SqlConnection(clsDataAceessSettings.ConnectionString);

            string query = "SELECT COUNT(*) FROM Contacts";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                count = (int) command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
            return count;
        }

    }
}