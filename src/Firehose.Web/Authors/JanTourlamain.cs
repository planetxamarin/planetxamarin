using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
    public class JanTourlamain : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Jan";
        public string LastName => "Tourlamain";
        public string ShortBioOrTagLine => "When Hello World ends, the life of a software developer begins.";
        public string EmailAddress => "jan@devprotocol.com";
	public string TwitterHandle => string.Empty;
        public string GravatarHash => "2af061e0817546c0934a59f38e8ab9e2";
        public string StateOrRegion => "Belgium";
        public Uri WebSite => new Uri("https://www.devprotocol.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.devprotocol.com/rss/"); }
        }

        public string GitHubHandle => "jtourlamain";
        public GeoPosition Position => new GeoPosition(50.869260, 3.810620);
	public bool Filter(SyndicationItem item) => 
	    item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
    }
}
