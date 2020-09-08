using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class BasDeCort : IAmACommunityMember
	{
		public string FirstName => "Bas";
		public string LastName => "de Cort";
		public string StateOrRegion => "Tilburg, The Netherlands";
		public string EmailAddress => "";
		public string ShortBioOrTagLine => "is a mobile developer with a great passion for Xamarin 🙉";
		public Uri WebSite => new Uri("https://www.basdecort.com");
		public string TwitterHandle => "basdecort";
		public string GitHubHandle => "basdecort";
		public string GravatarHash => "9cabafd38c21d9df358f7532ffa39153";
		public GeoPosition Position => new GeoPosition(52.040222799999995, 5.534900299999999);
		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://www.basdecort.com/rss"); }
		}

        public string FeedLanguageCode => "en";
	}
}