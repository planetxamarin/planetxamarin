using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;
using System.Linq;

namespace Firehose.Web.Authors
{
	public class StefanDeVogelaere : IAmACommunityMember, IFilterMyBlogPosts
	{
		public string FirstName => "Stefan";
		public string LastName => "de Vogelaere";
		public string ShortBioOrTagLine => "Certified Xamarin developer and team lead at 3factr.";
		public string StateOrRegion => "Wommelgem, Belgium";
		public string EmailAddress => "stefan.de.vogelaere@gmail.com";
		public string TwitterHandle => "stefandevo";

		public Uri WebSite => new Uri("http://www.stefandevo.com");
		public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://www.stefandevo.com/feed/"); } }

		public string GravatarHash => "c91dbad10c922f0fef71e9e2df15b763";

		public bool Filter(SyndicationItem item)
		{
			
			return item.Categories.Where(i => i.Name.Equals("xamarin", StringComparison.OrdinalIgnoreCase)).Any();
		}
	}
}
