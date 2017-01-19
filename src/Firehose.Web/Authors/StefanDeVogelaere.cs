using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class StefanDeVogelaere : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Stefan";
        public string GitHubHandle => "stefandevo";

        public string LastName => "de Vogelaere";
        public string ShortBioOrTagLine => "";
        public string StateOrRegion => "Wommelgem, Belgium";
        public string EmailAddress => "stefan.de.vogelaere@gmail.com";
        public string TwitterHandle => "stefandevo";

        public Uri WebSite => new Uri("http://www.stefandevo.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.stefandevo.com/feed/"); }
        }

        public string GravatarHash => "c91dbad10c922f0fef71e9e2df15b763";
        public GeoPosition Position => new GeoPosition(51.2021680, 4.5219650);

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(i => i.Name.Equals("xamarin", StringComparison.OrdinalIgnoreCase));
        }
    }
}
