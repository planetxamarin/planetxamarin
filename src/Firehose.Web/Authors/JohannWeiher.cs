using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class JohannWeiher : IAmACommunityMember
	{
		public string FirstName => "Johann";
		public string LastName => "Weiher";
		public string ShortBioOrTagLine => "Software Engineer and founder of CodeQuartett & Cuterdio app";
		public string StateOrRegion => "Germany";
		public string EmailAddress => "info@suplanus.de";
		public string TwitterHandle => "JohannWeiher";
		public string GravatarHash => "482fcc4e05cda49716f00e028c28cfae";
		public string GitHubHandle => "Suplanus";
		public GeoPosition Position => new GeoPosition(48.778010, 11.847377);
		public Uri WebSite => new Uri("https://maui-blog.com/");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://maui-blog.com/feed/"); } }
		public string FeedLanguageCode => "en";
	}
}