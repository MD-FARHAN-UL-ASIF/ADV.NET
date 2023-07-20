using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.DB;
using ZeroHunger.Models;

namespace ZeroHunger.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Volunteer()
        {
            return View();
        }

        public ActionResult Employee()
        {
            return View();
        }

        public ActionResult Restaurant()
        {
            return View();
        }
        public ActionResult Admin()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Assign()
        {
            return View();
        }
        [HttpPost
            public ActionResult Assign(CollectionDTO collection) 
        {
            if(ModelState.IsValid)
            {
                var db = new Zero_HungerEntities5();
                db.Collections.Add(Convert(collection));
                db.SaveChanges();
                return RedirectToAction("");

            }
            return View();
        }
        Collection Convert(CollectionDTO collection)
        {
            id  = collection.id,

        }

        

    }
}