using Ev_Exam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ev_Exam.Controllers
{
    public class ClassesController : Controller
    {
        readonly ClassDbContext db = new ClassDbContext();
        // GET: Classes
        public ActionResult Index()
        {
            return View(db.classes.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(@class c)
        {
            if (ModelState.IsValid)
            {
                db.classes.Add(c);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int Id)
        {
            return View(db.classes.First(a => a.ClassId == Id));
        }
        public ActionResult Edit(@class c)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(int ID)
        {
            return View(db.classes.First(b => b.ClassId == ID));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DoDelete(int ID)
        {
            @class b = new @class { ClassId = ID };
            db.Entry(b).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}