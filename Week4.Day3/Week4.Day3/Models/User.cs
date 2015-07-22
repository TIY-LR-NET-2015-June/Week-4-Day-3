using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FileHelpers;

namespace Week4.Day3.Models
{
    [DelimitedRecord(" ")]
    public class User
    {
        public string FirstName;
        public string LastName;
        public string Email;
    }
}