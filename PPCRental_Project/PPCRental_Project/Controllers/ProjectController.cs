using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Project.Models;

namespace PPCRental_Project.Controllers
{
    public class ProjectController : Controller
    {
        K21T3_Team1_PPC3129Entities PPCRENTAL = new K21T3_Team1_PPC3129Entities();

        [HttpGet]
        //search theo id cua quan,phuong,duong,loai du an
        public ActionResult Search(int district,  int PropertyType)
        {
            object product;
            if (district == 0 && PropertyType == 0) // khong chon cai nao
            {
                product = PPCRENTAL.PROPERTY.ToList();
            }
            else if (PropertyType == 0) //chi chon quan
            {
                product = PPCRENTAL.PROPERTY.ToList().Where(x => x.District_ID == district);
            }
            else if (district == 0) //chi chon loai du an
            {
                product = PPCRENTAL.PROPERTY.ToList().Where(x => x.PropertyType_ID == PropertyType);
            }
            else //chon tat ca cac field
            {
                product = PPCRENTAL.PROPERTY.ToList().Where(x => x.District_ID == district && x.PropertyType_ID == PropertyType);
            }
            return View(product);
        }

        //xem chi tiet 1 du an truyen vao ma id
        public ActionResult Detail(int id)
        {
            var detail = PPCRENTAL.PROPERTY.FirstOrDefault(x => x.ID == id);
            return View(detail);
        }

    }
}