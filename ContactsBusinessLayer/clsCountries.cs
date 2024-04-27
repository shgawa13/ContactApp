using ContactsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsBusinessLayer
{
 

    public class clsCountry
    {
      public enum enMode { AddNew = 0, Update = 1 };
      public enMode Mode = enMode.AddNew;
      public int CountryID { get; set; }
      public string CountryName { get; set; }

      // this class to create new object like add new record.

      public clsCountry()
      {
        this.CountryID = -1;
        this.CountryName = "";
        Mode = enMode.AddNew;
      }

      // this class is praivate to update record.

      private clsCountry(int CountryID, string CountryName)
      {
        this.CountryID = CountryID;
        this.CountryName = CountryName;
        Mode = enMode.Update;
      }

      // Country Methods


      private bool _AddNewCountry()
      {
        this.CountryID = clsContactDataAccess.AddNewCountry(this.CountryName);
        return (CountryID != -1);
      }

      private bool _UpdateCountry()
      {
        return clsContactDataAccess.UpdateCountry(this.CountryID, this.CountryName);
      }


      public static clsCountry FindCountryByID(int ID)
      {

        string CountryName = "";

        if (clsContactDataAccess.GetCountryByID(ID, ref CountryName))
        {
          return new clsCountry(ID, CountryName);
        }
        else
        {
          return null;
        }
      }

      //GetAllCountries
      public static DataTable ListAllCountries()
      {
        return clsContactDataAccess.GetAllCountries();
      }

      public static clsCountry FindCountryByName(string CountryName)
      {
        int ID = -1;
        if (clsContactDataAccess.GetCountryByName(CountryName, ref ID))
        {
          return new clsCountry(ID, CountryName);
        }
        else
        {
          return null;
        }
      }


      public bool Save()
      {
        switch (Mode)
        {
          case enMode.AddNew:
            if (_AddNewCountry())
            {
              Mode = enMode.Update;
              return true;
            }
            else
            {
              return false;
            }
          case enMode.Update:
            return _UpdateCountry();
        }
        return false;
      }

    }
  }

