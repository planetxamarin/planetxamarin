using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MarkoLazic : IAmACommunityMember
    {
        public string FirstName => "Marko";
        public string LastName => "Lazić";
        public string ShortBioOrTagLine => "Software engineer, tech enthusiast, passionate traveler. 4+ years of active development in Xamarin.Forms";
        public string StateOrRegion => "Belgrade, Serbia";
        public string EmailAddress => "marko.lazic88@gmail.com";
        public string TwitterHandle => "markolazic88";
        public string GravatarHash => "5645586a7d29654e9b296b1409107014";
        public Uri WebSite => new Uri("https://markolazic.com/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://markolazic.com/feed/"); }
        }
        public string GitHubHandle => "markolazic88";
        public GeoPosition Position => new GeoPosition(44.7866, 20.4489);
        public string FeedLanguageCode => "en";
    }
}
