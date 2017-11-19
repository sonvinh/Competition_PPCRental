﻿using System;
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
        public ActionResult Search(int district, int PropertyType, int BedRoom, int BathRoom, int Price_Min, int Price_Max)
        {
            var product = PPCRENTAL.PROPERTY.Where(p => p.Status_ID == 3);
            if (district != 0)
            {
                product = product.Where(p => p.District_ID == district);
            }
            if (PropertyType != 0)
            {
                product = product.Where(p => p.PropertyType_ID == PropertyType);
            }
            if (BedRoom != 0)
            {
                product = product.Where(p => p.BedRoom == BedRoom);
            }
            if (BathRoom != 0)
            {
                product = product.Where(p => p.BathRoom == BathRoom);
            }
            if (Price_Min != 0)
            {
                product = product.Where(p => p.Price >= Price_Min);
            }
            if (Price_Max != 0)
            {
                product = product.Where(p => p.Price <= Price_Max);
            }
            if (district == 0 && PropertyType == 0 && BedRoom == 0 && BathRoom == 0 && Price_Min == 0 && Price_Max == 0)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(product.ToList());
            }

        }

        //xem chi tiet 1 du an truyen vao ma id
        public ActionResult Detail(int id)
        {
            var detail = PPCRENTAL.PROPERTY.FirstOrDefault(x => x.ID == id);
            return View(detail);
        }

    }
}