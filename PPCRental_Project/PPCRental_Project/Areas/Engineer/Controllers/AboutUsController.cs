using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Project.Models;

namespace PPCRental_Project.Areas.Engineer.Controllers
{
    public class AboutUsController : Controller
    {
        K21T3_Team1_PPC3129Entities db = new K21T3_Team1_PPC3129Entities();

        [HttpGet]
        // GET: Engineer/AboutUs
        public ActionResult Edit()
        {
            var content = db.ABOUT_US.FirstOrDefault(x => x.ID == 2);
            return View(content);
        }

        [HttpPost]
        public ActionResult Edit(ABOUT_US about_us) 
        {
            var content = db.ABOUT_US.FirstOrDefault(x => x.ID == 2);
            content.Contents = about_us.Contents;
            content.Adress = about_us.Adress;
            content.Sale_ID = 3;
            content.Update_day = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.SaveChanges();
            return View();
        }
    }
}