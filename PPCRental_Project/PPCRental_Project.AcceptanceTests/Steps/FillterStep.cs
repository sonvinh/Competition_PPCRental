using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PPCRental_Project.AcceptanceTests.Drivers;

namespace PPCRental_Project.AcceptanceTests.Steps;
{
    [Binding, Scope(Tag = "automation")]
    public sealed class FillterStep
    {
        private readonly SearchDriver _searchdriver;
        public FillterStep(SearchDriver driver) { _searchdriver = driver; }
        [When(@"I input '(.*)' to district filter into Homepage")]
        public void WhenIInputToDistrictFilterIntoHomepage(string district)
        {
            _searchdriver.Search(district, "0", 0, 0, 0, 0);
        }

        [Then(@"I should see property")]
        public void ThenIShouldSeeProperty(Table table)
        {
             _searchdriver.ShowList(table);
    }

        [When(@"I input '(.*)' to propertytype field and click search into Homepage")]
        public void WhenIInputToPropertytypeFieldAndClickSearchIntoHomepage(string Type)
        {
            _searchdriver.Search("0", Type, 0, 0, 0, 0);
    }

        [Then(@"I should see property with type is Apartment")]
        public void ThenIShouldSeePropertyWithTypeIsApartment(Table table)
        {
           _searchdriver.ShowList(table);
    }

        [When(@"I input '(.*)' in district field and '(.*)' in property_type field and click search into Homepage")]
        public void WhenIInputInDistrictFieldAndInProperty_TypeFieldAndClickSearchIntoHomepage(string district, string Type)
        {
            _searchdriver.Search(district, Type, 0, 0, 0, 0);
    }

        [Then(@"I should see property list")]
        public void ThenIShouldSeePropertyList(Table table)
        {
            _searchdriver.ShowList(table);
    }

        [When(@"I input '(.*)' in district field, '(.*)' in property_type field, chosen bed room '(.*)' click search into Homepage")]
        public void WhenIInputInDistrictFieldInProperty_TypeFieldChosenBedRoomClickSearchIntoHomepage(string district, string Type, int bedroom)
        {
            _searchdriver.Search(district, Type, bedroom, 0, 0, 0);
    }

        [Then(@"I should see property in district(.*) and type is Apartment and have (.*)bedroom")]
        public void ThenIShouldSeePropertyInDistrictAndTypeIsApartmentAndHaveBedroom(int p0, int p1, Table table)
        {
            _searchdriver.ShowList(table);
    }

    }
}
