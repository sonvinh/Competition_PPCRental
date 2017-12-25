using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using PPCRental_Project.AcceptanceTests.Drivers.Property;


namespace PPCRental_Project.AcceptanceTests.Steps
{
    [Binding]
    public sealed class PropertyDetailStep
    {
        private readonly PropertyDriver _propertyDriver;
        public PropertyDetailStep(PropertyDriver driver)
        {
            _propertyDriver = driver;
        }
        [Given(@"I open details of '(.*)'")]
        public void GivenIOpenDetailsOf(string propertyID)
        {
            _propertyDriver.OpenPropertyIdDetails(propertyID);
        }

        [Then(@"The property details have be show")]
        public void ThenThePropertyDetailsHaveBeShow(Table table)
        {
            _propertyDriver.ShowPropertyDetails(table);
        }

    }
}
