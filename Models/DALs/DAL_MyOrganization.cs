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
    public class DAL_MyOrganization
    {
        private static SqlCommand MySqlCommand;

        public static MyOrganization ConvertRowToMyOrganization(DataRow row)
        {
            MyOrganization CurrentMyOrganization = new MyOrganization();

            long Id = long.Parse((row["Id"].ToString().Length != 0) ? row["Id"].ToString() : "0");
            CurrentMyOrganization.Id = Id;

            string Emails = (row["Email"].ToString().Length != 0) ? row["Email"].ToString() : "pas de Email";
            CurrentMyOrganization.Email = (Emails);


            string Names = (row["Name"].ToString().Length != 0) ? row["Name"].ToString() : "pas de Name";
            CurrentMyOrganization.Name = (Names);

            string Tel = (row["Telephone"].ToString().Length != 0) ? row["Telephone"].ToString() : "pas de Telephone";
            CurrentMyOrganization.Telephone = (Tel);

            return CurrentMyOrganization;

        }
        
        public static DataTable GetAllMyOrganization(out string messageError)
        {
            messageError = null;
            DataTable dataTable = null;
            using (SqlConnection con = DbConnection.GetConnection(out messageError))
            {
                try
                {
                    con.Open();
                    
                    MySqlCommand = new SqlCommand("SELECt * from MyOrganization", con);

                    dataTable = DataBaseAccessUtilities.SelectRequest(MySqlCommand, out messageError);

                }
                catch (Exception ex)
                {
                    messageError = ex.Message;
                }
            }
            return dataTable;
        }

        public static MyOrganization GetMyOrganizationById(long Id, out string messageError)
        {
            messageError = null;
            using (SqlConnection con = DbConnection.GetConnection(out messageError))
            {
                con.Open();

                MySqlCommand = new SqlCommand("select * from MyOrganization where id = @Id ", con);

                MySqlCommand.Parameters.Add("@Id", SqlDbType.BigInt).Value = Id;

                DataTable dt = DataBaseAccessUtilities.SelectRequest(MySqlCommand, out messageError);

                if (dt != null && dt.Rows.Count != 0)
                    return ConvertRowToMyOrganization(dt.Rows[0]);
                else
                    return null;
            }
        }

        public static void AddMyOrganization(MyOrganization newMyOrganization, out string messageError)
        {
            try
             {
                using (SqlConnection con = DbConnection.GetConnection(out messageError))
                {

                    MySqlCommand = new SqlCommand("insert into MyOrganization(Email,Name, Telephone) values ( @Email,@Name,@Telephone )", con);


                    MySqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = newMyOrganization.Email;

                    MySqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = newMyOrganization.Name;
                    MySqlCommand.Parameters.Add("@Telephone", SqlDbType.VarChar).Value = newMyOrganization.Telephone;

                    DataBaseAccessUtilities.NonQueryRequest(MySqlCommand, out messageError);
                }

            }
            catch(Exception ex)
            {
                messageError =  ex.Message;
            }

        }
       
        public static void UpdateMyOrganization(long Id, MyOrganization newMyOrganization, out string messageError)
        {

            try
            {
                using (SqlConnection con = DbConnection.GetConnection(out messageError))
                {
                    MySqlCommand = new SqlCommand("update MyOrganization set " +
                    "Email=@Email,Name=@Name,Telephone=@Telephone where Id = @Id", con);

                    MySqlCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = newMyOrganization.Email;

                    MySqlCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = newMyOrganization.Name;
                    MySqlCommand.Parameters.Add("@Telephone", SqlDbType.VarChar).Value = newMyOrganization.Telephone;

                    MySqlCommand.Parameters.Add("@Id", SqlDbType.BigInt).Value = Id;

                    DataBaseAccessUtilities.NonQueryRequest(MySqlCommand, out messageError);
                }

            }
            catch (Exception ex)
            {
                messageError = ex.Message;
            }

        }
       
        public static void DeleteMyOrganization(long Id, out string messageError)
        {
            try
            {
                using (SqlConnection con = DbConnection.GetConnection(out messageError))
                {

                    MySqlCommand = new SqlCommand("delete from MyOrganization where Id = @Id", con);

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
