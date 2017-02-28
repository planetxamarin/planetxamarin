using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
	public class AlejandroRuiz : IAmAXamarinMVP, IFilterMyBlogPosts
	{
		public string FirstName => "Alejandro";

		public string LastName => "Ruiz";

		public string ShortBioOrTagLine => "Alejandro Ruiz is a Xamarin MVP, C# & Open Source Lover";

		public string StateOrRegion => "Guadalajara, Mexico";

		public string EmailAddress => "alejandro@alejandroruizvarela.com";

		public Uri WebSite => new Uri("http://alejandroruizvarela.blogspot.mx");

		public IEnumerable<Uri> FeedUris
		{
			get { yield return new Uri("http://alejandroruizvarela.blogspot.mx/rss.xml"); }
		}

		public string TwitterHandle => "alejandroruizva";


		public string GravatarHash => "35d0fff7dbc133e9fe2075aa14205a57";
		public string GitHubHandle => "AlejandroRuiz";

		public GeoPosition Position => new GeoPosition(20.6668200, -103.3918200);

		public bool Filter(SyndicationItem item)
		{
			return item.Title.Text.ToLowerInvariant().Contains("xamarin");
		}
	}
}
