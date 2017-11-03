using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
    public class JonPeppers : IAmAXamarinMVP, IFilterMyBlogPosts
    {
        public string FirstName => "Jon";
        public string LastName => "Peppers";
        public string ShortBioOrTagLine => "Software Engineer on the Xamarin.Android team";
        public string StateOrRegion => "Bowling Green, KY";
        public string EmailAddress => "jonathan.peppers@gmail.com";
        public string TwitterHandle => "jonathanpeppers";
        public string GravatarHash => "ad57dcc21d67832387ce8abb879c3bba";
        public string GitHubHandle => "jonathanpeppers";
        public GeoPosition Position => new GeoPosition(36.9726673,-86.5600474);

        public Uri WebSite => new Uri("https://jonathanpeppers.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://jonathanpeppers.com/Home/Feed"); } }

        public bool Filter(SyndicationItem item)
        {
            return item.Title.Text.ToLowerInvariant().Contains("xamarin");
        }
    }
}