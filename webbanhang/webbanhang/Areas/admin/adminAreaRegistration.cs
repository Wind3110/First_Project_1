using System.Web.Mvc;

namespace webbanhang.Areas.admin
{
    public class adminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "admin_default",
                "admin/{controller}/{action}/{id}",
                new { controller = "Back", action = "adminlogin", id = UrlParameter.Optional },
                new string[] { "webbanhang.Areas.admin.Controllers" }
            );
        }
    }
}
