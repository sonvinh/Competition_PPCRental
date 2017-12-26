using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using PPCRental_Project.Models;
using PPCRental_Project.Controllers;
using TechTalk.SpecFlow;
using PPCRental_Project.AcceptanceTests.Common;
using PPCRental_Project.AcceptanceTests.Support;
using FluentAssertions;
using PPCRental_Project;

namespace PPCRental_Project.AcceptanceTests.Drivers
{
    public class SearchDriver
    {
        public ActionResult _result;
        public void Search(string district, string PropertyType, int BedRoom, int BathRoom, int Price_Min, int Price_Max)
        {
            
         int districtID = 0;
            int TypeID = 0;
            using (var ab = new K21T3_Team1_PPC3129Entities())
            {
                if (district != "0")
                {
                    districtID = ab.DISTRICT.FirstOrDefault(x => x.DistrictName == district).ID;
                }
                if (PropertyType != "0")
                {
                    TypeID = ab.PROPERTY_TYPE.FirstOrDefault(x => x.CodeType == PropertyType).ID;
                }
            }

            var controllerProject = new ProjectController();
            _result = controllerProject.Search(districtID, TypeID, BedRoom, BathRoom, Price_Min, Price_Max);
        }
        public void ShowList(Table expectednameList)
        {
            //Arrange
            var expected = expectednameList.Rows.Select(x => x["PropertyName"]);

            var ShownName = _result.Model<IEnumerable<PROPERTY>>();

            //Assert
            PropertyAssertions.HomeScreenShouldShow(ShownName, expected);
        }
    }
}
