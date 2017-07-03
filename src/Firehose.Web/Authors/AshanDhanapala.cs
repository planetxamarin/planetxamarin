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
        public string ShortBioOrTagLine => "Wannabe serious guy and Xamarin enthusiast";
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
            
			// Of course you can make the checks as complicated as you want and combine some stuff
            return item.Title.Text.ToLowerInvariant().Contains("xamarin") && item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));

		}
    }
}