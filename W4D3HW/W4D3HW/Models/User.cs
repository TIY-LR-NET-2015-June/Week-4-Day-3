using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using WebGrease.Extensions;

namespace W4D3HW.Models
{

    public class User
    {//STATIC
        public static List<User> ImportUsers(string filename)
        {
            var reader = File.OpenText(filename);
            var result = new List<User>();

            while (!reader.EndOfStream)
            {
                var fields = reader.ReadLine().Split(' ');
                result.Add(new User(fields[1], fields[0], fields[2]));
            }
            return result;
        }

        public static byte[] ExportUsers(List<User> users)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("firstname,lastname,email");

            foreach (var user in users)
            {
                sb.AppendFormat("{0},{1},{2}\r", user.FirstName, user.LastName, user.Email);
            }
            return Encoding.ASCII.GetBytes(sb.ToString());
        }

        //INSTANCE
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public Guid Id { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public User(string lastName, string firstName, string email)
        {
            Id = Guid.NewGuid();
            LastName = lastName;
            FirstName = firstName;
            Email = email;
        }

    }
}