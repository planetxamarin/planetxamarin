using System;
using System.Web.Mvc;

namespace Firehose.Web.Controllers
{
    public class HomeController : BaseController
    {
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [Route("error")]
        public ActionResult Error()
        {
            return View(TempData["LastError"]);
        }
    }
}