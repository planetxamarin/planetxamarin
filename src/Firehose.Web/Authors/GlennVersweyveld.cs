using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;
using System.Linq;

namespace Firehose.Web.Authors
{
	public class GlennVersweyveld : IAmAMicrosoftMVP, IFilterMyBlogPosts
	{
		public string FirstName => "Glenn";
		public string LastName => "Versweyveld";
		public string Title => "Xamarin developer at Bank J. Van Breda & Co";
		public string StateOrRegion => "Antwerp, Belgium";
		public string EmailAddress => "Glenn.Versweyveld@gmail.com";
		public string TwitterHandle => "depechie";

		public Uri WebSite => new Uri("http://depblog.weblogs.us");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://depblog.weblogs.us/feed/"); } }

		DateTime IAmAMicrosoftMVP.FirstAwarded => new DateTime(2014, 1, 1);

		public string GravatarHash => "";

		public bool Filter(SyndicationItem item)
		{
			
			return item.Categories.Where(i => i.Name.Equals("Xamarin", StringComparison.OrdinalIgnoreCase)).Any();
		}
	}
}