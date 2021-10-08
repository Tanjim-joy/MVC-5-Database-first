using SubjectWebApplictions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SubjectWebApplictions.Controllers
{
    public class TeachersController : Controller
    {
        readonly SubjectDbContext db = new SubjectDbContext();
        // GET: Teachers
        public ActionResult Index()
        {
            return View();
        }
    }
}