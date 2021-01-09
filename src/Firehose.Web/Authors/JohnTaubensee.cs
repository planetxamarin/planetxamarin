using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JohnTaubensee : IAmACommunityMember
    {
        public string FirstName => "John";
        public string LastName => "Taubensee";
        public string StateOrRegion => "Chicago, IL";
        public string EmailAddress => "";
        public string ShortBioOrTagLine => "is a developer focused on Microsoft technologies. Microsoft Azure alumni";
        public Uri WebSite => new Uri("https://taubensee.net");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://taubensee.net/tags/xamarin/index.xml"); }
        }

        public string TwitterHandle => "jtaubensee";
        public string GravatarHash => "151bc535ca1581cb451eb4df1672b018";
        public string GitHubHandle => "jtaubensee";
        public GeoPosition Position => new GeoPosition(41.8778143, -87.6349955);
        public string FeedLanguageCode => "en";
    }
}
