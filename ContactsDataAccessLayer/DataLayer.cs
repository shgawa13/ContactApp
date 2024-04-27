using System;
using System.CodeDom;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.InteropServices;


namespace ContactsDataAccessLayer
{
  public class clsContactDataAccess
  {
    public static bool GetContactInfoByID(int ID, ref string FirstName, ref string LastName, 
      ref string Email, ref string Phone, ref string Address, ref DateTime DateOfBirth, 
      ref string ImagePath, ref int CountryID)
    {
      bool IsFound = false;
      SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
      string Query = "select * from Contacts where ContactID =@ContactID";
      SqlCommand command = new SqlCommand(Query, connection);
      command.Parameters.AddWithValue("@ContactID", ID);

      try
      {
        connection.Open();
        SqlDataReader reader = command.ExecuteReader();
        if (reader.Read())
        {
          IsFound = true;
          FirstName = (string)reader["FirstName"];
          LastName = (string)reader["LastName"];
          Email = (string)reader["Email"];
          Phone = (string)reader["Phone"];
          Address = (string)reader["Address"];
          DateOfBirth = (DateTime)reader["DateOfBirth"];
          CountryID = (int)reader["CountryID"];

          if (reader["ImagePath"] != DBNull.Value)
          {
            ImagePath = (string)reader["ImagePath"];
          }else
          {
            ImagePath = "";
          }
        }
        else
        {
          IsFound = false;
        }
        reader.Close();
        
      }
      catch(Exception ex)
      {
        //Console.WriteLine($"{ex.Message}");
        IsFound = false;
      } 
      finally
      {
        connection.Close();
      }

      return IsFound;
    }    

    public static bool UpdateContact(int ID, string FirstName, string LastName, string Email, string Phone,
    string Address, DateTime DateOfBirth, int CountryID, string ImagePath)
     {
    int EffectedRow = 0;
    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
    string Query = @"update Contacts 
        set FirstName =@FirstName,
            LastName = @LastName,
            Email = @Email,
            Phone = @Phone,
            Address = @Address,
            DateOfBirth = @DateOfBirth,
            CountryID = @CountryID,
            ImagePath = @ImagePath
            where ContactID = @ContactID";

    SqlCommand command = new SqlCommand(Query, connection);
    command.Parameters.AddWithValue("@ContactID", ID);
    command.Parameters.AddWithValue("@FirstName", FirstName);
    command.Parameters.AddWithValue("@LastName", LastName);
    command.Parameters.AddWithValue("@Email", Email);
    command.Parameters.AddWithValue("@Phone", Phone);
    command.Parameters.AddWithValue("@Address", Address);
    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
    command.Parameters.AddWithValue("@CountryID", CountryID);

    if (ImagePath != "")
      command.Parameters.AddWithValue("@ImagePath", ImagePath);
    else
      command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

    try
    {
      connection.Open();

      EffectedRow = command.ExecuteNonQuery();


    }
    catch (Exception ex)
    {
      return false;
    }
    finally
    {
      connection.Close();
    }
    return (EffectedRow > 0);


  }

    public static int AddnewContact(string FirstName, string LastName, string Email,string Phone,
      string Address, DateTime DateOfBirth, int CountryID, string ImagePath) 
    {
      int ContactID = -1;
      // we make the connection First
      SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
      string Query = @"Insert into contacts(FirstName,LastName,Email,Phone,Address,DateOfBirth,CountryID,ImagePath)
        values(@FirstName,@LastName,@Email,@Phone,@Address,@DateOfBirth,@CountryID,@ImagePath);
        select SCOPE_IDENTITY();";
      SqlCommand command = new SqlCommand(Query, connection);
      command.Parameters.AddWithValue("@FirstName",FirstName);
      command.Parameters.AddWithValue("@LastName",LastName);
      command.Parameters.AddWithValue("@Email",Email);
      command.Parameters.AddWithValue("@Phone",Phone);
      command.Parameters.AddWithValue("@Address",Address);
      command.Parameters.AddWithValue("@DateOfBirth",DateOfBirth);
      command.Parameters.AddWithValue("@CountryID", CountryID);
      
      if(ImagePath != "")
      {
        command.Parameters.AddWithValue("@ImagePath", ImagePath);
      }
      else
      {
        command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
      }

      try
      {
        connection.Open();

        object result = command.ExecuteScalar();

        if (result != null && int.TryParse(result.ToString(), out int insertedID))
        {
          ContactID = insertedID;
        }

      }catch(Exception ex)
      {

      }
      finally
      {
        connection.Close();
      }

      return ContactID;
    }

    

    public static DataTable GetAllContacts()
    {
      DataTable DT = new DataTable();
      SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
      string Query = @"select * from Contacts;";
      SqlCommand command = new SqlCommand(Query, connection);

      try
      {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if(reader.HasRows)
        {
          DT.Load(reader);
        }

        reader.Close();

      }catch(Exception ex)
      {

      }
      finally
      {
        connection.Close();
      }

    return DT;

  }

