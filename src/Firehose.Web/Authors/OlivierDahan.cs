using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class OlivierDahan : IAmAMicrosoftMVP
    {
        public string FirstName => "Olivier";
        public string LastName => "Dahan";
        public string ShortBioOrTagLine => "Consultant Architecte C# XAML MVVM";
        public string StateOrRegion => "France";
        public string EmailAddress => "odahan@gmail.com";
        public string TwitterHandle => "odenaxos";
        public string GravatarHash => "7a41b85a489f96b2d48fb6345d5ef31a";
        public string GitHubHandle => "odahan";
        public GeoPosition Position => new GeoPosition(47.99729, 2.736291);

        public Uri WebSite => new Uri("http://e-naxos.com/blog");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://www.e-naxos.com/blog/syndication.axd"); } }
        public string FeedLanguageCode => "fr";
    }
}