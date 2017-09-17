using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class JohanKarlsson : IAmAMicrosoftMVP, IAmAXamarinMVP, IFilterMyBlogPosts
	{
		public string FirstName => "Johan";

		public string LastName => "Karlsson";

		public string StateOrRegion => "Dalarna, Sweden";

		public string EmailAddress => "johan.kson@gmail.com";

		public string ShortBioOrTagLine => "Ducks are on my mind";

		public Uri WebSite => new Uri("http://www.johankarlsson.net");

		public string TwitterHandle => "johankson";

		public string GitHubHandle => "johankson";

		public string GravatarHash => "f098e7e7b32cffd557125cbd2c9b4a84";

		public IEnumerable<Uri> FeedUris
		{
			get
			{
				yield return new Uri("http://www.johankarlsson.net/feeds/posts/default");
			}
		}

		public GeoPosition Position => new GeoPosition(60.477622, 15.439669);

		public bool Filter(SyndicationItem item)
		{
			// Of course you can make the checks as complicated as you want and combine some stuff
			return item.Title.Text.ToLowerInvariant().Contains("xamarin") && item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
		}
	}
}
