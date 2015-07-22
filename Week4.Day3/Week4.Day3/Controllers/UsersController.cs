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
        public string Parse()
        {
            var engine = new FileHelperEngine<User>();
            var result = engine.ReadFileAsList("C://psf/Home/Desktop/TIY/Week-4-Day-3/Week4.Day3/Week4.Day3/users.txt");
            return HttpUtility.HtmlEncode(result.First());
        }

        // POST: Users/Create
        [HttpPost]
        public ActionResult Create(List<User> users)
        {
            try
            {
                // TODO: Add insert logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
