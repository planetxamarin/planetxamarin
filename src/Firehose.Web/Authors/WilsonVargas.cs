using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;
using System.ServiceModel.Syndication;
using System.Linq;

namespace Firehose.Web.Authors
{
    public class WilsonVargas : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Wilson";

        public string LastName => "Vargas";

        public string StateOrRegion => "Trujillo, Peru";

        public string EmailAddress => "";

        public string ShortBioOrTagLine => "is a guy with lots of experience in the software development art and with a great passion for mobile development using Xamarin platform.";

        public Uri WebSite => new Uri("https://blog.wilsonvargas.com");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://blog.wilsonvargas.com/rss/"); }
        }

        public string TwitterHandle => "Wilson_VargasM";


        public string GravatarHash => "3544142bb4ef8f597b1c14b887b0b905";
        public string GitHubHandle => "wilsonvargas";

        public GeoPosition Position => new GeoPosition(-8.120174, -79.035157);

        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
    }
}
