using SubjectWebApplictions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SubjectWebApplictions.Controllers
{
    public class SubjectsController : Controller
    {
        readonly SubjectDbContext db = new SubjectDbContext();
        // GET: Subjects
        public ActionResult Index()
        {
            return View(db.Subjects.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Subject b)
        {
            if (ModelState.IsValid)
            {
                db.Subjects.Add(b);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int ID)
        {
            var Sub = db.Subjects.First(x => x.SubjectId == ID);
            return View(db.Subjects.First(b => b.SubjectId == ID));
        }
        [HttpPost]
        public ActionResult Edit(Subject b)
        {
            if (ModelState.IsValid)
            {
                db.Entry(b).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int ID)
        {
            var Sub = db.Subjects.First(x => x.SubjectId == ID);
            return View(db.Subjects.First(b => b.SubjectId == ID));
        }
        [HttpPost]
        public ActionResult Delete(Subject b)
        {
            if (ModelState.IsValid)
            {
                db.Entry(b).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

    }
}