using Evidance_001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Evidance_001.Controllers
{
    public class VehiclesController : Controller
    {
        readonly VehicleDbContext db = new VehicleDbContext();
        // GET: Vehicles
        public ActionResult Index()
        {
            return View(db.Vehicles.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Vehicle v)
        {
            if (ModelState.IsValid)
            {
                db.Vehicles.Add(v);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(v);
        }
        public ActionResult Delete(int id)
        {
            return View(db.Vehicles.First(x => x.VehicleId == id));
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteCfm(int id)
        {
            Vehicle v = new Vehicle { VehicleId = id };
            db.Entry(v).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Car c)
        {
            return View();
        }
    }
}