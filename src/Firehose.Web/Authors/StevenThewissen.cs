using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class StevenThewissen : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Steven";

        public string LastName => "Thewissen";

        public string StateOrRegion => "The Netherlands";

        public string EmailAddress => "";

        public string ShortBioOrTagLine => " is a Xamarin Developer with a knack for Photoshop and a passion for soccer and cycling. He is also in love with his Xbox One";

        public Uri WebSite => new Uri("http://www.dvolve.org/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.dvolve.org/feed/"); }
        }

        public string TwitterHandle => "devnl";

        public string GravatarHash => "9f698e6f515cb54dbda305034b6823fc";

        public GeoPosition Position => new GeoPosition(50.889039, 5.853717);

        public string GitHubHandle => "dvolvenl";

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
        }
    }
}
