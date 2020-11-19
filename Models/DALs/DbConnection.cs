using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace TestAuthAPI.Models.DALs
{
    public class DbConnection
    {
        static string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TestCRUD;Data Source=DESKTOP-87TA6MO";
        public static SqlConnection GetConnection(out string messageErrors)
        {
            SqlConnection cn = null;
            messageErrors = null;
            try
            {
                cn = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                messageErrors = ex.Message;
            }
            return cn;
        }
    }
}
