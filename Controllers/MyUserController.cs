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
        public MyOrganization register(MyOrganization myOrganization, out string error)
        {
            error = "";
            MyOrganization organizationRegister = findOrganization(myOrganization, out error);

            if (organizationRegister == null)
            {
                organizationRegister = new MyOrganization(myOrganization);
                DAL_MyOrganization.AddMyOrganization(organizationRegister, out error);

                if (error != null)
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

        private MyOrganization findOrganization(MyOrganization organizationSearched, out string error)
        {
            error = "";
            return DAL_MyOrganization.GetMyOrganizationByName(organizationSearched.Name, out error);

        }

    }
}
