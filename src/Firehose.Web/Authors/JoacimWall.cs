using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
namespace Firehose.Web.Authors
{
	public class JoacimWall : IAmACommunityMember
	{
		public string FirstName => "Joacim";
		public string LastName => "Wall";
		public string ShortBioOrTagLine => "mobility architect";
		public string StateOrRegion => "Värmland, Sweden";
		public string EmailAddress => "joacim.wall@gmail.com";
		public string TwitterHandle => "";
		public string GravatarHash => "";
		public string GitHubHandle => "JoacimWall";
		public GeoPosition Position => new GeoPosition(59.378117005663405, 13.499225556120823);
		public Uri WebSite => new Uri("https://joacimwall.github.io/");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://joacimwall.github.io/feed_rss_created.xml"); } }
		public string FeedLanguageCode => "en";
	}
}