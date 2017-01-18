using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class SvenMichaelStuebe : IAmAMicrosoftMVP, IFilterMyBlogPosts
    {
        public string FirstName => "Sven-Michael";
        public string LastName => "Stübe";
        public string Title => "software engineer at Zühlke";
        public string StateOrRegion => "Munich, Germany";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "stuebe2k14";
        public string GithubHandle => string.Empty;

        public Uri WebSite => new Uri("http://smstuebe.de/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://smstuebe.de/feed.xml"); }
        }

        DateTime IAmAMicrosoftMVP.FirstAwarded => new DateTime(2017, 1, 1);
        public string GravatarHash => "08b73d0a58fc120a8cc8dc561d83b3d6";

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
        }
    }
}
