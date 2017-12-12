using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PPCRental_Project.AcceptanceTests.Steps
{
    [Binding]
    public class FilterSteps
    {
        IWebDriver driver = new FirefoxDriver();
        [Given(@"I in homepage")]
        public void GivenIInHomepage()
        {
            driver.Navigate().GoToUrl("http://localhost:61656/Home/Index");
        }
        
        [Given(@"I choose district")]
        public void GivenIChooseDistrict()
        {
            driver.FindElement(By.Id("test")).Click();

        }
        
        [When(@"I press filter")]
        public void WhenIPressFilter()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result show project in district i chosen")]
        public void ThenTheResultShowProjectInDistrictIChosen()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
