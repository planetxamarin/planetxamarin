using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
	public class RicardoPrestes: IAmACommunityMember
	{
		public string FirstName => "Ricardo";
		public string LastName => "Prestes";
		public string StateOrRegion => "Cornélio Procópio, Brasil";
		public string EmailAddress => "ricardo.logan@hotmail.com";
		public string ShortBioOrTagLine => "Tech lead mobile developer, Burger Monkeys Co-founder";
		public Uri WebSite => new Uri("https://oficinadologan.wordpress.com/");
		public string TwitterHandle => "ricardo_prestes";
		public string GitHubHandle => "ricardoprestes";
		public string GravatarHash => "9802e38d5bd2cd85db8b0720d5feed29";
		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://oficinadologan.wordpress.com/rss"); }
		}
		public GeoPosition Position => new GeoPosition(-23.194571, -50.7795215);
		public string FeedLanguageCode => "pt";
	}
}
