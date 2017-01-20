using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class NigelSampson : IAmAMicrosoftMVP, IFilterMyBlogPosts
	{
		public string FirstName => "Nigel";
		public string LastName => "Sampson";

		public string StateOrRegion => "New Zealand";

		public string EmailAddress => "nigel.sampson@compiledexperience.com";
		public string ShortBioOrTagLine => "is the project lead of Caliburn.Micro and is often a developer at Pushpay";

		public Uri WebSite => new Uri("http://compiledexperience.com/");

		public string TwitterHandle => "nigelsampson";
		public string GitHubHandle => "nigel-sampson";
		public string GravatarHash => "ffccec4c43820d5370ad22de8d569d77";

		public IEnumerable<Uri> FeedUris => new [] { new Uri("http://compiledexperience.com/blog/syndicate/atom/") };
		public GeoPosition Position => new GeoPosition(-36.848461, 174.763336);

		public bool Filter(SyndicationItem item)
		{
            var allowedCategories = new [] { "xamarin", "caliburn-micro" };

            return item.Categories.Any(c => allowedCategories.Contains(c.Name.ToLowerInvariant()));
		}
	}
}
