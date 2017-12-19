using System.Web.Mvc;

namespace PPCRental_Project.Areas.Engineer
{
    public class EngineerAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Engineer";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Engineer_default",
                "Engineer/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "PPCRental_Project.Areas.Engineer.Controllers" }
            );
        }
    }
}