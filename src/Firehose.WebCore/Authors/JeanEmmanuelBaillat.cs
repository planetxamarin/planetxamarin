using Firehose.Web.Infrastructure;
using System;

namespace Firehose.Web.Authors
{
	public class JeanEmmanuelBaillat : IAmACommunityMember
	{
		public string FirstName => "Jean-Emmanuel";
		public string LastName => "Baillat";
		public string StateOrRegion => "Nice, France";
		public string EmailAddress => "jeanemmanuel.baillat@gmail.com";
		public string ShortBioOrTagLine => "(or J-E), is a Software Engineer and a French blogger about .NET MAUI. Any beginner developer should quickly have fun and produce cool apps!";
		public Uri WebSite => new Uri("https://www.mauicestclair.fr/");
		public string TwitterHandle => "kapuschinfo";
		public string GitHubHandle => "kapusch";
		public string GravatarHash => "52e9c14f8ea010d1e88eb4a4559cfa3b";
		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://www.mauicestclair.fr/index.xml"); }
		}
		public GeoPosition Position => new GeoPosition(43.700000, 7.250000);
		public string FeedLanguageCode => "fr";
	}
}

