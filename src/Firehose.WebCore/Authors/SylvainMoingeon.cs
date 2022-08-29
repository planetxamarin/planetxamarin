using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
	public class SylvainMoingeon : IAmACommunityMember
	{
		public string FirstName => "Sylvain";

		public string LastName => "Moingeon";

		public string StateOrRegion => "Dijon, France";

		public string EmailAddress => "";

		public string ShortBioOrTagLine => "is a french guy that crafts Xamarin.Forms apps";

		public Uri WebSite => new Uri("https://www.sylvainmoingeon.fr");

		public string TwitterHandle => "SylvainMoingeon";

		public string GitHubHandle => "SylvainMoingeon";

		public string GravatarHash => "f0139f72232177b730a57cff5c38c0b2";

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("https://www.sylvainmoingeon.fr/feed.xml"); }
		}

		public GeoPosition Position => new GeoPosition(47.304828, 5.131814);

		public string FeedLanguageCode => "fr";
	}
}