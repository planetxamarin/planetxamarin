using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
	public class HumbertoJaimes: IAmAMicrosoftMVP, IAmAXamarinMVP, IFilterMyBlogPosts
{
    public string FirstName => "Humberto";
	public string LastName => "Jaimes";
	public string ShortBioOrTagLine => "Xamarin & Microsoft MVP from Mexico City";
	public string StateOrRegion => "Mexico City";
	public string EmailAddress => "humberto@humbertojaimes.net";
	public string TwitterHandle => "HJaimesDev";
	public string GravatarHash => "9e138d2d1e5de03581eedb2cbbcf46ff";
	public string GitHubHandle => "humbertojaimes";
	public GeoPosition Position => new GeoPosition(19.4326080, -99.1332080);

	public Uri WebSite => new Uri("http://www.hjr.com.mx");
	public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://www.hjr.com.mx/feeds/posts/default"); } }

		public bool Filter(SyndicationItem item)
		{
			return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
		}
	}
}
