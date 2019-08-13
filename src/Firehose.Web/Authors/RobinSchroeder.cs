using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;


namespace Firehose.Web.Authors
{
	public class RobinSchroeder : IAmACommunityMember
	{
		public string FirstName => "Robin";
		public string LastName => "Schroeder";
		public string ShortBioOrTagLine => "Xamarin.Forms/UWP Software Consultant at MSCTek";
		public string StateOrRegion => "Illinois";
		public string EmailAddress => "robin@msctek.com";
		public string TwitterHandle => "RTSchroeder";
		public string GravatarHash => "1754cd9eee726fd3a5252a4718cbf108";
		public string GitHubHandle => "robintschroeder";
		public GeoPosition Position => new GeoPosition(41.9136926,-88.3148351);
		public Uri WebSite => new Uri("https://msctek.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.msctek.com/feed/"); } }
        public string FeedLanguageCode => "en";
	}
}
