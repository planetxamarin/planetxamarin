using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class AndrasToth : IAmACommunityMember
	{
	      public string FirstName => "András";
        public string LastName => "Tóth";
        public string ShortBioOrTagLine => "also known as banditoth | Xamarin && C# .NET developer from Hungary.";
        public string StateOrRegion => "Budapest, Hungary";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => string.Empty;
        public string GitHubHandle => "banditoth";
        public GeoPosition Position => new GeoPosition(47.497913, 19.040236);
        public Uri WebSite => new Uri("https://www.banditoth.hu");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.banditoth.hu/feed/"); } }
        public string GravatarHash => "e11e3fd93c1cc4db5ec6f309bac0ff4d";
        public string FeedLanguageCode => "hu";
	}
}
