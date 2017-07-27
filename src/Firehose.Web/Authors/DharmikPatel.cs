using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class DharmikPatel : IAmACommunityMember
	{
		public string FirstName => "Dharmik";
		public string LastName => "Patel";
		public string StateOrRegion => "Gujarat, India";
		public string TwitterHandle => "_dharmik";
		public string EmailAddress => "dharmikisback@gmail.com";
		public string ShortBioOrTagLine => "Dharmik Patel, Mobile Application Developer";
		public string GravatarHash => "10cacc1d15f2e436baeb2cef09064363";
		public Uri WebSite => new Uri ("https://about.me/dharmikisback");

		public IEnumerable<Uri> FeedUris {
			get { yield return new Uri ("https://xamarindevelopment.blogspot.in/feeds/posts/default?alt=rss"); }
		}

		public string GitHubHandle => "dharmik";
		public GeoPosition Position => new GeoPosition (23.099792, 72.557453);
	}
}