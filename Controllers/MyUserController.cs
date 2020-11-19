using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TestAuthAPI.Models.DALs;
using TestAuthAPI.Models.Entities;
using TestAuthAPI.Outils;

namespace TestAuthAPI.Controllers
{
    public class MyUserController
    {
        public MyOrganization register(string NameOrg, string Email, string Tel)
        {
            MyOrganization organizationRegister = findOrganization(new MyOrganization(NameOrg, Email, Tel));

            if (organizationRegister == null)
            {
                string messageError = null;
                organizationRegister = new MyOrganization(NameOrg, Email, Tel);
                DAL_MyOrganization.AddMyOrganization(organizationRegister, out messageError);

                if (messageError != null)
                    return null;

                return organizationRegister;
            }

            return null;
        }

        public MyUser Login(string Email, string Password)
        {
            return findUser(new MyUser(Email, Password));
        }

        private MyUser findUser(MyUser userSearched)
        {
            string messageError = null;
            DataTable data = DAL_MyUser.GetAllMyUser(out messageError);
            if(data != null)
            {
                List<MyUser> allUsers = MyHelpers.AdaptDataTableToListMyUser(data);
                foreach (var user in allUsers)
                {
                    if (user.isEqualTo(userSearched))
                        return user;
                }
            }

            return null;

        }

        private MyOrganization findOrganization(MyOrganization organizationSearched)
        {
            string messageError = null;
            DataTable data = DAL_MyOrganization.GetAllMyOrganization(out messageError);
            if (data != null)
            {
                List<MyOrganization> allOrg = MyHelpers.AdaptDataTableToListMyOrganization(data);
                foreach (var org in allOrg)
                {
                    if (org.isEqualTo(organizationSearched))
                        return org;
                }
            }

            return null;

        }

    }
}
