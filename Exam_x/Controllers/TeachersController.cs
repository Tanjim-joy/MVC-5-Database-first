using Exam_x.Models;
using Exam_x.Models.MetaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam_x.Controllers
{
    public class TeachersController : Controller
    {
        readonly TeachersDbcontext db = new TeachersDbcontext();
        // GET: Teachers
        public ActionResult Index()
        {
            return View(db.Teachers.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Create (Teacher t)
        {
            if (ModelState.IsValid)
            {
                db.Teachers.Add(t);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}