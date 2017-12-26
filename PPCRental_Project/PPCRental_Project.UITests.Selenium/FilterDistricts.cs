using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using PPCRental_Project.AcceptanceTests.Common;
using PPCRental_Project.Models;
using OpenQA.Selenium;
using System.Threading;

namespace PPCRental_Project.UITests.Selenium
{
    [Binding]
    public sealed class FilterDistricts
    {
        IWebDriver driver = new FirefoxDriver();
        [Given(@"I in the homepage")]
        public void GivenIInTheHomepage()
        {
            driver.Navigate().GoToUrl("http://localhost:61656/");
            Thread.Sleep(700);
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.scrollBy(0,800)", "");
        }

        [When(@"I chosen '(.*)' in district field and click search")]
        public void WhenIChosenInDistrictFieldAndClickSearch(string p0)
        {
            var option = driver.FindElement(By.Id("test"));
            var selectelement = new SelectElement(option);
            selectelement.SelectByText(p0);
            driver.FindElement(By.Id("btnfilter")).Click();
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.scrollBy(0,1000)", "");
            Thread.Sleep(700);
        }

        [Then(@"I will see list property'(.*)'")]
        public void ThenIWillSeeListProperty(string expectedTitles)
        {
            var expectedResult = expectedTitles.Split(',').Select(x => x.Trim('\''));
            driver.SwitchTo().DefaultContent();

            var viewdetail = from row in driver.FindElements(By.XPath("//div[contains(@class,'caption')]/h4"))
                             let Name = row.Text
                             select new PROPERTY { PropertyName = Name };
            PropertyAssertions.HomeScreenShouldShow(viewdetail, expectedResult);
        }

    }
}
