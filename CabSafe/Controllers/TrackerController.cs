using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CabSafe.Models;

namespace CabSafe.Controllers
{
    public class TrackerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Tracker/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Tracker/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TrackingReference trackingreference = db.TrackingReferences.Find(id);
            if (trackingreference == null)
            {
                return HttpNotFound();
            }
            return View(trackingreference);
        }

        public ActionResult TrackPerson()
        {
            return View();
        }
    }
}
