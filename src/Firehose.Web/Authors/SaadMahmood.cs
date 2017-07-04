using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class SaadMahmood : IAmAMicrosoftMVP, IFilterMyBlogPosts
    {
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.codethis.today/feeds/posts/default"); }
        }

        public string FirstName => "Saad";
        public string LastName => "Mahmood";
        public string StateOrRegion => "Lahore, Pakistan";
        public string EmailAddress => "saad-mehmood@outlook.com";
        public string ShortBioOrTagLine => "Microsoft MVP for Windows Development & Microsoft Azure loves to write Xamarin Apps and help Xamarin Community 🎉";
        public Uri WebSite => new Uri("http://codethis.today");
        public string TwitterHandle => "saadmeh";
        public string GitHubHandle => "muhammad92";
        public string GravatarHash => "c839b9f904d7cfb3a3b6b1562fe989b4";
        public GeoPosition Position => new GeoPosition(31.5546, 74.3572);

        public bool Filter(SyndicationItem item)
            => item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
    }
}
