using ContactsDataAccessLayer;
using System;
using System.Data;

namespace ContactsBusinessLayer
{
    public class clsContact
    {
        enum enMode { AddNewMode , UpdateMode}
        enMode Mode;
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }

        public clsContact()
        {
            ContactID = -1;
            FirstName = "";
            LastName = "";
            Email = "";
            Phone = "";
            Address = "";
            BirthDate = DateTime.Now;
            CountryID = -1;
            ImagePath = "";
            Mode = enMode.AddNewMode;
        }
        private clsContact(int contactID, string firstName, string lastName, string email, string phone, string address, DateTime birthDate, int countryID, string imagePath)
        {
            ContactID = contactID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Address = address;
            BirthDate = birthDate;
            CountryID = countryID;
            ImagePath = imagePath;
            Mode = enMode.UpdateMode;
        }

        //Private Methods
        private bool _AddNewContact()
        {
            this.ContactID = clsContactDataAccess.InsertIntoContacts(this.FirstName, this.LastName, this.Email,
                this.Phone, this.Address, this.BirthDate, this.CountryID, this.ImagePath);
            return (this.ContactID != -1);
        }
        private bool _UpdateContact()
        {
            int rowsAffected = clsContactDataAccess.UpdateContactWithID(this.ContactID,this.FirstName, this.LastName,
                this.Email, this.Phone, this.Address, this.BirthDate, this.CountryID, this.ImagePath);

            return (rowsAffected > 0);
        }

        //Public Methods
        public static clsContact FindContact(int contactID)
        {
            string firstName = "", lastName = "", email = "", phone = "", address = "";
            DateTime birthDate = DateTime.Now;
            int countryID = 0;
            string imagePath = "";

            if (clsContactDataAccess.GetContactInfoByID(contactID, ref firstName, ref lastName, ref email, ref phone, ref address, ref birthDate, ref countryID, ref imagePath))
                return new clsContact(contactID, firstName, lastName, email, phone, address, birthDate, countryID, imagePath);
            else
                return null;
        }
        public static bool DeleteContact(int contactID)
        {
            return (clsContactDataAccess.DeleteContactWithID(contactID) > 0);
        }
        public static bool DeleteContact(clsContact contact)
        {
            return (clsContactDataAccess.DeleteContactWithID(contact.ContactID) > 0);
        }
        public static DataTable GetContacts()
        {
            return (clsContactDataAccess.GetAllContactsInfo());
        }

        public static DataTable GetContacts(string ColumnName, string CellValue, bool isLike = true)
        {
            return (clsContactDataAccess.GetAllContactsInfoWhere(ColumnName,CellValue,isLike));
        }
        public static DataTable GetContact(int contactID)
        {
            return (clsContactDataAccess.GetAllContactsInfoWhere("ContactID",contactID.ToString(), false));
        }
        public static DataTable GetFullDetails()
        {
            return (clsContactDataAccess.GetAllDetails());
        }
        public static DataTable GetFullDetails(string ColumnName, string CellValue, bool isLike = true)
        {
            return (clsContactDataAccess.GetAllDetailsWhere(ColumnName,CellValue,isLike));
        }
        public static DataTable GetContactFullDetails(int contactID)
        {
            return (clsContactDataAccess.GetAllDetailsWhere("ContactID",contactID.ToString(),false));
        }
        public static bool IsContactExist(int contactID)
        {
            return (clsContactDataAccess.IsContactWithIDExist(contactID));
        }

        public static DataTable GetColumnsName()
        {
            return (clsContactDataAccess.GetAllColumnsName());
        }

        public static int GetNumberOfContacts()
        {
            return (clsContactDataAccess.NumberOfContacts());
        }
        public bool Save()
        {
            switch (Mode)
            { 
                case enMode.AddNewMode:
                    {
                        if (_AddNewContact())
                        {
                            Mode = enMode.UpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateMode:
                    {
                        return (_UpdateContact());
                    }
            }
            return false;
        }

    }
}