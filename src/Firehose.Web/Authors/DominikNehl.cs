using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class DominikNehl : IAmACommunityMember
	{
        public string FirstName => "Dominik";
        public string LastName => "Nehl";
        public string StateOrRegion => "Graz, AT";
        public string EmailAddress => "";
        public string ShortBioOrTagLine => "is a software developer from austria";
        public Uri WebSite => new Uri("https://austriancoding.home.blog/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://feeds.feedburner.com/Austriancoding"); }
        }

        public string TwitterHandle => "";
        public string GravatarHash => "4e5a7b68b191a2cb09abd845f0d7b46f";
        public string GitHubHandle => "WaiseFass";
        public GeoPosition Position => new GeoPosition(47.009977, 15.398945);
        public string FeedLanguageCode => "en";
    }
}
