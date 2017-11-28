﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Project.Models;

namespace PPCRental_Project.Controllers
{
    public class AccountController : Controller
    {
        K21T3_Team1_PPC3129Entities model = new K21T3_Team1_PPC3129Entities();
        //
        // GET: /Account/
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            var user = model.USER.FirstOrDefault(x => x.Email == email);
            if (user != null)
            {
                if (user.Password.Equals(password))
                {
                    Session["Fullname"] = user.FullName;
                    Session["UserID"] = user.ID;
                    if (user.Role.Equals("1")) 
                    {
                        return RedirectToAction("Index", "Agency/PropertyAgency");
                    }
                    else 
                    {
                        return RedirectToAction("Index", "Admin/PropertyAdmin");
                    }

                }
            }
            else
            {
                ViewBag.message = "Email hoac mat khau khong hop le!";
            }
            return View();
        }

        [HttpGet]
        public ActionResult LogOut()
        {

            Session["FullName"] = null;
            Session["UserID"] = null;

            return RedirectToAction("Index","Home");
        }
    }
}