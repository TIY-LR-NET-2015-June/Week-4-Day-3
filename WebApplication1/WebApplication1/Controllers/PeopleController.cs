using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PeopleController : Controller
    {
        
        
        
        

        // GET: People
        public ActionResult Index()
        {
            return View(Session["People"]);
        }

        // GET: People/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: People/Create
        public ActionResult Create()
        {
            List<People> sheet = new List<People>();
            string[] line = System.IO.File.ReadAllLines(@"C:\Users\Mike\Desktop\The Iron Yard\week4day3\WebApplication1\WebApplication1\files\users.txt");

            int rows = line.Count();
            for (int i = 0; i < rows; i++)
            {
                string[] cell = line[i].Split(' ');
                People p = new People(cell[0], cell[1], cell[2]);
                sheet.Add(p);
                Session["People"] = sheet;
            }

            return RedirectToAction("Index");
        }

        // POST: People/Create
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

        // GET: People/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: People/Edit/5
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

        // GET: People/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: People/Delete/5
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
            List<People> sheet = (List<People>)Session["People"];
            string[] lines = new string[sheet.Count + 1];
            lines[0] = "First Name,Last Name,e-mail address";
            int j = 1;
            foreach (People p in sheet)
            {
                lines[j] = (p.FirstName + "," + p.LastName + "," + p.EMail);
                j++;
            }
            System.IO.File.WriteAllLines(@"C:\Users\Mike\Desktop\The Iron Yard\week4day3\WebApplication1\WebApplication1\files\outputfile.csv", lines);
            return File(@"C:\Users\Mike\Desktop\The Iron Yard\week4day3\WebApplication1\WebApplication1\files\outputfile.csv", "file.csv");
        }
    }
}
