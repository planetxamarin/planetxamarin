﻿using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MergeConflict : IAmACommunityMember
    {
        public string FirstName => "Merge";

        public string LastName => "Conflict";

        public string StateOrRegion => "Seattle, WA";

        public string EmailAddress => "mergeconflictfm@gmail.com";

        public string ShortBioOrTagLine => "is a weekly development podcast hosted by Frank Krueger and James Montemagno.";

        public Uri WebSite => new Uri("http://mergeconflict.fm");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://simplecast.com/podcasts/2117/rss"); }
        }

        public string TwitterHandle => "MergeConflictFM";

        public string GravatarHash => "24527eb9b29a8adbfc4155db4044dd3c";
        public string GitHubHandle => string.Empty;
    }
}