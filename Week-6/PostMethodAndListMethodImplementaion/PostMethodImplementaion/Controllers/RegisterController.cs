using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PostMethodImplementaion.Models;

namespace PostMethodImplementaion.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register/StudentList
        public ActionResult StudentList()
        {
            using (StudentModelEntity db = new StudentModelEntity())
            {
                return View(db.Students.ToList());
            }
        }

        // GET: Register/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Register/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Register/Create
        [HttpPost]
        public ActionResult Create(Student student)
        {
            try
            {
                int index = 6;
                student.StudentID = index++;
                // TODO: Add insert logic here
                using (StudentModelEntity db = new StudentModelEntity())
                {
                    db.Students.Add(student);
                    db.SaveChanges();
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Register/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Register/Edit/5
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

        // GET: Register/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Register/Delete/5
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
