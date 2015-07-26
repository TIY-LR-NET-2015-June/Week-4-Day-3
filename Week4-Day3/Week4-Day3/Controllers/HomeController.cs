using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Week4_Day3.Models;

namespace Week4_Day3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListOfUsers()
        {
            return View(Users.ParseUsers());
        }

        public ActionResult DownloadUsers()
        {
            List<Users> users = Users.ParseUsers();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("First Name,Last Name,email");
            foreach (Users user in users)
            {
                sb.AppendLine(user.ToString());
            }
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(sb.ToString()));
            return File(stream, "text/html", "users.csv");
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
