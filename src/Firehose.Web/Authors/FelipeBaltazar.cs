using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
	public class FelipeBaltazar : IAmACommunityMember
	{
		public string FirstName => "Felipe";
		public string LastName => "Baltazar";
		public string ShortBioOrTagLine => "Xamarin 🐒, ApnetCore 🌐, Windows 💻, Nerd 🤓, Gamer 🎮 and Father 👨‍👩‍👦";
		public string StateOrRegion => "Rio Grande do sul, Brasil";
		public string EmailAddress => "felipe.dasilvabaltazar@gmail.com";
		public string TwitterHandle => "FelippeBaltazar";
		public string GitHubHandle => "felipebaltazar";
		public string GravatarHash => "c4deac62305f590fbda80209628afd0e";
		public GeoPosition Position => new GeoPosition(-29.940163, -51.088751);
		public Uri WebSite => new Uri("https://medium.com/@felipedasilvabaltazar");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://medium.com/feed/@felipedasilvabaltazar"); } }
		public string FeedLanguageCode => "pt";
	}
}