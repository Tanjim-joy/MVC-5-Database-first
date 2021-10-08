using Exam_Works_01.Models;
using Exam_Works_01.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam_Works_01.Controllers
{
    public class TeachersController : Controller
    {
        readonly TeachersDbContext Db = new TeachersDbContext();
        // GET: Teachers
        public ActionResult Index()
        {
            return View(Db.Teachers.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.Subjects = Db.Subjects.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(TeachersViewModel t)
        {
            if (ModelState.IsValid)
            {
                Teacher th = new Teacher { Teacher_Name = t.Teacher_Name, Email = t.Email, SubjectId = t.SubjectId, ClassStartDate = t.ClassStartDate, Picture = "no-pic.png" };
                if (t.Picture != null)
                {
                    string fileName = Guid.NewGuid() + Path.GetExtension(t.Picture.FileName);
                    t.Picture.SaveAs(Server.MapPath("~/Images/") + fileName);
                    th.Picture = fileName;
                }
                Db.Teachers.Add(th);
                Db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Subjects = Db.Subjects.ToList();
            return View();
        }


        public ActionResult Edit(int id)
        {
            ViewBag.Subjects = Db.Subjects.ToList();
            var e = Db.Teachers.First(em => em.TeacherId == id);
            ViewBag.Picture = e.Picture;
            return View(new TeachersViewModel { TeacherId = e.TeacherId, Teacher_Name = e.Teacher_Name, Email = e.Email, ClassStartDate = e.ClassStartDate, SubjectId = e.SubjectId });
        }
        [HttpPost]
        public ActionResult Edit(TeachersViewModel e)
        {
            var em = Db.Teachers.First(ei => ei.TeacherId == e.TeacherId);
            if (ModelState.IsValid)
            {
                em.Teacher_Name = e.Teacher_Name;
                em.Email = e.Email;
                em.ClassStartDate = e.ClassStartDate;
                em.SubjectId = e.SubjectId;
                if (e.Picture != null)
                {
                    string fileName = Guid.NewGuid() + Path.GetExtension(e.Picture.FileName);
                    e.Picture.SaveAs(Server.MapPath("~/Images/") + fileName);
                    em.Picture = fileName;
                }
                Db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Picture = e.Picture;
            ViewBag.Subjects = Db.Subjects.ToList();
            return View(e);
        }


        public ActionResult Delete(int Id)
        {
            return View(Db.Teachers.First(e => e.TeacherId == Id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DoneDelete(int Id)
        {
            Teacher em = new Teacher { TeacherId = Id };
            Db.Entry(em).State = System.Data.Entity.EntityState.Deleted;
            Db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}