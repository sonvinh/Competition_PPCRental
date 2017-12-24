using PPCRental_Project.Models;
using System.Linq;
using TechTalk.SpecFlow;

namespace PPCRental_Project.AcceptanceTests.Support
{
    [Binding]
    public class DatabaseTools
    {
        [BeforeScenario]
        public void CleanDatabase()
        {
            using (var db = new K21T3_Team1_PPC3129Entities())
            {
                var un = db.USER.Where(x => x.ID > 9).ToList();
                db.PROPERTY.RemoveRange(db.PROPERTY);
                db.USER.RemoveRange(un);
                db.SaveChanges();
            }
        }
    }
}
