using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TestAuthAPI.Models.Entities;
namespace TestAuthAPI.Outils
{
    public class MyHelpers
    {

        //get the first form Open ====> Login Form
        public static Form firstForm = null;

        public static List<MyUser> allMyUsers = new List<MyUser>();

        public static MyUser ConvertRowToMyUser(DataRow row)
        {

            long Id = long.Parse(row["Id"].ToString());

            string Email = (row["Email"].ToString().Length != 0) ? row["Email"].ToString() : "pas de Email";

            string Password = (row["Password"].ToString().Length != 0) ? row["Password"].ToString() : "pas de Password";
            MyUser user = new MyUser(Email, Password);
            user.Id = Id;

            return user;
        }

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
        public static List<MyUser> AdaptDataTableToListMyUser(DataTable CurrentDataTable)
        {

            List<MyUser> AllMyUsers = new List<MyUser>();

            //Get All The Rows Of The First DataTable

            foreach (DataRow row in CurrentDataTable.Rows)
            {
                AllMyUsers.Add(ConvertRowToMyUser(row));
            }

            return AllMyUsers;
        }
        public static List<MyOrganization> AdaptDataTableToListMyOrganization(DataTable CurrentDataTable)
        {

            List<MyOrganization> allMyOrganizations = new List<MyOrganization>();

            //Get All The Rows Of The First DataTable

            foreach (DataRow row in CurrentDataTable.Rows)
            {
                allMyOrganizations.Add(ConvertRowToMyOrganization(row));
            }

            return allMyOrganizations;
        }

        public static bool IsTextEmpty(string Texte)
        {
            return (Texte.Trim().Length == 0);
        }
    }

}
