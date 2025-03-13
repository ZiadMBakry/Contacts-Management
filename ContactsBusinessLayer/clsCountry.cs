using System;
using System.Data;
using ContactsDataAccessLayer;

namespace ContactsBusinessLayer
{
    public class clsCountry
    {
        enum enMode { AddNewMode, UpdateMode }
        enMode Mode;
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string CountryPhoneCode { get; set; }
        private clsCountry(int countryID, string countryName, string countryCode, string countryPhoneCode)
        { 
            CountryID = countryID;
            CountryName = countryName;
            CountryCode = countryCode;
            CountryPhoneCode = countryPhoneCode;
            Mode = enMode.UpdateMode;
        }
        public clsCountry()
        {
            CountryID = -1;
            CountryName = "";
            CountryCode = "";
            CountryPhoneCode = "";
            Mode = enMode.AddNewMode;
        }

        //Private Methods
        private bool _AddNewCountry()
        {
            this.CountryID = clsCountryDataAccess.InsertIntoCountries(this.CountryName,this.CountryCode,this.CountryPhoneCode);
            return (this.CountryID != -1);
        }

        private bool _UpdateCountry()
        {
            int rowsAffected = clsCountryDataAccess.UpdateCountryWithID(this.CountryID, this.CountryName,this.CountryCode,this.CountryPhoneCode);

            return (rowsAffected > 0);
        }

        //Public Methods
        public static clsCountry FindCountry(int countryID)
        {
            string countryName = "";
            string countryCode = "";
            string countryPhoneCode = "";


            if (clsCountryDataAccess.GetCountryInfoByID(countryID, ref countryName, ref countryCode, ref countryPhoneCode))
                return new clsCountry(countryID,countryName,countryCode,countryPhoneCode);
            else
                return null;
        }
        public static clsCountry FindCountry(string countryName)
        {
            int countryID = -1;
            string countryCode = "";
            string countryPhoneCode = "";
            if (clsCountryDataAccess.GetCountryInfoByName(countryName, ref countryID, ref countryCode, ref countryPhoneCode))
                return new clsCountry(countryID, countryName, countryCode, countryPhoneCode);
            else
                return null;
        }

        public static bool DeleteCountry(int countryID)
        {
            return (clsCountryDataAccess.DeleteCountryWithID(countryID) > 0);
        }

        public static DataTable GetAllCountries()
        {
            return (clsCountryDataAccess.GetAllCountriesInfo());
        }

        public static bool IsCountryExist(int countryID)
        {
            return (clsCountryDataAccess.IsCountryWithIDExist(countryID));
        }
        public static bool IsCountryExist(string countryName)
        {
            return (clsCountryDataAccess.IsCountryWithNameExist(countryName));
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNewMode:
                    {
                        if (_AddNewCountry())
                        {
                            Mode = enMode.UpdateMode;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.UpdateMode:
                    {
                        return (_UpdateCountry());
                    }
            }
            return false;
        }

    }
}
