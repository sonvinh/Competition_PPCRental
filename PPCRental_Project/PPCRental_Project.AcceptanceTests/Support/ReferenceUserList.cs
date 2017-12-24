using System;
using System.Collections.Generic;
using FluentAssertions;
using PPCRental_Project.Models;
namespace PPCRental_Project.AcceptanceTests.Support
{
    public class ReferenceUserList : Dictionary<string, USER>
    {
        public USER GetbyID(string usID)
        {
            return this[usID.Trim()].Should().NotBeNull()
                .And.Subject.Should().BeOfType<USER>().Which;
        }
    }
}
