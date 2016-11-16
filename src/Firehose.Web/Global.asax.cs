using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Firehose.Web.App_Start;

namespace Firehose.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            ContainerConfig.Configure();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_End()
        {
            ContainerConfig.TearDown();
        }
    }
}