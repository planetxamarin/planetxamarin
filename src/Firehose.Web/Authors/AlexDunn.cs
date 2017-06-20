using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class AlexDunn : IAmACommunityMember
    {
        public string FirstName => "Alex";
        public string LastName => "Dunn";
        public string StateOrRegion => "Boston, MA";
        public string TwitterHandle => "suave_pirate";
        public string EmailAddress => "alexander.dunn@outlook.com";
        public string ShortBioOrTagLine => "I build robust applications and train other developers along the way.";
        public string GravatarHash => "bd76e4531285c3b6c423a890378c6002";
        public Uri WebSite => new Uri("https://alexdunn.org");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://alexdunn.org/feed/"); }
        }

        public string GitHubHandle => "SuavePirate";

        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
        public GeoPosition Position => new GeoPosition(42.364940, -71.068876);
    }
}