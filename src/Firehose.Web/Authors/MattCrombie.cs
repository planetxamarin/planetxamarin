using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class MattCrombie : IAmACommunityMember
	{
		public string FirstName => "Matt";

		public string LastName => "Crombie";

		public string ShortBioOrTagLine => "Senior Xamarin Mobile Consultant/Architect";

		public string StateOrRegion => "Brisbane, Australia";

		public string EmailAddress => "matt@xamarinhowto.com";

		public string TwitterHandle => "xamarinhowto";

		public string GravatarHash => "3f1200c50911032b3558b7c0fc29c847";

		public string GitHubHandle => "xamarinhowto";

		public GeoPosition Position => new GeoPosition(-27.468450, 153.024184);

		public Uri WebSite => new Uri("https://xamarinhowto.com/");

		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://xamarinhowto.com/feed/"); } }

		public string FeedLanguageCode => "en";
	}
  }
