using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week4.Day3.Models;

namespace Week4.Day3.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        // GET: Users/Parse
        public ActionResult Parse()
        {
            var engine = new FileHelperEngine<User>();
            var result = engine.ReadFileAsList("C:/TIY/Projects/Week-4-Day-3/Week4.Day3/Week4.Day3/Files/users.txt");
            engine.WriteFile("Users", result);
            return RedirectToAction("Index");
        }

        // POST: Users/ViewUsers
        [HttpPost]
        public ActionResult ViewUsers()
        {
            try
            {
                // TODO: Add insert logic here
                return View();
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
