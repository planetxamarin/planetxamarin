using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;
using System.ServiceModel.Syndication;
using System.Linq;

namespace Firehose.Web.Authors
{
    public class JavierSuarez : IAmAMicrosoftMVP, IFilterMyBlogPosts
    {
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://javiersuarezruiz.wordpress.com/feed/"); }
        }

        public string FirstName => "Javier";
        public string LastName => "Suarez";
        public string StateOrRegion => "Seville, Spain";
        public string EmailAddress => "javiersuarezruiz@hotmail.com";
        public string Title => "Software Developer";
        public Uri WebSite => new Uri("http://javiersuarezruiz.wordpress.com");
        public string TwitterHandle => "jsuarezruiz";
        public DateTime FirstAwarded => new DateTime(2014, 07, 01);
        public string GravatarHash => "";

        public bool Filter(SyndicationItem item)
        {
            return item.Categories.Any(c => c.Name.ToLowerInvariant().Equals("xamarin"));
        }
    }
}