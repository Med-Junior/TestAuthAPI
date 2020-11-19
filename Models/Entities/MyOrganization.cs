using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAuthAPI.Models.Entities
{

    public class MyOrganization
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        
        public MyOrganization() { }
        public MyOrganization(string name, string mail, string tel)
        {
            Name = name;
            Email = mail;
            Telephone = tel;
        }
        public MyOrganization(MyOrganization organization)
        {
            if (organization != null)
            {
                Id = organization.Id;
                Email = organization.Email;
                Name = organization.Name;
                Telephone = organization.Telephone;
            }
        }
        override
        public string ToString()
        {
            return Email + ";" + Name + ";" + Telephone;
        }

        public bool isEqualTo(MyOrganization organizationComp)
        {
            return 
              (
                organizationComp != null &&
                this.Telephone.Trim().Equals(organizationComp.Telephone.Trim().ToLower()) &&
                this.Email.Trim().ToLower().Equals(organizationComp.Email.Trim().ToLower()) && 
                this.Name.Trim().Equals(organizationComp.Name.Trim())
              ) 
                ? true : false;
        }
    }
}
