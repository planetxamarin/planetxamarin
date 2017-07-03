using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class AshanDhanapala : IAmACommunityMember,IFilterMyBlogPosts
	{
        public string FirstName => "Ashan";
        public string LastName => "Dhanapala";
        public string ShortBioOrTagLine => " is a wannabe serious guy and a Xamarin enthusiast. Loves blogging and an early adapter of mobile development technologies";
        public string StateOrRegion => "Sri Lanka";
        public string EmailAddress => "ashandhanapala@gmail.com";
        public string TwitterHandle => "ashanCodes";
        public string GravatarHash => "fabf988b09d5dae70fb8545ca07c879e";
        public string GitHubHandle => "ashancodes";
        public GeoPosition Position => new GeoPosition(6.9271, 79.8612);

        public Uri WebSite => new Uri("http://ashancodes.blog/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://ashancodes.blog/rss"); } }

        public bool Filter(SyndicationItem item)
        {

			// This filters out only the posts that have the "xamarin" category
			return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
		}
    }
}