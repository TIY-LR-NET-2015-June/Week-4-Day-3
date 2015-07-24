using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week4_Day3.Models
{
    public class Users
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }

        public static List<Users> ParseUsers()
        {
            List<Users> users = new List<Users>();
            string[] fileContents = System.IO.File.ReadAllLines(@"C:\Users\Aaron\Documents\School\TIY\Week-4-Day-3\Week4-Day3\Week4-Day3\Files\users.txt");
            string[] keys = new string[] 
            {
                "FirstName",
                "LastName",
                "email"

            }, values = new string[fileContents.Length];
            foreach (string line in fileContents)
            {
                values = line.Split(' ');
                users.Add(NewUser(keys, values));
            }
            return users;
        }
        public static Users NewUser(string[] keys, string[] values)
        {
            Users aUser = new Users();
            for (int i = 0; i < keys.Length; i++)
            {
                switch (keys[i])
                {
                    case "FirstName":
                        aUser.FirstName = values[i];
                        break;
                    case "LastName":
                        aUser.LastName = values[i];
                        break;
                    case "email":
                        aUser.email = values[i];
                        break;
                }
            }
            return aUser;
        }
        public override string ToString()
        {
            return String.Format("{0},{1},{2}", FirstName, LastName, email);
        }
    }
}