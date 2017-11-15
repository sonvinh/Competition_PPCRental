using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Project.Models;

namespace PPCRental_Project.Controllers
{
    public class DetailController : Controller
    {
        //
        // GET: /Detail/
        DemoPPCRentalEntities1 db = new DemoPPCRentalEntities1();
        public ActionResult Detail(int id)
        {
            var p = db.PROPERTY.FirstOrDefault(x => x.ID == id);
            return View(p);
        }
	}
}