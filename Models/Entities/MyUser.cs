using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAuthAPI.Models.Entities
{

    public class MyUser
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        public MyUser() { }
        public MyUser(string mail, string pwd)
        {
            Email = mail;
            Password = pwd;
        }
        public MyUser(MyUser user)
        {
            if (user != null)
            {
                Id = user.Id;
                Email = user.Email;
                Password = user.Password;
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
