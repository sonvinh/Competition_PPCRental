using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PPCRental_Project.AcceptanceTests.Drivers.Sale;

namespace PPCRental_Project.AcceptanceTests.Steps
{
    [Binding]
    public sealed class LoginAdminSteps
    {
        private readonly SaleDriver _saledriver;
        public LoginAdminSteps(SaleDriver driver)
        {
            _saledriver = driver;
        }
        [Given(@"the following account:")]
        public void GivenTheFollowingAccount(Table table)
        {
            _saledriver.InserttoDB(table);
        }


        [When(@"I have navigate to login admin page")]
        public void WhenIHaveNavigateToLoginAdminPage()
        {
            _saledriver.NavigateTo();
        }


        [Then(@"I enter '(.*)' and '(.*)'")]
        public void ThenIEnterAnd(string email, string password)
        {
            _saledriver.Login(email, password);
        }


    }
}
