using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class GeoffreyHuntley : IAmAMicrosoftMVP, IAmAXamarinMVP
    {
        public string FirstName => "Geoffrey";
        public string LastName => "Huntley";
        public string ShortBioOrTagLine => "has been involved in the Xamarin community since the early ​monotouch/monodroid days";
        public string StateOrRegion => "Sydney, Australia";
        public string EmailAddress => "ghuntley@ghuntley.com";
        public string TwitterHandle => "geoffreyhuntley";

        public Uri WebSite => new Uri("https://ghuntley.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://ghuntley.com/feed.atom"); }
        }

        public string GravatarHash => "";
        public string GitHubHandle => "ghuntley";
        public GeoPosition Position => new GeoPosition(-29.044725, 141.0844449);
    }
}
