using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using week4day3homework.Models;

namespace week4day3homework.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var people = GetPeople();
            return View(people);
        }

        private List<Person> GetPeople()
        {
            //TODO  JASON FILL THIS OUT BY READING FROM A CSV hint: File.ReadAllLines("filename.txt");
            var people = new List<Person>();
            var lines = System.IO.File.ReadAllLines(Server.MapPath("~/App_Data/file.txt"));
            foreach (var line in lines)
            {
                var info = line.Split(' ');
                var p = new Person() { FirstName = info[0], LastName = info[1], Email = info[2] };
                
                people.Add(p);
            }
            return people;
        }
    }
}