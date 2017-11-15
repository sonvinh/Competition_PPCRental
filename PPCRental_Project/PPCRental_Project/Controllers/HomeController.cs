using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Project.Models;

namespace PPCRental_Project.Controllers
{
    public class HomeController : Controller
    {
        DemoPPCRentalEntities1 db = new DemoPPCRentalEntities1();
        public ActionResult Index()
        {
            var p = db.PROPERTY.ToList();
            return View(p);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}