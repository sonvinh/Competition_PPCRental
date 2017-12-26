using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using PPCRental_Project.AcceptanceTests.Drivers.Project;

namespace PPCRental_Project.AcceptanceTests.Steps
{
    [Binding]
    public sealed class Insert
    {
        private readonly ProjectDriver _inserDriver;

        public Insert(ProjectDriver driver) { _inserDriver = driver; }
        [Given(@"the following property")]
        public void GivenTheFollowingProperty(Table table)
        {
            _inserDriver.InsertProjecttoDB(table);
        }
    }
}
