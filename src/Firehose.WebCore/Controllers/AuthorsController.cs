﻿using System;
using System.Collections.Generic;
using System.Linq;
using Firehose.Web.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Firehose.Web.Controllers
{
    public class AuthorsController : BaseController
    {
        private readonly IAmACommunityMember[] _members;

        public AuthorsController(IEnumerable<IAmACommunityMember> members)
        {
            var random = new Random();
            _members = members.OrderBy(r => random.Next()).ToArray();
        }

        [Route("authors")]
        public ViewResult Index()
        {
            var viewModel = _members;
            return View(viewModel);
        }
    }
}