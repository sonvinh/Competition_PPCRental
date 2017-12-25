using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PPCRental_Project.AcceptanceTests.Drivers.Sale;
using PPCRental_Project.AcceptanceTests.Drivers.Property;
namespace PPCRental_Project.AcceptanceTests.Steps
{
    [Binding]
    public sealed class viewListOfProjectAgencySaleStep
    {
        private readonly SaleDriver _saleDriver;
        private readonly PropertyDriver _propertyDriver;
        public viewListOfProjectAgencySaleStep(SaleDriver driver)
        {
            _saleDriver = driver;
        }
        [When(@"I have navigate to View List of Project page sale")]
        public void WhenIHaveNavigateToViewListOfProjectPageSale()
        {
            _saleDriver.GetListFromViewListOfAgencyProjectSale();
        }

        [Then(@"I should see my own projects sale")]
        public void ThenIShouldSeeMyOwnProjectsSale(Table expectedList)
        {
            _saleDriver.ShowProperty(expectedList);
        }

    }
}
