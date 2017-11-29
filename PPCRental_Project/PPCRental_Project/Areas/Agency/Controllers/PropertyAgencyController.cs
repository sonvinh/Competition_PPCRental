using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Project.Models;

namespace PPCRental_Project.Areas.Agency.Controllers
{
    public class PropertyAgencyController : Controller
    {
        K21T3_Team1_PPC3129Entities model = new K21T3_Team1_PPC3129Entities();

        //
        // GET: /Agency/PropertyAgency/
        public ActionResult Index()
        {
            if (Session["UserID"] != null)
            {
                var id = (int)Session["UserID"];
                var user = model.PROPERTY.Where(x => x.USER.ID == id).ToList();
                return View(user);
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public ActionResult Create()
        {
            PROPERTY newproperty = new PROPERTY();
            return View(newproperty);
        }
    }
}