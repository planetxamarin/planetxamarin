using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JohnThiriet : IAmACommunityMember
    {
        public string FirstName => "John";
        public string LastName => "Thiriet";
        public string StateOrRegion => "Paris, France";
        public string EmailAddress => "johnthiriet@protonmail.com";
        public string ShortBioOrTagLine => "is a Mobility Technical Manager, Trainer, Microsoft MVP, Xamarin MVP";
        public Uri WebSite => new Uri("https://johnthiriet.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://johnthiriet.com/feed.xml"); }
        }

        public string TwitterHandle => "johnthiriet";
	public string GravatarHash => "ed92222c19a155a929d9f2c12d39c3f4";
        public string GitHubHandle => "johnthiriet";
	public GeoPosition Position => new GeoPosition(48.875485, 2.311039);
        public string FeedLanguageCode => "en";
    }
}
