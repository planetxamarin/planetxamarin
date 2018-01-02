using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;
using System.ServiceModel.Syndication;
using System.Linq;

namespace Firehose.Web.Authors
{
    public class DanSiegel : IAmAMicrosoftMVP, IFilterMyBlogPosts
    {
        public string FirstName => "Dan";

        public string LastName => "Siegel";

        public string StateOrRegion => "San Diego, CA";

        public string EmailAddress => "dsiegel@avantipoint.com";

        public string ShortBioOrTagLine => "is a Microsoft MVP, speaker, member of the Prism Team, and a Cross Platform, Mobile & Cloud Solutions Consultant.";

        public Uri WebSite => new Uri("https://dansiegel.net");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://dansiegel.net/syndication.axd"); }
        }

        public string TwitterHandle => "DanJSiegel";

        public string GravatarHash => "b65a519785f69fbe7236dd0fd6396094";

        public string GitHubHandle => "dansiegel";

        public GeoPosition Position => new GeoPosition(32.726308, -117.177746);

        public bool Filter(SyndicationItem item) =>
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
    }
}