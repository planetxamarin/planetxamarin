using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class GeraldVersluis : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Gerald";
        public string LastName => "Versluis";
        public string StateOrRegion => "The Netherlands";
        public string EmailAddress => "gerald@verslu.is";
        public string ShortBioOrTagLine => "Software Engineer at Microsoft";
        public Uri WebSite => new Uri("https://blog.verslu.is/");

        public IEnumerable<Uri> FeedUris
        {
			get
			{
				return new Uri[]
				{
					new Uri("https://blog.verslu.is/feed/"),
					new Uri("https://www.youtube.com/feeds/videos.xml?channel_id=UCBBZ2kXWmd8eXlHg2wEaClw")
				};
			}
        }

        public string TwitterHandle => "jfversluis";
        public string GravatarHash => "f9d4d4211d7956ce3e07e83df0889731";
        public string GitHubHandle => "jfversluis";
        public GeoPosition Position => new GeoPosition(50.889039, 5.853717);
        public string FeedLanguageCode => "en";
    }
}
