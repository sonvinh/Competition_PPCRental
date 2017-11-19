using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Project.Models;
namespace PPCRental_Project.Areas.Admin.Controllers
{
    public class PropertyAdminController : Controller
    {
        K21T3_Team1_PPC3129Entities db = new K21T3_Team1_PPC3129Entities();
        // GET: Admin/PropertyAdmin
        public ActionResult Index()
        {
            var p = db.PROPERTY.OrderByDescending(x => x.ID).ToList();
            return View(p);
        }
    }
}