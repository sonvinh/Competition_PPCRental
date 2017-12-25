﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPCRental_Project.Models;
using PPCRental_Project.AcceptanceTests.Support;
using PPCRental_Project.Areas.Agency.Controllers;
using PPCRental_Project.Controllers;
using PPCRental_Project.Areas.Admin.Controllers;
using PPCRental_Project.AcceptanceTests.Common;
using FluentAssertions;
using TechTalk.SpecFlow;
using System.Web.Mvc;
using System.Web;

namespace PPCRental_Project.AcceptanceTests.Drivers.Sale
{
    public class SaleDriver
    {
        K21T3_Team1_PPC3129Entities db = new K21T3_Team1_PPC3129Entities();
        private readonly CatalogContentU _content;
        private ActionResult _result;
        private PPCRental_Project.Controllers.AccountController agency;
        public USER us;
        public SaleDriver(CatalogContentU context)
        {
            _content = context;
        }
        public void InserttoDB(Table us)
        {
            using (db)
            {
                foreach (var row in us.Rows)
                {
                    var user = new USER
                    {
                        Email = row["email"],
                        Password = row["password"],
                        FullName = row["fullname"],
                        Phone = row["phone"],
                        Address = row["address"],
                        Role = row["role"],
                        Status = true,


                    };
                    _content.ReferenceUsers.Add(us.Header.Contains("ID") ? row["ID"] : user.Email, user);
                    db.USER.Add(user);
                }
                db.SaveChanges();
            }
            
        }
        public void NavigateTo()
        {
            using (var controller = new PPCRental_Project.Areas.Admin.Controllers.AccountController())
            {
                _result = controller.Login();
            }
        }
        public void Login(string email, string password)
        {
            agency = new PPCRental_Project.Controllers.AccountController();
            db = new K21T3_Team1_PPC3129Entities();
            us = db.USER.FirstOrDefault(d => d.Email == email);

            var moqContext = new Moq.Mock<ControllerContext>();
            var moqSession = new Moq.Mock<HttpSessionStateBase>();
            moqContext.Setup(c => c.HttpContext.Session).Returns(moqSession.Object);
            agency.ControllerContext = moqContext.Object;
            moqSession.Setup(s => s["UserRole"]).Returns("0");

            us.Email = email;
            us.Password = password;

            agency.Login(email, password);
        }
        public void GetListFromViewListOfAgencyProjectSale()
        {
            K21T3_Team1_PPC3129Entities get = new K21T3_Team1_PPC3129Entities();
            

            var controller = new PropertyAgencyController();

            var moqContext = new Moq.Mock<ControllerContext>();
            var moqSession = new Moq.Mock<HttpSessionStateBase>();
            moqContext.Setup(c => c.HttpContext.Session).Returns(moqSession.Object);

            var us = get.USER.FirstOrDefault(x => x.Email == "admin12@ppc.com");
            //user.ControllerContext = moqContext.Object;

            controller.ControllerContext = moqContext.Object;
            moqSession.Setup(s => s["UserRole"]).Returns(us.Role);
            moqSession.Setup(s => s["UserID"]).Returns(us.ID);

            _result = controller.Index();
        }
        public void ShowProperty(Table expectedProperty) => ShowProperty(expectedProperty.Rows.Select(r => r["PropertyName"]));
        public void ShowProperty(IEnumerable<string> expectedTitles)
        {
            //Act

            var shownBooks = _result.Model<IEnumerable<PROPERTY>>();

            //Assert
            PropertyAssertions.ManageShouldShowList(shownBooks, expectedTitles);

        }
    }
}
