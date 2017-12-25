using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using PPCRental_Project.AcceptanceTests.Drivers.Property;
using PPCRental_Project.UITests.Selenium.Support;

namespace PPCRental_Project.UITests.Selenium
{
    [Binding , Scope(Tag ="web")]
    class postProject
    {
        private PropertyDriver _prodriver;
        [Given(@"the following properties")]
        public void GivenTheFollowingProperties(Table table)
        {
            _prodriver.InsertPropertyToDB(table);
        }

        [When(@"I have navigate to Post page")]
        public void WhenIHaveNavigateToPostPage()
        {
            
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
