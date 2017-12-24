using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPCRental_Project.Controllers;
using System.Web.Mvc;
using TechTalk.SpecFlow;
using PPCRental_Project.Models;
using PPCRental_Project.AcceptanceTests.Support;
using PPCRental_Project.AcceptanceTests.Common;

namespace PPCRental_Project.AcceptanceTests.Drivers.Home
{
    class HomeDriver
    {
        private ActionResult _result;

        public void Navigate()
        {
            using (var controller = new HomeController())
            {
                _result = controller.Index();
            }
        }
        public void ShowProperty(Table expectedProperty)
        => ShowProperty(expectedProperty.Rows.Select(r => r["PropertyName"]));

        public void ShowProperty(IEnumerable<string> expectedTitles)
        {
            //Act
            var shownBooks = _result.Model<IEnumerable<PROPERTY>>();

            //Assert
            PropertyAssertions.HomeScreenShouldShow(shownBooks, expectedTitles);
        }
    }
}
