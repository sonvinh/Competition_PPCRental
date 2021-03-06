﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PPCRental_Project.Models;
using PPCRental_Project.Controllers;
using PPCRental_Project.Areas.Agency.Controllers;
using TechTalk.SpecFlow;
using PPCRental_Project.AcceptanceTests.Common;
using PPCRental_Project.AcceptanceTests.Support;
using FluentAssertions;
using PPCRental_Project;

namespace PPCRental_Project.AcceptanceTests.Drivers.Project
{
    public class ProjectDriver
    {
        private ActionResult _result;
        private PropertyAgencyController _controller;
        private readonly CatalogContext _context;
        public ProjectDriver(CatalogContext context)
        {
            _context = context;
        }
        public void InsertProjecttoDB(Table givenProjects)
        {
            using (var db = new K21T3_Team1_PPC3129Entities())
            {
                foreach (var row in givenProjects.Rows)
                {
                    var property = new PROPERTY
                    {
                        PropertyName = row["PropertyName"],
                        Content = row["Content"],
                        PropertyType_ID = db.PROPERTY_TYPE.ToList().FirstOrDefault(d => d.CodeType == row["PropertyType"]).ID,
                        Street_ID = db.STREET.ToList().FirstOrDefault(d => d.StreetName == row["Street"]).ID,
                        Ward_ID = db.WARD.ToList().FirstOrDefault(d => d.WardName == row["Ward"]).ID,
                        District_ID = db.DISTRICT.ToList().FirstOrDefault(d => d.DistrictName == row["District"]).ID,
                        Price = int.Parse(row["Price"]),
                        UnitPrice = row["UnitPrice"],
                        Area = row["Area"],
                        BedRoom = int.Parse(row["BedRoom"]),
                        BathRoom = int.Parse(row["BathRoom"]),
                        PackingPlace = int.Parse(row["PackingPlace"]),
                        UserID = int.Parse(row["UserID"]),
                        Created_at = Convert.ToDateTime(row["Create_at"]),
                        Create_post = Convert.ToDateTime(row["Create_post"]),
                        Status_ID = db.PROJECT_STATUS.ToList().FirstOrDefault(x => x.Status_Name == row["Status"]).ID,
                        Note = row["Note"],
                        Updated_at = Convert.ToDateTime(row["Update_at"]),
                        Sale_ID = int.Parse(row["Sale_ID"])
                    };

                    _context.ReferenceProject.Add(
                        givenProjects.Header.Contains("Id") ? row["Id"] : property.PropertyName,
                        property);

                    db.PROPERTY.Add(property);
                }

                db.SaveChanges();
            }
        }
        public void NavigateCreateBook()
        {
            _result = _controller.Create();
        }
        public void CreateProperty(Table inputproperty)
        {
            var row = inputproperty.Rows[0];
            using (var db = new K21T3_Team1_PPC3129Entities())
            {
                var property = new PROPERTY
                {
                    PropertyName = row["PropertyName"],
                    Content = row["Content"],
                    PropertyType_ID = db.PROPERTY_TYPE.ToList().FirstOrDefault(d => d.CodeType == row["PropertyType"]).ID,
                    Street_ID = db.STREET.ToList().FirstOrDefault(d => d.StreetName == row["Street"]).ID,
                    Ward_ID = db.WARD.ToList().FirstOrDefault(d => d.WardName == row["Ward"]).ID,
                    District_ID = db.DISTRICT.ToList().FirstOrDefault(d => d.DistrictName == row["District"]).ID,
                    Price = int.Parse(row["Price"]),
                    UnitPrice = row["UnitPrice"],
                    Area = row["Area"],
                    BedRoom = int.Parse(row["BedRoom"]),
                    BathRoom = int.Parse(row["BathRoom"]),
                    PackingPlace = int.Parse(row["PackingPlace"]),
                    UserID = int.Parse(row["UserID"]),
                    Created_at = Convert.ToDateTime(row["Create_at"]),
                    Create_post = Convert.ToDateTime(row["Create_post"]),
                    Status_ID = db.PROJECT_STATUS.ToList().FirstOrDefault(x => x.Status_Name == row["Status"]).ID,
                    Note = row["Note"],
                    Updated_at = Convert.ToDateTime(row["Update_at"]),
                    Sale_ID = int.Parse(row["Sale_ID"])
                };

                //Save book item into ScenarioContext object so that we can get it in the next step (UploadImage)
                ScenarioContext.Current.Add("property", property);

                //Save the create action into ScenarioContext object so that we can get it in the next step (UploadImage)
                ScenarioContext.Current.Add("isCreated", "Y");
                //_result = _controller.Create(book);
            }
        }
    }
}
