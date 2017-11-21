using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Project.Models;
using System.IO;

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
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var property = db.PROPERTY.FirstOrDefault(x => x.ID == id);
            ViewBag.property_type = db.PROPERTY_TYPE.OrderByDescending(x => x.ID).ToList();
            ViewBag.StreetName = db.STREET.OrderByDescending(x => x.ID).Where(x => x.District_ID >= 31 && x.District_ID <= 54).ToList();
            ViewBag.WardName = db.WARD.OrderByDescending(x => x.ID).Where(x => x.District_ID >= 31 && x.District_ID <= 54).ToList();
            ViewBag.District = db.DISTRICT.OrderByDescending(x => x.ID).Where(x => x.ID>=31&& x.ID<=54).ToList();
            ViewBag.UserName = db.USER.OrderByDescending(x => x.ID).ToList();
            ViewBag.ProJectStatus = db.PROJECT_STATUS.OrderByDescending(x => x.ID).ToList();

            return View(property);
        }
        [HttpPost]
        public ActionResult Edit(int id, PROPERTY p)
        {
            var property = db.PROPERTY.FirstOrDefault(x => x.ID == id);
            property.PropertyName = p.PropertyName;
            property.Avatar = p.Avatar;
            property.Images = p.Images;
            property.PropertyType_ID = p.PropertyType_ID;
            property.Content = p.Content;
            property.Street_ID = p.Street_ID;
            property.Ward_ID = p.Ward_ID;
            property.District_ID = p.District_ID;
            property.UnitPrice = p.UnitPrice;
            property.Area = p.Area;
            property.BedRoom = p.BedRoom;
            property.BathRoom = p.BathRoom;
            property.PackingPlace = p.PackingPlace;
            property.UserID = p.UserID;
            property.Created_at = p.Created_at;
            property.Create_post = p.Create_post;
            property.Status_ID = p.Status_ID;
            property.Note = p.Note;
            property.Updated_at = p.Updated_at;
            property.Sale_ID = p.Sale_ID;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Create(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PROPERTY p)
        {
            var property = new PROPERTY();
            property.PropertyName = p.PropertyName;
            property.Avatar = p.Avatar;
            property.Images = p.Images;
            property.PropertyType_ID = p.PropertyType_ID;
            property.Content = p.Content;
            property.Street_ID = p.Street_ID;
            property.Ward_ID = p.Ward_ID;
            property.District_ID = p.District_ID;
            property.UnitPrice = p.UnitPrice;
            property.Area = p.Area;
            property.BedRoom = p.BedRoom;
            property.BathRoom = p.BathRoom;
            property.PackingPlace = p.PackingPlace;
            property.UserID = p.UserID;
            property.Created_at = p.Created_at;
            property.Create_post = p.Create_post;
            property.Status_ID = p.Status_ID;
            property.Note = p.Note;
            property.Updated_at = p.Updated_at;
            property.Sale_ID = p.Sale_ID;
            db.PROPERTY.Add(property);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var property = db.PROPERTY.FirstOrDefault(x => x.ID == id);
            return View(property);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var property = db.PROPERTY.FirstOrDefault(x => x.ID == id);
            db.PROPERTY.Remove(property);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            var property = db.PROPERTY.FirstOrDefault(x => x.ID == id);
            return View(property);
        }
        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase file)
        {
            if (file != null)
            {
                //string pic = System.IO.Path.GetFileName(file.FileName);
                //string path = System.IO.Path.Combine(
                //                       Server.MapPath("~/Images/") + pic);
                // file is uploaded 
                file.SaveAs(HttpContext.Server.MapPath("C:\\Users\\san\\Source\\Repos\\Competition_PPCRental2\\PPCRental_Project\\PPCRental_Project\\Images")
                                                  + file.FileName);
                //file.SaveAs(path);

                // save the image path path to the database or you can send image 
                // directly to database
                // in-case if you want to store byte[] ie. for DB

                // file is uploaded


                // save the image path path to the database or you can send image 
                // directly to database
                // in-case if you want to store byte[] ie. for DB
                //using (MemoryStream ms = new MemoryStream())
                //{
                //    file.InputStream.CopyTo(ms);
                //    byte[] array = ms.GetBuffer();
                //}


            }
            // after successfully uploading redirect the user
            return View();
        }
    }
}