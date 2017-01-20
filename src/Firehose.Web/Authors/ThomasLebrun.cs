using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
    public class ThomasLebrun : IAmAMicrosoftMVP, IFilterMyBlogPosts
    {
        public string FirstName => "Thomas";
        public string LastName => "Lebrun";
        public string ShortBioOrTagLine => "works on Xamarin and Windows/UWP applications, using Microsoft Azure.";
        public string EmailAddress => "lebrun_thomas@hotmail.com";
        public string TwitterHandle => "thomas_lebrun";
        public string GravatarHash => "99610b91f1daddcd17dc428e8c1be264";
        public string StateOrRegion => "France";
        public Uri WebSite => new Uri("http://blog.thomaslebrun.net");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://blog.thomaslebrun.net/feed/"); }
        }

        public string GitHubHandle => "ThomasLebrun";
        public GeoPosition Position => new GeoPosition(48.866667, 2.333333);

        public bool Filter(SyndicationItem item) => item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
    }
}