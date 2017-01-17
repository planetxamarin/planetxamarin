using System.Web.Mvc;

namespace Firehose.Web.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}