    public static bool IsExist(int ID)
    {

      bool IsFound = false;

      SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
      string Query = "Select Fond=1 from Contacts where ContactID = @ContactID";
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@ContactID", ID);


      try
      {
        connection.Open();
        SqlDataReader reader = command.ExecuteReader();

        IsFound = reader.HasRows;

        reader.Close();


      }
      catch(Exception ex)
      {
        IsFound = false;
      }

      finally
      {
        connection.Close();
      }

      return IsFound;
    }

    public static bool DeleteContact(int ID)
    {
      int RowsEffected = 0;
      SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
      string Query = @"Delete From Contacts where ContactID=@ContactID";

      SqlCommand command = new SqlCommand(Query, connection);
      command.Parameters.AddWithValue("@ContactID", ID);

      try
      {
        connection.Open();
        RowsEffected = command.ExecuteNonQuery();

      }catch(Exception ex)
      {

      }
      finally
      {
        connection.Close();
      }

      return (RowsEffected > 0);
    }

    public static bool DeleteAllContacts()
    {
      int RowsEffected = 0;

      SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
      string Query = @"Truncate Table Contacts";
      SqlCommand command = new SqlCommand(Query, connection);
      try
      {
        connection.Open();
        RowsEffected = command.ExecuteNonQuery();

       
      }
      catch (Exception)
      {

        throw;
      }
      return (RowsEffected > 0);
    }

    // Countries methods:
    public static int AddNewCountry(string CountryName)
  {
    int CountryID = -1;

    SqlConnection connetion = new SqlConnection(clsDataAccessSettings.ConnectionString);
    string Query = @"insert into Countries(CountryName)
                      values(@CountryName);
                      select SCOPE_IDENTITY();";

    SqlCommand command = new SqlCommand(Query, connetion);
    command.Parameters.AddWithValue("@CountryName", CountryName);

    try
    {
      connetion.Open();
      object result = command.ExecuteScalar();

      if (result != null && int.TryParse(result.ToString(), out int insertedID))
      {
        CountryID = insertedID;
      }

    }
    catch (Exception ex)
    {
      // here we handle Erorr;
      CountryID = -1;

    }
    finally
    {
      connetion.Close();
    }

    return CountryID;
  }

    public static bool GetCountryByID(int ID, ref string CountryName)
    {
      bool Isfound = false;
      SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
      string Query = @"select * from Countries where CountryID=@CountryID;";
      SqlCommand command = new SqlCommand(Query, connection);

      command.Parameters.AddWithValue("@CountryID", ID);

      try
      {
        connection.Open();
        SqlDataReader reader = command.ExecuteReader();

        if(reader.Read())
        {
          Isfound = true;
          CountryName = (string)reader["CountryName"];
        }
      }
      catch(Exception ex)
      {
        Isfound = false;
        // here we handle error;
      }
      finally
      {
        connection.Close();
      }
      return Isfound;
    }

    

    public static bool GetCountryByName(string CountryName, ref int ID)
    {
      bool IsFound = false;

      SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
      string Query =  @"select * from Countries where CountryName = @CountryName;";
      SqlCommand command = new SqlCommand(Query,connection);

      command.Parameters.AddWithValue("@CountryName", CountryName);

      try
      {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();

        if (reader.Read())
        {
          ID = (int)reader["CountryID"];
          IsFound = true;
        }

        reader.Close();

      }catch (Exception ex)
      {
        // here you handle the erorr
      }
      finally
      {
        connection.Close();
      }

      return IsFound;
    }

    // GetAllCountries
    public static DataTable GetAllCountries()
    {
      DataTable DT = new DataTable();
      SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
      string Query = @"select distinct * from Countries;";

      SqlCommand command = new SqlCommand(Query, connection);
      try
      {
        connection.Open();

        SqlDataReader reader = command.ExecuteReader();
        
        if(reader.HasRows)
        {
          DT.Load(reader);
        }

        reader.Close();

      }catch(Exception ex)
      {
        // here we handle erorr;
      }
      finally
      {
        connection.Close();
      }
      return DT;
    }

    public static bool UpdateCountry(int CountryID, string CountryName)
    {
      int EffectedRow = 0;
      SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
      string Query = @"Update Countries
                      set CountryName =@CountryName
                      where CountryID=@CountryID;";

      SqlCommand command = new SqlCommand(Query,connection);
      command.Parameters.AddWithValue("@CountryID", CountryID);
      command.Parameters.AddWithValue("@CountryName", CountryName);

      try
      {
        connection.Open();
        EffectedRow = command.ExecuteNonQuery();
      }catch(Exception ex)
      {
        // here we handle error;
      }
      finally
      {
        connection.Close();
      }

      return (EffectedRow > 0);
    }
  }


}
