using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PPCRental_Project.AcceptanceTests.Drivers.Agency;
namespace PPCRental_Project.AcceptanceTests.Steps
{
    [Binding]
    public sealed class Loginstep
    {
        private readonly AgencyDriver _agencydriver;
        public Loginstep(AgencyDriver driver)
        {
            _agencydriver = driver;
        }
        [Given(@"the following account")]
        public void GivenTheFollowingAccount(Table table)
        {
            _agencydriver.InserttoDB(table);
        }

        [When(@"I have navigate to Login page")]
        public void WhenIHaveNavigateToLoginPage()
        {
            _agencydriver.Navigate();
        }

        [When(@"I entered '(.*)' and '(.*)'")]
        public void WhenIEnteredAnd(string email, string password)
        {
            _agencydriver.Login(email , password);
        }


    }
}
