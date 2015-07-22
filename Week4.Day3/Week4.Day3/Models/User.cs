using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week4.Day3.Models
{
    public class User
    {
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Email { get; set; }

        string Name = FirstName + " " + LastName;
    }
}