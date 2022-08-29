using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
	public class LetsCreateSeries : IAmACommunityMember
	{
		public string FirstName => "LetsCreateSeries";
		public string LastName => string.Empty;
		public string StateOrRegion => "United States";
		public string EmailAddress => "letscreate.roblox@gmail.com";
		public string ShortBioOrTagLine => "Create Mobile Apps using Xamarin.Forms";
		public Uri WebSite => new Uri("https://letscreateseries.com");
		public string TwitterHandle => "LetsCre8Series";
		public string GitHubHandle => "LetsCreateSeries";
		public string GravatarHash => "10793693ff507eda06ff02e9855e774f";
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://letscreateseries.com/rss"); } }
		public GeoPosition Position => new GeoPosition(40.6331, 89.3985);
		public string FeedLanguageCode => "en";
	}
}
