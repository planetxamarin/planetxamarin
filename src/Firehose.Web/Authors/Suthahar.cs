using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class Suthahar : IAmACommunityMember
    {
        public string FirstName => "Suthahar";
        public string LastName => "Jegatheesan";
        public string ShortBioOrTagLine => "insatiable desire to keep learning keeps the dynamic blogger. I take keen interest in sharing my knowledge and solving my readers’ technology-related problems.";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "jssuthahar";
        public string GravatarHash => "2a34ebf4e9c4dca84eb7feee7217568f";
        public string StateOrRegion => "Bangalore, India";
        public Uri WebSite => new Uri("https://www.msdevbuild.com/");
        public GeoPosition Position => new GeoPosition(12.9715990, 77.5945630);

       public IEnumerable<Uri> FeedUris
        {
			get
			{
				return new Uri[]
				{
					new Uri("https://www.msdevbuild.com/feeds/posts/default"),
					new Uri("https://www.youtube.com/feeds/videos.xml?channel_id=UCwoWf6zryMFwEyOh2UYLSwA")
				};
			}
        }

        public string GitHubHandle => "jssuthahar";
        public string FeedLanguageCode => "en";
    }
}
