using Ev_Exam.Models;
using Ev_Exam.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ev_Exam.Controllers
{
    public class TeacherController : Controller
    {
        readonly ClassDbContext db = new ClassDbContext();
        // GET: Teacher
        public ActionResult Index()
        {
            return View(db.Teachers.ToList());
        }
        public ActionResult Create()
        {
            ViewBag.classes = db.Teachers.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(TeacherViewModel e)
        {
            if (ModelState.IsValid)
            {
                Teacher em = new Teacher { Teacher_Name = e.Teacher_Name, Faculty = (int)e.Faculty, ClassId = e.ClassId, ClassStartDate = e.ClassStartDate, Picture = "no-pic.png" };
                if (e.Picture != null)
                {
                    string fileName = Guid.NewGuid() + Path.GetExtension(e.Picture.FileName);
                    e.Picture.SaveAs(Server.MapPath("~/Images/") + fileName);
                    em.Picture = fileName;
                }
                db.Teachers.Add(em);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Branches = db.Teachers.ToList();
            return View();
        }
        public ActionResult Edit(TeacherViewModel e)
        {
            var em = db.Teachers.First(ei => ei.TeacherId == e.TeacherId);
            if (ModelState.IsValid)
            {
                em.Teacher_Name = e.Teacher_Name;
                em.Faculty = (int)e.Faculty;
                em.ClassStartDate = e.ClassStartDate;
                em.ClassId = e.ClassId;
                if (e.Picture != null)
                {
                    string fileName = Guid.NewGuid() + Path.GetExtension(e.Picture.FileName);
                    e.Picture.SaveAs(Server.MapPath("~/Images/") + fileName);
                    em.Picture = fileName;
                }
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Picture = e.Faculty;
            ViewBag.classes = db.classes.ToList();
            return View(e);
        }
        public ActionResult Delete(int ID)
        {
            return View(db.Teachers.First(e => e.TeacherId == ID));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DoneDelete(int ID)
        {
            Teacher em = new Teacher { TeacherId = ID };
            db.Entry(em).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}