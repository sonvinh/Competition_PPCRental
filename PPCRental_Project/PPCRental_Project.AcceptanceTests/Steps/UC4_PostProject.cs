using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using PPCRental_Project.AcceptanceTestS.
using PPCRental_Project.AcceptanceTests.Driver.PropertyDetails;

namespace PPCRental_Project.AcceptanceTests.Steps
{
    [Binding]
    public sealed class UC4_PostProject
    {
        [Binding, Scope(Tag = "automated")]
        public class PostPropertyBackground
        {
            private readonly SearchDriver _searchDriver;

            public PostPropertyBackground(SearchDriver drivers)
            {
                _searchDriver = drivers;
            }

            [When(@"I input the following information")]
        public void WhenIInputTheFollowingInformation(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the list of books should update")]
        public void ThenTheListOfBooksShouldUpdate(Table table)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
