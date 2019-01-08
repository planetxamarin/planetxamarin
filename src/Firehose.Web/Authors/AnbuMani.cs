using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class AnbuMani : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Anbu";

        public string LastName => "Mani";

        public string ShortBioOrTagLine => "I'm Always love with Working in Community";

        public string EmailAddress => "anbumani@xmonkeys360.com";

        public string TwitterHandle => "anbu_mani27";

        public string GravatarHash => "f97650474e4aa5b9609a28dcfdb052d4";

        public string StateOrRegion => "Chennai, India";

        public Uri WebSite => new Uri("https://www.xmonkeys360.com/");

        public GeoPosition Position => new GeoPosition(13.029217, 80.2082503);

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://xmonkeys360.com/feed/"); }

        }
        public string GitHubHandle => "AnbuMani27";

        public string FeedLanguageCode => "en";

        public bool Filter(SyndicationItem item)
        {

            return item.Title.Text.ToLowerInvariant().Contains("xamarin") && (item.Categories?.Any(c => c.Name.ToLowerInvariant().Equals("xamarin")) ?? false);

        }

    }
}