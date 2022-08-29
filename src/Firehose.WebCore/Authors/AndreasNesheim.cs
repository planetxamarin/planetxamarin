using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
	public class AndreasNesheim : IAmACommunityMember
	{
		public string FirstName => "Andreas";

		public string LastName => "Nesheim";

		public string StateOrRegion => "Norway";

		public string EmailAddress => "andreas.aronsen.nesheim@gmail.com";

		public string ShortBioOrTagLine => ".NET developer with a passion for Xamarin, Azure DevOps and .NET Core.";

		public Uri WebSite => new Uri("https://www.andreasnesheim.no/");

		public string TwitterHandle => "AndreasNesheim";

		public string GitHubHandle => "andreas-nesheim";

		public string GravatarHash => "3f1d141d2809114debffb23277e91e3e";

		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://andreasnesheim.no/feed"); } }

		public GeoPosition Position => new GeoPosition(58.9540147, 5.7259639);

		public string FeedLanguageCode => "en";
	}
}