using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCRental_Project.AcceptanceTests.Support
{
    public class CatalogContentU
    {
        public CatalogContentU()
        {
            ReferenceUsers = new ReferenceUserList();
        }
        public ReferenceUserList ReferenceUsers { get; set; }
    }
}
