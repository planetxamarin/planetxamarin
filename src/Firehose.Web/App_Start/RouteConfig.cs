using System.Web.Mvc;
using System.Web.Routing;

namespace Firehose.Web.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.RouteExistingFiles = true;   // otherwise "/authors" maps to IIS filesystem directory of Authors
            routes.MapMvcAttributeRoutes();
        }
    }
}