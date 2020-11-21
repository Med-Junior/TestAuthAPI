using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAuthAPI.Models.Entities
{
    public class MyUser
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long IdOrganization { get; set; }
        public MyOrganization Organization { get; set; }
        public string Role { get; set; }
        public string AccountCreationDate { get; set; }
        public string LastLoginDate { get; set; }
        public MyUser() { }
        public MyUser(string mail, string pwd, MyOrganization mOrganization = null, string role = null, string accountCreationDate = null, string lastLoginDate = null)
        {
            Email = mail;
            Password = pwd;
            Organization = mOrganization;
            if (Organization != null)
                IdOrganization = Organization.Id;
            Role = role;
            AccountCreationDate = accountCreationDate;
            LastLoginDate = lastLoginDate;
        }
        public MyUser(MyUser user)
        {
            if (user != null)
            {
                Id = user.Id;
                Email = user.Email;
                Password = user.Password;
                Organization = user.Organization;
                if(user.Organization != null)
                    IdOrganization = user.Organization.Id;
                Role = user.Role;
                AccountCreationDate = user.AccountCreationDate;
                LastLoginDate = user.LastLoginDate;
            }
        }
        override
        public string ToString()
        {
            return Email + ";" + Password;
        }

        public bool isEqualTo(MyUser userComp)
        {
            return 
              (
                userComp != null &&
                this.Email.Trim().ToLower().Equals(userComp.Email.Trim().ToLower()) && 
                this.Password.Trim().Equals(userComp.Password.Trim())
              ) 
                ? true : false;
        }
    }
}
