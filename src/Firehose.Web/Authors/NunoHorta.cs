using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class NunoHorta : IAmACommunityMember
    {
        public string FirstName => "Nuno";

        public string LastName => "Horta";

        public string StateOrRegion => "London, United Kindgom";

        public string EmailAddress => "nunobhorta@gmail.com";

        public string ShortBioOrTagLine => string.Empty;

        public Uri WebSite => new Uri("https://nunobhorta.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.nunobhorta.com/feed/"); }
        }

        public string TwitterHandle => "nunobhorta";

        public string GravatarHash => "";

        public string GitHubHandle => string.Empty;
        public GeoPosition Position => new GeoPosition(51.5073510, -0.1277580);

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
        }
    }
}