using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Firehose.Web.Authors
{
	public class JucineiSantos : IAmACommunityMember
	{
		public string FirstName => "Jucinei";

		public string LastName => "Santos";

		public string StateOrRegion => "Brasília, Brasil";

		public string EmailAddress => "jucineisantos@outlook.com";

		public string ShortBioOrTagLine => "Mobile Developer, Blogger and Speaker.";

		public Uri WebSite => new Uri("https://medium.com/@jucinei");

		public string TwitterHandle => "jucinei";

		public string GitHubHandle => "Jucinei";

		public string GravatarHash => "7dc2bf63d70a55bea0e13a47b08ba246";

		public IEnumerable<Uri> FeedUris
		{
			get
			{
				yield return new Uri("https://medium.com/feed/@jucinei");
			}
		}

		public GeoPosition Position => new GeoPosition(-15.8353557, -48.0195973);

		public string FeedLanguageCode => "pt";
	}
}
