using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Controllers
{
    public class WhoAreWeController : Controller
    {
        private readonly IAmACommunityMember[] _members;

        public WhoAreWeController(IEnumerable<IAmACommunityMember> members)
        {
            var random = new Random();
            _members = members.OrderBy(r => random.Next()).ToArray();
        }

        public ActionResult Members()
        {
            var viewModel = _members;
            return View(viewModel);
        }
    }
}