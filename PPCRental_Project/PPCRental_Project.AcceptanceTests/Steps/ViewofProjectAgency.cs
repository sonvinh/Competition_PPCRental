using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PPCRental_Project.AcceptanceTests.Drivers.Property;
namespace PPCRental_Project.AcceptanceTests.Steps
{
    [Binding]
    public sealed class ViewofProjectAgency
    {
        private readonly PropertyDriver _projectDriver;
        public ViewofProjectAgency(PropertyDriver driver)
        {
            _projectDriver = driver;
        }
        

        

    }
}
