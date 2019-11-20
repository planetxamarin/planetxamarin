using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class ShankarMadeshvaran : IAmACommunityMember 
	{
		public string FirstName => "Shankar";

		public string LastName => "Madeshvaran";

		public string StateOrRegion => "TamilNadu, India";

		public string EmailAddress => "shankarmadeshvaran@gmail.com";

		public string ShortBioOrTagLine => "Software Engineer(iOS and Xamarin Developer)";

		public Uri WebSite => new Uri("https://medium.com/feed/@shankarmadeshvaran");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://medium.com/feed/@shankarmadeshvaran"); }
      get { yield return new Uri("https://medium.com/feed/a-developer-in-making/tagged/xamarin"); }
		}

		public string TwitterHandle => "Shankar__am";

		public string GravatarHash => "73d50d0d62915195ae83b87eebb523bc";
		public string GitHubHandle => "shankarmadeshvaran";
		public GeoPosition Position => new GeoPosition(11.04937, 77.02200);

		public string FeedLanguageCode => "en";
	
	}

}
