using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class LarryOBrien : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Larry";
        public string LastName => "O'Brien";
        public string StateOrRegion => "Kailua Kona, HI";
        public string TwitterHandle => "lobrien";
        public string EmailAddress => "";
        public string ShortBioOrTagLine => "Some years a writer who programs, other years a programmer who writes.";
        public string GravatarHash => "a47f1d509ad6ef38f226017c4b285289";
        public Uri WebSite => new Uri("http://www.knowing.net/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.knowing.net/?category=xamarin&feed=rss"); }
        }

        public string GitHubHandle => "lobrien";

        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
        public GeoPosition Position => new GeoPosition(19.64, -156.0);
    }
}