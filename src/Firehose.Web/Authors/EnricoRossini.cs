using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors {
    public class EnricoRosini : IAmACommunityMember, IFilterMyBlogPosts {
        public string FirstName => "Enrico";
        public string LastName => "Rossini";
        public string ShortBioOrTagLine => "I am a strong full-stack developer, from html5/js on the client-side to C# multi-layer server-side code and client-side code. I'm glad to be a Windows 10 and Xamarin Developer!!!";
        public string StateOrRegion => "London";
        public string EmailAddress => "enrico.rossini.uk@live.com";
        public string TwitterHandle => "erossiniuk";
        public string GravatarHash => "882d0f8af2794bb83710d701feb47571";

        public Uri WebSite => new Uri("http://www.puresourcecode.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://puresourcecode.com/syndication.axd"); }
        }

        public string GitHubHandle => string.Empty;

        public bool Filter(SyndicationItem item) {
            return item.Title.Text.ToLowerInvariant().Contains("xamarin")
                   || item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
        }

        public GeoPosition Position => new GeoPosition(51.524307, 0);
    }
}