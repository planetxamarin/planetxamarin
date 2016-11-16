using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Controllers
{
    public class WhoAreWeController : Controller
    {
        private readonly IAmAReadifarian[] _readifarians;

        public WhoAreWeController(IEnumerable<IAmAReadifarian> readifarians)
        {
            var random = new Random();
            _readifarians = readifarians.OrderBy(r => random.Next()).ToArray();
        }

        public ActionResult Readifarians()
        {
            var viewModel = _readifarians;
            return View(viewModel);
        }
    }
}