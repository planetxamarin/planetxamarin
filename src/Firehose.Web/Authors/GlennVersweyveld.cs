using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class GlennVersweyveld : IAmAMicrosoftMVP, IAmAXamarinMVP, IFilterMyBlogPosts
    {
        public string FirstName => "Glenn";
        public string LastName => "Versweyveld";
        public string ShortBioOrTagLine => "'SH10151' this is the serial number of our orbital gun";
        public string StateOrRegion => "Antwerp, Belgium";
        public string EmailAddress => "Glenn.Versweyveld@gmail.com";
        public string TwitterHandle => "depechie";
        public GeoPosition Position => new GeoPosition(51.091310, 4.548315);        

        public Uri WebSite => new Uri("https://depblog.weblogs.us");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://depblog.weblogs.us/feed/"); }
        }

        public string GravatarHash => "d3ac2144120f923f23c49ee4ce4437ab";
        public string GitHubHandle => string.Empty;        

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Where(i => i.Name.Equals("Xamarin", StringComparison.OrdinalIgnoreCase)).Any();
        }
    }
}
