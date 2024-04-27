using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using ContactsDataAccessLayer;
using Microsoft.SqlServer.Server;

namespace ContactsBusinessLayer
{
  public class clsContact
  {
    public enum enMode { AddNew=0, Update=1};
    public enMode Mode = enMode.AddNew;

    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }  
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string ImagePath { get; set; }
    public int CountryID { get; set; }
  

    /// <summary>
    ///  Defult constructer to add new contact  
    /// </summary>
    public clsContact() 
    {
      this.ID = -1;
      this.FirstName = "";
      this.LastName = "";
      this.Email = "";
      this.Phone = "";
      this.Address = "";
      this.DateOfBirth = DateTime.Now;
      this.CountryID = -1;
      this.ImagePath = "";
 
      Mode = enMode.AddNew;
    }

    

    private clsContact(int ID, string FirstName, string LastName, string Email,
     string Phone, string Address, DateTime DateOfBirth, string ImagePath, int CountryID)
    {
      this.ID = ID;
      this.FirstName = FirstName;
      this.LastName = LastName;
      this.Email = Email;
      this.Phone = Phone;
      this.Address = Address;
      this.DateOfBirth = DateOfBirth;
      this.ImagePath = ImagePath;
      this.CountryID = CountryID;
      Mode = enMode.Update;
    }


    private bool _AddNewContact() 
    {
      this.ID = clsContactDataAccess.AddnewContact(this.FirstName, this.LastName, this.Email, this.Phone,
        this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);

        return (this.ID != -1);
    }

    private bool _UpdateContact() 
    {
      return clsContactDataAccess.UpdateContact(this.ID, this.FirstName, this.LastName, this.Email, this.Phone,
        this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);
    }

    public static clsContact Find(int ID)
    {
      string FirstName = "", LastName = "",Email="",Phone="",Address="",ImagePath="";
      DateTime DateOfBirth = DateTime.Now;
      int CountryID = 1;

      if (clsContactDataAccess.GetContactInfoByID(ID, ref FirstName, ref LastName, ref Email,ref Phone,
        ref Address, ref DateOfBirth, ref ImagePath, ref CountryID))
      {
        return new clsContact(ID, FirstName, LastName, Email, Phone, Address, DateOfBirth, ImagePath, CountryID);
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
          if(_AddNewContact())
          {
            Mode = enMode.Update;
            return true;
          }
          else
          {
            return false;
          }
        case enMode.Update:
         return _UpdateContact();
      }
      return false;
    }
    
    public static bool DeleteContact(int ID)
    {
      return clsContactDataAccess.DeleteContact(ID);
    }

    public static bool DeleteAllcontacts()
    {
      return clsContactDataAccess.DeleteAllContacts();
    }

    public static bool IsContactExist(int ID)
    {
      return clsContactDataAccess.IsExist(ID);
    }

    public static DataTable GetAllContacts()
    {

      return clsContactDataAccess.GetAllContacts();
    }


  }
  
  
   

    /// <summary>
    /// Country Class and methods
    /// </summary>
    
 
  }
