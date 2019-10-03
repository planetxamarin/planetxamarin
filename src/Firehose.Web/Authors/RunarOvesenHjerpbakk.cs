using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
	public class RunarOvesenHjerpbakk : IAmACommunityMember
	{
		public string FirstName => "Runar Ovesen";
		public string LastName => "Hjerpbakk";
		public string ShortBioOrTagLine => "Passionate, empathic and experienced developer, software architect and manager. My love for C# is only surpassed by my love for Xamarin and iOS.";
		public string StateOrRegion => "Trondheim, Norway";
		public string EmailAddress => "runar@hjerpbakk.com";
		public string TwitterHandle => "hjerpbakk";
		public string GravatarHash => "62b1d11eafee92745a51971d6cc21f85";
		public string GitHubHandle => "Sankra";
		public GeoPosition Position => new GeoPosition(63.4305, 10.3951);
		public Uri WebSite => new Uri("https://hjerpbakk.com/");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://hjerpbakk.com/feed.xml"); } }
		public string FeedLanguageCode => "en";
	}
}
