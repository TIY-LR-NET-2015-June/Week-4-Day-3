using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Routing;
using W4D3HW.Models;

namespace W4D3HW.Controllers
{


    public class UserController : Controller
    {
        public static string CsvFile = HostingEnvironment.MapPath("~\\Files\\Users.txt");
        public static string OutputFile = HostingEnvironment.MapPath("~\\Files\\Users.csv");
        public static List<User> Users;
        //BEGIN: User
        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            if (requestContext.HttpContext.Session["Users"] == null)
            {
                requestContext.HttpContext.Session["Users"] = Models.User.ImportUsers(CsvFile);
            }
            Users = (List<User>)requestContext.HttpContext.Session["Users"];

            return base.BeginExecute(requestContext, callback, state);

        }

        // GET: User
        public ActionResult Index()
        {
            return View(Session["Users"]);
        }

        // GET: User/Details/5
        public ActionResult Details(Guid id)
        {
            return View(Session["Users"]);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
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

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Download()
        {

            return File((Models.User.ExportUsers(Users)), "text/csv", "users.csv");
        }


    }
}
