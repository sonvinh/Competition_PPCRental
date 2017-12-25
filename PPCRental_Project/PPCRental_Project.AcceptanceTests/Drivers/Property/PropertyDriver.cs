using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPCRental_Project.Models;
using PPCRental_Project.AcceptanceTests.Support;
using PPCRental_Project.Controllers;
using FluentAssertions;
using TechTalk.SpecFlow;
using System.Web.Mvc;
using PPCRental_Project.Areas.Agency.Controllers;

using PPCRental_Project.AcceptanceTests.Common;
using System.Web;

namespace PPCRental_Project.AcceptanceTests.Drivers.Property
{
    public class PropertyDriver
    {
        K21T3_Team1_PPC3129Entities db = new K21T3_Team1_PPC3129Entities();
        K21T3_Team1_PPC3129Entities ab = new K21T3_Team1_PPC3129Entities();
        private readonly CatalogContext _context;
        private ActionResult _result;
        public PropertyDriver(CatalogContext _Context)
        {
            _context = _Context;

        }
        public void NavigateToPostPage()
        {
            K21T3_Team1_PPC3129Entities get = new K21T3_Team1_PPC3129Entities();
            Controllers.AccountController user = new Controllers.AccountController();

            var controller = new PropertyAgencyController();

            var moqContext = new Moq.Mock<ControllerContext>();
            var moqSession = new Moq.Mock<HttpSessionStateBase>();
            moqContext.Setup(c => c.HttpContext.Session).Returns(moqSession.Object);

            var us = get.USER.FirstOrDefault(x => x.Email == "user@ppc.com");
            //user.ControllerContext = moqContext.Object;

            controller.ControllerContext = moqContext.Object;
            moqSession.Setup(s => s["UserRole"]).Returns(us.Role);
            moqSession.Setup(s => s["UserID"]).Returns(us.ID);

            _result = controller.Index();

        }
        public void InsertPropertyToDB(Table Property)
        {

            using (db)
            {

                foreach (var row in Property.Rows)
                {

                    string propertyID = row["Property Type"];
                    string userID = row["Owner"];
                    string wardID = row["Ward"];
                    string districtID = row["District"];
                    string streetID = row["Street"];
                    string statusID = row["Status"];
                    var property = new PROPERTY
                    {

                        PropertyName = row["PropertyName"],
                        Price = int.Parse(row["Price"]),

                        Avatar = row["Avatar"],
                        Images = row["Images"],
                        UnitPrice = row["UnitPrice"],
                        Ward_ID = db.WARD.FirstOrDefault(d => d.WardName == wardID).ID,
                        UserID = db.USER.FirstOrDefault(d => d.Email == userID).ID,
                        Street_ID = db.STREET.FirstOrDefault(d => d.StreetName == streetID).ID,
                        District_ID = db.DISTRICT.FirstOrDefault(d => d.DistrictName == districtID).ID,
                        Area = row["Area"],
                        BedRoom = int.Parse(row["BedRoom"]),
                        BathRoom = int.Parse(row["BathRoom"]),
                        PackingPlace = int.Parse(row["ParkingPlace"]),
                        Created_at = DateTime.Parse(row["Created_at"]),
                        Create_post = DateTime.Parse(row["Created_post"]),
                        Note = row["Note"],
                        Updated_at = DateTime.Parse(row["Updated_at"]),
                        Status_ID = db.PROJECT_STATUS.FirstOrDefault(d => d.Status_Name == statusID).ID,
                        //Property_ID = row["Property_ID"],
                        Content = row["Content"],
                        PropertyType_ID = db.PROPERTY_TYPE.FirstOrDefault(d => d.CodeType == propertyID).ID,


                    };

                    _context.ReferenceProject.Add(
                            Property.Header.Contains("ID") ? row["ID"] : property.PropertyName,
                            property);

                    db.PROPERTY.Add(property);
                }

                //db.Entry(Property).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
        public void CreateProperty(Table Property)
        {
            using (ab)
            {

                foreach (var row in Property.Rows)
                {

                    string propertyID = row["Property Type"];
                    string userID = row["Owner"];
                    string wardID = row["Ward"];
                    string districtID = row["District"];
                    string streetID = row["Street"];
                    string statusID = row["Status"];
                    var property = new PROPERTY
                    {

                        PropertyName = row["PropertyName"],
                        Price = int.Parse(row["Price"]),

                        Avatar = row["Avatar"],
                        Images = row["Images"],
                        UnitPrice = row["UnitPrice"],
                        Ward_ID = ab.WARD.FirstOrDefault(d => d.WardName == wardID).ID,
                        UserID = ab.USER.FirstOrDefault(d => d.Email == userID).ID,
                        Street_ID = ab.STREET.FirstOrDefault(d => d.StreetName == streetID).ID,
                        District_ID = ab.DISTRICT.FirstOrDefault(d => d.DistrictName == districtID).ID,
                        Area = row["Area"],
                        BedRoom = int.Parse(row["BedRoom"]),
                        BathRoom = int.Parse(row["BathRoom"]),
                        PackingPlace = int.Parse(row["ParkingPlace"]),
                        Created_at = DateTime.Parse(row["Created_at"]),
                        Create_post = DateTime.Parse(row["Created_post"]),
                        Note = row["Note"],
                        Updated_at = DateTime.Parse(row["Updated_at"]),
                        Status_ID = ab.PROJECT_STATUS.FirstOrDefault(d => d.Status_Name == statusID).ID,
                        //Property_ID = row["Property_ID"],
                        Content = row["Content"],
                        PropertyType_ID = ab.PROPERTY_TYPE.FirstOrDefault(d => d.CodeType == propertyID).ID,


                    };

                    _context.ReferenceProject.Add(
                            Property.Header.Contains("ID") ? row["ID"] : property.PropertyName,
                            property);

                    ab.PROPERTY.Add(property);
                }

                //db.Entry(Property).State = System.Data.Entity.EntityState.Modified;
                ab.SaveChanges();
            }
        }
        
        public void ShowProperty(Table expectedProperty) => ShowProperty(expectedProperty.Rows.Select(r => r["PropertyName"]));
        public void ShowProperty(IEnumerable<string> expectedTitles)
        {
            //Act

            var shownBooks = _result.Model<IEnumerable<PROPERTY>>();

            //Assert
            PropertyAssertions.ManageShouldShowList(shownBooks, expectedTitles);

        }
        public void OpenPropertyIdDetails(string propertyId)
        {
            var property = _context.ReferenceProject.GetById(propertyId);
            using (var controller = new ProjectController())
            {
                _result = controller.Detail(property.ID);
            }


        }
        public void ShowPropertyDetails(Table shownPropertyDetails)
        {
            //Arrange
            K21T3_Team1_PPC3129Entities dbt = new K21T3_Team1_PPC3129Entities();
            var expectedPropertyDetails = shownPropertyDetails.Rows.Single();
            string exPropertyName = expectedPropertyDetails["PropertyName"];
            string exAvatar = expectedPropertyDetails["Avatar"];
            string exOwner = expectedPropertyDetails["Owner"];
            var userID = dbt.USER.FirstOrDefault(d => d.Email == exOwner).ID;
            string exContent = expectedPropertyDetails["Content"];
            string exPrice = expectedPropertyDetails["Price"];
            //Act
            var actualPropertyDetails = _result.Model<PROPERTY>();

            //Assert
            actualPropertyDetails.Should().Match<PROPERTY>(
                b => b.PropertyName == exPropertyName
                && b.Avatar == exAvatar
                && b.UserID == userID
                && b.Content == exContent
                && b.Price == int.Parse(exPrice));
        }
        public void GetListFromViewListOfProject()
        {
            K21T3_Team1_PPC3129Entities get = new K21T3_Team1_PPC3129Entities();
            AccountController user = new AccountController();

            var controller = new PropertyAgencyController();

            var moqContext = new Moq.Mock<ControllerContext>();
            var moqSession = new Moq.Mock<HttpSessionStateBase>();
            moqContext.Setup(c => c.HttpContext.Session).Returns(moqSession.Object);

            var us = get.USER.FirstOrDefault(x => x.Email == "sale10@ppc.com");
            //user.ControllerContext = moqContext.Object;

            controller.ControllerContext = moqContext.Object;
            moqSession.Setup(s => s["UserRole"]).Returns(us.Role);
            moqSession.Setup(s => s["UserID"]).Returns(us.ID);
            _result = controller.Index();

        }
        public void GetListFromViewListOfAgencyProject()
        {
            K21T3_Team1_PPC3129Entities get = new K21T3_Team1_PPC3129Entities();
            AccountController user = new AccountController();

            var controller = new PropertyAgencyController();

            var moqContext = new Moq.Mock<ControllerContext>();
            var moqSession = new Moq.Mock<HttpSessionStateBase>();
            moqContext.Setup(c => c.HttpContext.Session).Returns(moqSession.Object);

            var us = get.USER.FirstOrDefault(x => x.Email == "user@ppc.com");
            //user.ControllerContext = moqContext.Object;

            controller.ControllerContext = moqContext.Object;
            moqSession.Setup(s => s["UserRole"]).Returns(us.Role);
            moqSession.Setup(s => s["UserID"]).Returns(us.ID);

            _result = controller.Index();
        }
    }
    
}
