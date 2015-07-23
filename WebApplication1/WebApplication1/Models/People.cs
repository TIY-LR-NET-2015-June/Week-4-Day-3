using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class People
    {   [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("email address")]
        public string EMail { get; set; }

        [DisplayName("Full Name")]
        public string FullName()
        {
            {
                return (LastName + ", " + FirstName);
            }
        }
        public People(string firstName, string lastName, string eMail)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EMail = eMail;
        }
       
    }
}