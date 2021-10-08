using Exam_Work_001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam_Work_001.Controllers
{
    public class SubjectsController : Controller
    {
        readonly TeacherDbContext db = new TeacherDbContext();
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
        public ActionResult Create(Subject s)
        {
            if (ModelState.IsValid)
            {
                db.Subjects.Add(s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}