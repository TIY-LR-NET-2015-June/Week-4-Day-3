using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class People
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
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