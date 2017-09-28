using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Firehose.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IAmACommunityMember[] _members;

        public HomeController(IEnumerable<IAmACommunityMember> members)
        {
            var random = new Random();
            _members = members.OrderBy(r => random.Next()).ToArray();
        }

        [Route("")]
        public ViewResult Index()
        {
            var viewModel = _members;
            return View(viewModel);
        }

        [Route("error")]
        public ActionResult Error()
        {
            return View(TempData["LastError"]);
        }
        
    }
}