using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class DavidOrtinau : IWorkAtXamarinOrMicrosoft
	{
		public string FirstName => "David";
		public string LastName => "Ortinau";
		public string StateOrRegion => "Saint Louis, Missouri";
		public string EmailAddress => "";
		public string ShortBioOrTagLine => "is a Principal Program Manager for Xamarin & .NET MAUI";
		public Uri WebSite => new Uri("https://twitter.com/davidortinau");

		public IEnumerable<Uri> FeedUris
		{
			get
			{
				return new Uri[]
				{
					new Uri("https://www.youtube.com/feeds/videos.xml?channel_id=UCmzgpq6cgYCTWU7wePsg8lQ")
				};
			}
		}

		public string TwitterHandle => "DavidOrtinau";
		public string GravatarHash => "340d396deb6c4987147b061705edcb54";
		public string GitHubHandle => "davidortinau";
		public GeoPosition Position => new GeoPosition(38.627003, -90.199402);
		public string FeedLanguageCode => "en";
	}
}