using System.Web.Mvc;
using System.Web.Routing;

namespace Firehose.Web.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Feed", "Feed/{action}/{numPosts}", defaults: new { controller = "Feed" });
            routes.MapRoute("Default", "{controller}/{action}/{id}", new {controller = "Home", action = "Index", id = UrlParameter.Optional});
        }
    }
}