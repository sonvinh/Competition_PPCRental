using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PPCRental_Project.AcceptanceTests.Drivers.Property;
namespace PPCRental_Project.AcceptanceTests.Steps
{
    [Binding]
    public sealed class PostProperty
    {
        private PropertyDriver _prodriver;
        public PostProperty(PropertyDriver pdriver)
        {
            _prodriver = pdriver;

        }

        [Given(@"the following properties")]
        public void GivenTheFollowingProperties(Table table)
        {
            _prodriver.InsertPropertyToDB(table);
        }

        [When(@"I have navigate to Post page")]
        public void WhenIHaveNavigateToPostPage()
        {
            _prodriver.NavigateToPostPage();
        }

        [When(@"I entered the following information")]
        public void WhenIEnteredTheFollowingInformation(Table table)
        {
            _prodriver.CreateProperty(table);
        }
        [When(@"I have navigate to View List of Agency Project")]
        public void WhenIHaveNavigateToViewListOfAgencyProject()
        {
            _prodriver.GetListFromViewListOfAgencyProject();
        }
        [Then(@"The list of properties shoul have my new property")]
        public void ThenTheListOfPropertiesShoulHaveMyNewProperty(Table table)
        {
            _prodriver.ShowProperty(table);
        }
    }
}
