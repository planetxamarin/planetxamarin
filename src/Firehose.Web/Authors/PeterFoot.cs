using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;
using System.Linq;

namespace Firehose.Web.Authors
{
	public class PeterFoot : IAmAMicrosoftMVP, IFilterMyBlogPosts
	{
		public string FirstName => "Peter";
		public string LastName => "Foot";
		public string Title => "Xamarin and Windows developer at In The Hand Ltd";
		public string StateOrRegion => "United Kingdom";
		public string EmailAddress => "peter@peterfoot.net";
		public string TwitterHandle => "peterfoot";

		public Uri WebSite => new Uri("http://peterfoot.net");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://peterfoot.net/feed/"); } }
        
		public string GravatarHash => "fa15aeeccc4b23e8a4677aeacb65b7bb";

        public string ShortBioOrTagLine => "Peter Foot is a Xamarin and Windows developer at In The Hand Ltd";

        public string GitHubHandle => "peterfoot";


        public GeoPosition Position => new GeoPosition(52.76872, -2.37825);

        public bool Filter(SyndicationItem item)
		{
			
			return item.Categories.Where(i => i.Name.Equals("Xamarin", StringComparison.OrdinalIgnoreCase)).Any();
		}
	}
}
