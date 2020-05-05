using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class SaamerMansoor : IAmACommunityMember, IFilterMyBlogPosts
    {
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://medium.com/feed/@prototypemakers"); }
        }

        public string FirstName => "Saamer";
        public string LastName => "Mansoor";
        public string StateOrRegion => "Toronto, Canada";
        public string EmailAddress => "i@saamer.me";
        public string ShortBioOrTagLine => "Top 5% Xamarin StackOverflow, Freelancer, Trainer";
        public Uri WebSite => new Uri("https://medium.com/@prototypemakers");
        public string TwitterHandle => "saamerm";
        public string GitHubHandle => "saamerm";
        public string GravatarHash => "66887acb0b76f2d3059255a1c53a3b22";
        public GeoPosition Position => new GeoPosition(43.639728, -79.380099);
        public bool Filter(SyndicationItem item) => true;
        public string FeedLanguageCode => "en";
    }
}