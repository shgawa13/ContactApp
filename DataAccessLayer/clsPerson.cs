using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer
{
  public class clsDataAccessLayer: 
  {
    public static DataTable GetAllPeopleInfo()
    {
      DataTable dt = new DataTable();
      SqlConnection connection = new SqlConnection();
      string Query = @"Select * from People";
      SqlCommand command = new SqlCommand(Query, connection);

      try
      {
        connection.Open();
        SqlDataReader reder = command.ExecuteReader();

        if (reder.Read())
        {
          dt.Load(reder);
        }
        reder.Close();
      }
      catch (Exception ex)
      {
        // throw ex
        connection.Close();
      }
      finally
      {
        connection.Close();
      }
      return dt;
    }
  }
}
