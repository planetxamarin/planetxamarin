using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MFractor : IAmACommunityMember
    {
        public string FirstName => "MFractor";
        public string LastName => "";
        public string StateOrRegion => "Sydney, Australia";
        public string EmailAddress => "hello@mfractor.com";
        public string ShortBioOrTagLine => "is a collection of incredible tools for Xamarin Studio.";
        public Uri WebSite => new Uri("https://www.mfractor.com/");
        public string TwitterHandle => "mfractor";
        public string GitHubHandle => "mfractor";
        public string GravatarHash => "35bac056166a67222ddcd48b57113a32";
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.mfractor.com/blogs/news.atom"); }
        }
        public GeoPosition Position => new GeoPosition(-33.8678500, 151.2073200);
    }
}
