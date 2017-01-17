using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Authors
{
    public class StevenThewissen : IFilterMyBlogPosts
    {
        public string FirstName => "Steven";

        public string LastName => "Thewissen";

        public string StateOrRegion => "The Netherlands";

        public string EmailAddress => "";

        public string Title => "Xamarin Developer";

        public Uri WebSite => new Uri("http://www.dvolve.org/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.dvolve.org/feed/"); }
        }

        public string TwitterHandle => "devnl";

        public string GravatarHash => "9f698e6f515cb54dbda305034b6823fc";

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
        }
    }
}
