using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using PPCRental_Project.Models;

namespace PPCRental_Project.Areas.Agency.Controllers
{


    public class PropertyAgencyController : Controller
    {
        K21T3_Team1_PPC3129Entities model = new K21T3_Team1_PPC3129Entities();

        
            public long Insert(PROPERTY entytiy)
            {
                K21T3_Team1_PPC3129Entities model = new K21T3_Team1_PPC3129Entities();
                model.PROPERTY.Add(entytiy);
                model.SaveChanges();
                return entytiy.ID;
            }
        

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
            ListItem();
            return View(newproperty);
        }

        //Demo
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(PROPERTY NewProperty, List<HttpPostedFileBase> files) 
        {
            ListItem();
            var np = new PROPERTY();
            var IDUser = (int)Session["UserID"];
            NewProperty.UserID = IDUser;
            NewProperty.Status_ID = 2;
            if (String.IsNullOrEmpty(NewProperty.UnitPrice) || String.IsNullOrWhiteSpace(NewProperty.UnitPrice))
            {
                NewProperty.UnitPrice = "VND";
            }
                try
                {

                    string filename = Path.GetFileNameWithoutExtension(NewProperty.AvatarUpload.FileName);
                    string extension = Path.GetExtension(NewProperty.AvatarUpload.FileName);
                    filename = filename + "checkcheck" + DateTime.Now.ToString("yymmssfff") + extension;
                    NewProperty.Avatar = "~/Images/"+filename;
                    filename = Path.Combine(Server.MapPath("~/Images"), filename);
                    // Avatar

                    if (Path.GetFileNameWithoutExtension(NewProperty.AvatarUpload.FileName) == null)
                    {
                        string s2 = "~/Images/ImagesNull.png";
                        NewProperty.Avatar = s2;
                        //NewProperty.AvatarUpload.SaveAs(s2);
                        //property.ImageFile2.SaveAs(filename2);
                    }
                    else
                    {
                        //property.ImageFile2.SaveAs(filename2);
                        NewProperty.AvatarUpload.SaveAs(filename);
                    }
                    
                    NewProperty.Created_at = DateTime.Parse(DateTime.Now.ToShortDateString());
                   
                    if (ModelState.IsValid)
                    {
                        long id = Insert(NewProperty);
                        var path = "";
                        foreach (var item in files)
                        {
                            if (item != null)
                            {
                                if (item.ContentLength > 0)
                                {
                                    if (Path.GetExtension(item.FileName).ToLower() == ".jpg"
                                        || Path.GetExtension(item.FileName).ToLower() == ".png"
                                        || Path.GetExtension(item.FileName).ToLower() == ".gif"
                                        || Path.GetExtension(item.FileName).ToLower() == ".jpeg")
                                    {
                                        var path0 = id + "," + item.FileName;
                                        path = Path.Combine(Server.MapPath("~/MultiImages"), path0);

                                        item.SaveAs(path);
                                        ViewBag.UploadSuccess = true;

                                    }
                                }
                            }
                        }
                        if (id > 0)
                        {
                            return RedirectToAction("Index", "PropertyAgency");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Create khong thanh cong");
                        }
                    }


                }
                catch(NullReferenceException)
                {
                    NewProperty.Created_at = DateTime.Parse(DateTime.Now.ToShortDateString());
                    string s2 = "~/Images/ImagesNull.png";
                    NewProperty.Avatar = s2;
                    if (ModelState.IsValid)
                    {
                        long id = Insert(NewProperty);
                        var path = "";
                        foreach (var item in files)
                        {
                            if (item != null)
                            {
                                if (item.ContentLength > 0)
                                {
                                    if (Path.GetExtension(item.FileName).ToLower() == ".jpg"
                                        || Path.GetExtension(item.FileName).ToLower() == ".png"
                                        || Path.GetExtension(item.FileName).ToLower() == ".gif"
                                        || Path.GetExtension(item.FileName).ToLower() == ".jpeg")
                                    {
                                        var path0 = id + "," + item.FileName;
                                        path = Path.Combine(Server.MapPath("~/MultiImages"), path0);

                                        item.SaveAs(path);
                                        ViewBag.UploadSuccess = true;

                                    }
                                }
                            }
                        }
                        if (id > 0)
                        {
                            return RedirectToAction("Index", "PropertyAgency");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Create khong thanh cong");
                        }
                    }
                }

                return View();
            
        }


        public void ListItem()
        {
            ViewBag.property_type = model.PROPERTY_TYPE.ToList();
            ViewBag.ward = model.WARD.OrderByDescending(x => x.ID).Where(x=> x.District_ID>=31&& x.District_ID<=54).ToList();
            ViewBag.street = model.STREET.OrderByDescending(x => x.ID).Where(x => x.District_ID >= 31 && x.District_ID <= 54).ToList();
            ViewBag.district = model.DISTRICT.OrderByDescending(x => x.ID).Where(x => x.ID>=31 && x.ID<=54).ToList();
            ViewBag.user = model.USER.OrderByDescending(x => x.ID).ToList();
            ViewBag.status = model.PROJECT_STATUS.OrderByDescending(x => x.ID).ToList();

        }
    }
}