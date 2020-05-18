using System;
using System.Data.SqlClient;
using System.Data.Objects.DataClasses;
using System.Data.Objects.SqlClient;



namespace Tracker.Persistance
{

    public class UserRepository
    {
       
        public static bool VerifyCredentials(string username,string hash)
        {
           
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lunartech\source\repos\Tracker.Presentation\App_Data\myDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            
            SqlConnection db = new SqlConnection(cs);
            try
            {

                SqlCommand myCommand = default;

                myCommand = new SqlCommand("SELECT Username,Password FROM Users WHERE Username = @Username AND Password = @Password", db);

                SqlParameter uName = new SqlParameter("@Username", System.Data.SqlDbType.VarChar);

                SqlParameter uPassword = new SqlParameter("@Password", System.Data.SqlDbType.VarChar);

                uName.Value = username;
                uPassword.Value = hash;

                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                return myReader.Read();
            }
            catch (Exception ex)
            {

                return false;
            }
            finally
            {
                if (db.State == System.Data.ConnectionState.Open){db.Dispose();}

            }
        }
    }
}
