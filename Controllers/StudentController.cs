using MVC4Razor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4Razor.Controllers
{
    public class StudentController : Controller
    {
        SchoolResposity schoolContext;
        public StudentController()
        {
            schoolContext = new SchoolResposity();
        }

        //
        // GET: /School/

        public ActionResult Index()
        {
            ViewBag.Students = schoolContext.GetStudents();
            return View();
        }

        //
        // GET: /School/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /School/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /School/Create

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

        //
        // GET: /School/Edit/5

        public ActionResult Edit(int id)
        {
            ViewBag.Teachers = schoolContext.GetTeachers();
            var t = schoolContext.GetStudents().FirstOrDefault(item => item.Id == id);
            return View(t);
        }

        //
        // POST: /School/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var keys = collection.AllKeys;
                foreach (var item in keys)
                {
                    var v = collection[item];
                }
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /School/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /School/Delete/5

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
    }
}
