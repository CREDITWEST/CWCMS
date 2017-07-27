using System.Web.Mvc;
using System.Web.Routing;

namespace CWCMS.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Add",
                url: "{controller}/{action}",
                defaults: new { controller = "Add", action = "Index" }
            );
            routes.MapRoute(
                name: "Edit",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Edit", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
