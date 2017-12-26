using System.Linq;
using TechTalk.SpecFlow;
using PPCRental_Project.AcceptanceTests.Common;
using PPCRental_Project.UITests.Selenium.Support;
using PPCRental_Project.Models;
using OpenQA.Selenium;
using PPCRental_Project.AcceptanceTests.Drivers.Agency;
namespace PPCRental_Project.UITests.Selenium
{
    [Binding, Scope(Tag = "web")]
    public class SearchSteps : SeleniumStepsBase
    {
        
        

        [Then(@"I have navigate to Login page")]
        public void WhenIHaveNavigateToLoginPage()
        {
            
        }

        [Then(@"I entered '(.*)' and '(.*)'")]
        public void WhenIEnteredAnd(string email, string password)
        {
           
        }
    }
}
