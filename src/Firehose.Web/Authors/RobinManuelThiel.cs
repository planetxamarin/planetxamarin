using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Authors
{
    public class RobinManuelThiel : IWorkAtXamarinOrMicrosoft, IFilterMyBlogPosts
    {
        public string FirstName => "Robin-Manuel";
        public string LastName => "Thiel";
        public string Title => "Technical Evangelist at Microsoft";
        public string StateOrRegion => "Munich, Germany";
        public string EmailAddress => string.Empty;
        public string TwitterHandle => "einRobby";
        public string GithubHandle => string.Empty;
        public Uri WebSite => new Uri("http://pumpingco.de/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://pumpingco.de/feed/"); } }
        public string GravatarHash => "1b8fabaa8d66250a7049bdb9ecf44397";

        public DateTime Started => new DateTime(2016, 1, 1);

        public bool Filter(SyndicationItem item)
        {
            return item.Title.Text.ToLowerInvariant().Contains("xamarin") || item.Categories.Where(i => i.Name.Equals("Xamarin", StringComparison.OrdinalIgnoreCase)).Any();
        }
    }
}