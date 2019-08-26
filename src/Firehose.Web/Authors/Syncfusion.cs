using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
	public class Syncfusion : IAmACommunityMember
	{
		public string FirstName => "Syncfusion";

		public string LastName => "";

		public string StateOrRegion => "North Carolina, USA";

		public string EmailAddress => "info@syncfusion.com";

		public string ShortBioOrTagLine => "Syncfusion provides the best third-party UI components for Xamarin, Xamarin.Android and Xamarin.iOS";

		public Uri WebSite => new Uri("https://www.syncfusion.com/xamarin-ui-controls");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://www.syncfusion.com/blogs/feed"); }
		}

		public string TwitterHandle => "Syncfusion";

		public string GravatarHash => "4291ef07481d300471113dbd4b4aabc2";

		public string GitHubHandle { get; } = "syncfusion";

		public GeoPosition Position => new GeoPosition(35.855361, -78.815751);

		public string FeedLanguageCode => "en";
	}
}