using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PPCRental_Project.AcceptanceTests.Drivers.Property;
namespace PPCRental_Project.AcceptanceTests.Steps
{
    [Binding]
    public sealed class ViewofProjectAgency
    {
        private readonly PropertyDriver _projectDriver;
        public ViewofProjectAgency(PropertyDriver driver)
        {
            _projectDriver = driver;
        }
        [When(@"I have navigate to View List of Project page")]
        public void WhenIHaveNavigateToViewListOfProjectPage()
        {
            _projectDriver.GetListFromViewListOfAgencyProject();
        }
        [Then(@"I should see my own projects")]
        public void ThenIShouldSeeMyOwnProjects(Table expectedList)
        {
            _projectDriver.ShowProperty(expectedList);

        }



    }
}
