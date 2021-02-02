using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
	public class BohdanBenetskyi : IAmACommunityMember
	{
		public string FirstName => "Bohdan";

		public string LastName => "Benetskyi";

		public string StateOrRegion => "Warsaw, Poland";

		public string EmailAddress => "benetskyybogdan@gmail.com";

		public string ShortBioOrTagLine => "Xamarin MVP, co-organizer of Xamarin Local Events in Rzeszow";

		public Uri WebSite => new Uri("https://benetskyybogdan.medium.com/");

		public string TwitterHandle => "bbenetskyy";

		public string GitHubHandle => "bbenetskyy";

		public string GravatarHash => "8bfa7db9239c2969b79468a58c8dd066";

		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://medium.com/feed/@benetskyybogdan/"); } }

		public GeoPosition Position => new GeoPosition(52.237049, 21.017532);

		public string FeedLanguageCode => "en";
	}
}
