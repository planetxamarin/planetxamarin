using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
	public class BrandonMinnick : IWorkAtXamarinOrMicrosoft
	{
		public string FirstName => "Brandon";
		public string LastName => "Minnick";
		public string StateOrRegion => "San Francisco, CA";
		public string EmailAddress => "brandon@codetraveler.io";
		public string ShortBioOrTagLine => "works as a Developer Advocate at Microsoft. Formerly a Customer Success Engineer at Xamarin (before the Microsoft Acquisition), Brandon has a loves helping developers make 5-star apps!";
		public Uri WebSite => new Uri("https://codetraveler.io");
		public string TwitterHandle => "TheCodeTraveler";
		public string GitHubHandle => "brminnick";
		public string GravatarHash => "e03e28629383def59c31d54fb8bb3982";
		public GeoPosition Position => new GeoPosition(37.776690, -122.416644);
		public string FeedLanguageCode => "en";
		public IEnumerable<Uri> FeedUris
		{
			get
			{
				yield return new Uri("https://codetraveler.io/tag/xamarin/rss");
			}
		}
	}
}
