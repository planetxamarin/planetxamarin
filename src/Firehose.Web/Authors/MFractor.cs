using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MFractor : IAmACommunityMember
    {
        public string FirstName => "MFractor";
        public string LastName => "";
        public string StateOrRegion => "Sydney, Australia";
        public string EmailAddress => "hello@mfractor.com";
        public string ShortBioOrTagLine => "is a mobile first productivity tool for Visual Studio for Mac.";
        public Uri WebSite => new Uri("https://www.mfractor.com/");
        public string TwitterHandle => "mfractor";
        public string GitHubHandle => "mfractor";
        public string GravatarHash => "35bac056166a67222ddcd48b57113a32";

        public IEnumerable<Uri> FeedUris
        {
            get
            {
               return new List<Uri>()
               {
                 new Uri("https://www.mfractor.com/blogs/news.atom"),
                 new Uri("https://www.mfractor.com/blogs/learn.atom"),
                 new Uri("https://www.mfractor.com/blogs/blog.atom"),
               };
            }
        }

        public GeoPosition Position => new GeoPosition(-33.8678500, 151.2073200);
        public string FeedLanguageCode => "en";
    }
}