using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class VenkataramanaMadugula : IAmACommunityMember
    {
        public string FirstName => "Venkataramana";
        public string LastName => "Madugula";
        public string StateOrRegion => "Hyderabad, India";
        public string TwitterHandle => "madugula83";
        public string EmailAddress => "madugula.venkataramana@gmail.com";
        public string ShortBioOrTagLine => "Xamarin Certified Developer.";
        public string GravatarHash => "a197aa8d40cd9aa859be8642c5b38123";
        public Uri WebSite => new Uri("https://www.madugulavenkataramana.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.madugulavenkataramana.com/feed/"); }
        }

        public string GitHubHandle => "VenkatsQuest";

        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
        public GeoPosition Position => new GeoPosition(17.387140, 78.491684);
    }
}
