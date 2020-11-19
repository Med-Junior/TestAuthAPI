using TestAuthAPI.Models.DALs;
using TestAuthAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TestAuthAPI.Utilities;

namespace TestAuthAPI.Models.DALs
{
    public class DAL_MyUser
    {
        private static SqlCommand MySqlCommand;

        public static MyUser ConvertRowToMyUser(DataRow row)
        {
            MyUser CurrentMyUser = new MyUser();

            long Id = long.Parse((row["Id"].ToString().Length != 0) ? row["Id"].ToString() : "0");
            CurrentMyUser.Id = Id;

            string Emails = (row["Email"].ToString().Length != 0) ? row["Email"].ToString() : "pas de Email";
            CurrentMyUser.Email = (Emails);


            string Passwords = (row["Password"].ToString().Length != 0) ? row["Password"].ToString() : "pas de Password";
            CurrentMyUser.Password = (Passwords);

            return CurrentMyUser;

        }
        
        public static DataTable GetAllMyUser(out string messageError)
        {
            messageError = null;
            DataTable dataTable = null;
            using (SqlConnection con = DbConnection.GetConnection(out messageError))
            {
                try
                {
                    con.Open();
                    
                    MySqlCommand = new SqlCommand("SELECt * from MyUser", con);

                    dataTable = DataBaseAccessUtilities.SelectRequest(MySqlCommand, out messageError);

                }
                catch (Exception ex)
                {
                    messageError = ex.Message;
                }
            }
            return dataTable;
        }

        public static MyUser GetMyUserById(long Id, out string messageError)
        {
            messageError = null;
            using (SqlConnection con = DbConnection.GetConnection(out messageError))
            {
                con.Open();

                MySqlCommand = new SqlCommand("select * from MyUser where id = @Id ", con);

                MySqlCommand.Parameters.Add("@Id", SqlDbType.BigInt).Value = Id;

                DataTable dt = DataBaseAccessUtilities.SelectRequest(MySqlCommand, out messageError);

                if (dt != null && dt.Rows.Count != 0)
                    return ConvertRowToMyUser(dt.Rows[0]);
                else
                    return null;
            }
        }

        public static void AddMyUser(MyUser newMyUser, out string messageError)
        {
            try
             {
                using (SqlConnection con = DbConnection.GetConnection(out messageError))
                {

                    MySqlCommand = new SqlCommand("insert into MyUser(Email,Password) values ( @Email,@Password )", con);


                    MySqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = newMyUser.Email;

                    MySqlCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = newMyUser.Password;

                    DataBaseAccessUtilities.NonQueryRequest(MySqlCommand, out messageError);
                }

            }
            catch(Exception ex)
            {
                messageError =  ex.Message;
            }

        }
       
        public static void UpdateMyUser(long Id, MyUser newMyUser, out string messageError)
        {

            try
            {
                using (SqlConnection con = DbConnection.GetConnection(out messageError))
                {
                    MySqlCommand = new SqlCommand("update MyUser set " +
                    "Email=@Email,Password=@Password where Id = @Id", con);

                    MySqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = newMyUser.Email;

                    MySqlCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = newMyUser.Password;

                    MySqlCommand.Parameters.Add("@Id", SqlDbType.BigInt).Value = Id;

                    DataBaseAccessUtilities.NonQueryRequest(MySqlCommand, out messageError);
                }

            }
            catch (Exception ex)
            {
                messageError = ex.Message;
            }

        }
       
        public static void DeleteMyUser(long Id, out string messageError)
        {
            try
            {
                using (SqlConnection con = DbConnection.GetConnection(out messageError))
                {

                    MySqlCommand = new SqlCommand("delete from MyUser where Id = @Id", con);

                    MySqlCommand.Parameters.Add("@Id", SqlDbType.BigInt).Value = Id;
                    DataBaseAccessUtilities.NonQueryRequest(MySqlCommand, out messageError);

                }
            }
            catch (Exception ex)
            {
                messageError = ex.Message;
            }


        }
    }
}
