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
        public string ShortBioOrTagLine => "also known as banditoth | Xamarin && MAUI developer from Hungary.";
        public string StateOrRegion => "Budapest, Hungary";
        public string EmailAddress => "hello@banditoth.net";
        public string TwitterHandle => "banditoth_";
        public string GitHubHandle => "banditoth";
        public GeoPosition Position => new GeoPosition(47.497913, 19.040236);
        public Uri WebSite => new Uri("https://www.banditoth.net");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.banditoth.net/feed/"); } }
        public string GravatarHash => "e11e3fd93c1cc4db5ec6f309bac0ff4d";
        public string FeedLanguageCode => "en";
	}
}
