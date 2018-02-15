using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class ReactiveUI : IAmAFrameworkForXamarin, IFilterMyBlogPosts
    {
        public string FirstName => "ReactiveUI";
        public string LastName => "";
        public string StateOrRegion => "Internet";
        public string EmailAddress => "hello@reactiveui.net";
        public string ShortBioOrTagLine => "An advanced, composable, functional reactive model-view-viewmodel framework for all .NET platforms";
        public Uri WebSite => new Uri("https://reactiveui.net/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://reactiveui.net/rss"); }
        }

        public string TwitterHandle => "ReactiveXUI";
        public string GravatarHash => "";
        public string GitHubHandle => "ReactiveUI";
        public GeoPosition Position => new GeoPosition(-13.6981464, 37.3979239);
        public bool Filter(SyndicationItem item) => true;
        public string FeedLanguageCode => "en";
    }
}