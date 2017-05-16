using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JohnWilson : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "John";

        public string LastName => "Wilson";

        public string StateOrRegion => "Brisbane, Australia";

        public string EmailAddress => "wislon@hotmail.com";

        public string ShortBioOrTagLine => "Head of Mobile, Tech Lead, Xamarin Specialist";

        public Uri WebSite => new Uri("http://blog.wislon.io/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://blog.wislon.io/atom.xml"); }
        }

        public string TwitterHandle => "wislon";

        public string GravatarHash => "86c9d925c04b4c79c98bfc839d949e15";
        public string GitHubHandle => "wislon";
        public GeoPosition Position => new GeoPosition(-27.3812513,152.7130138);
        
        public bool Filter(SyndicationItem item)
        {
            // Here you filter out the given item by the criteria you want, i.e.
            // this filters out posts that do not have Xamarin in the title
            return item.Title.Text.ToLowerInvariant().Contains("xamarin");
        }
        
    }
}
