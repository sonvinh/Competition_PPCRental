using PPCRental_Project.AcceptanceTests.Drivers.Home;
using System;
using TechTalk.SpecFlow;

namespace PPCRental_Project.AcceptanceTests.Steps
{
    [Binding]
    class HomeScreenstep
    {

        private readonly HomeDriver _homeDriver;
        public HomeScreenstep(HomeDriver _HomeDriver)
        {
            _homeDriver = _HomeDriver;
        }
        [When(@"I am at Home page")]
        public void WhenIAmAtHomePage()
        {
            _homeDriver.Navigate();
        }
    }
}
