using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class StefanRiedmann : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Stefan";
        public string GitHubHandle => "StefanRiedmann";

        public string LastName => "Riedmann";
        public string ShortBioOrTagLine => "Growing software";
        public string StateOrRegion => "Mendoza, Argentina and Gemünden, Germany";
        public string EmailAddress => "stefan.riedmann@ciclosoftware.com";
        public string TwitterHandle => "CicloSoftware";

        public Uri WebSite => new Uri("https://www.ciclosoftware.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.ciclosoftware.com/feed/"); }
        }

        public string GravatarHash => "2781a55d04634584326bedfe08660537";
        public GeoPosition Position => new GeoPosition(-32.8886904, -68.8481432);

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(i => i.Name.Equals("xamarin", StringComparison.OrdinalIgnoreCase));
        }
    }
}