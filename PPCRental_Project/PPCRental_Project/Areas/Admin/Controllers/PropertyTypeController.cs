using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Project.Models;

namespace PPCRental_Project.Areas.Admin.Controllers
{
    public class PropertyTypeController : Controller
    {
        K21T3_Team1_PPC3129Entities db = new K21T3_Team1_PPC3129Entities();

        // GET: Admin/PropertyType
        public ActionResult Index()
        {
            var typeList = db.PROPERTY_TYPE.ToList();
            return View(typeList);
        }

        [HttpGet]
        public ActionResult createPropertyType()
        {

            //

            var nType = new PROPERTY_TYPE();
            return View(nType);
        }

        [HttpPost]
        public ActionResult createPropertyType(PROPERTY_TYPE p)
        {
            var testcodetype = db.PROPERTY_TYPE.Where(x => x.CodeType == p.CodeType);
            var testDescription = db.PROPERTY_TYPE.Where(x => x.Description == p.Description);
            p.Status = true;
            if (testcodetype.Count() == 0)
            {
                if (testDescription.Count() == 0)
                {
                    db.PROPERTY_TYPE.Add(p);
                    db.SaveChanges();
                    TempData["create"] = "Loại dự án mới đã được tạo thành công";
                    return RedirectToAction("Index", "PropertyType");
                }
            }
            ViewBag.mess = "Loại dự án bị trùng vui lòng nhập lại loại dự án";
            return View();
        }

        [HttpGet]
        public ActionResult editPropertyType(int id)
        {
            var Type = db.PROPERTY_TYPE.FirstOrDefault(x => x.ID == id);
            return View(Type);
        }

        [HttpPost]
        public ActionResult editPropertyType(PROPERTY_TYPE p)
        {
            var entity = db.PROPERTY_TYPE.Find(p.ID);
            entity.CodeType = p.CodeType;
            entity.Description = p.Description;
            db.PROPERTY_TYPE.Add(entity);
            db.SaveChanges();
            return View("Index");
        }
    }
}