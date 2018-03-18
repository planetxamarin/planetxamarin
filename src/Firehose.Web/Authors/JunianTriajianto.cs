using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JunianTriajianto : IAmACommunityMember
	{
		public string FirstName => "Junian";
		public string LastName => "Triajianto";
		public string ShortBioOrTagLine => "Software Engineer, who enjoys problem solving and technology related to C#, Xamarin, ASP.NET Core, and Unity 3D.";
		public string StateOrRegion => "Surabaya, Indonesia";
		public string EmailAddress => "";
		public string TwitterHandle => "JunianNet";
		public string GravatarHash => "b67cdce8e2da7ffdadb5ff32bb66c132";
		public string GitHubHandle => "junian";
		public GeoPosition Position => new GeoPosition(-7.2574719, 112.75208829999997);
		public Uri WebSite => new Uri("https://www.junian.net");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.junian.net/feeds/posts/default?alt=rss"); } }
        public string FeedLanguageCode => "en";
	}
}