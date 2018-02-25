using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class PieterNijs : IAmACommunityMember
    {
        public string FirstName => "Pieter";
        public string LastName => "Nijs";
        public string ShortBioOrTagLine => "Senior .NET Software Engineer & Competence Leader Mobile @ Ordina Belgium. Passionate about programming, especially .NET, C#, XAML, Xamarin and UWP.";
        public string StateOrRegion => "Hasselt, Belgium";
        public string EmailAddress => "pieternijs@live.be";
        public string TwitterHandle => "nijspieter";
        public string GravatarHash => "61c9184b95820bdbbcd51764f3b9fb6e";
        public string GitHubHandle => "PieEatingNinjas";
        public GeoPosition Position => new GeoPosition(50.93, 5.3375);
        public Uri WebSite => new Uri("https://blog.pieeatingninjas.be/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://blog.pieeatingninjas.be/feed/rss"); } }
        public string FeedLanguageCode => "en";
    }
}