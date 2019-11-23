using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class FrancoisRaminosona : IAmAMicrosoftMVP
    {
        public string FirstName => "Francois";
        public string LastName => "Raminosona";
        public string StateOrRegion => "Norway";
        public string EmailAddress => "framinosona@hotmail.fr";
        public string ShortBioOrTagLine => "Passionate Xamarin/Microsoft technologies developer";
        public Uri WebSite => new Uri("https://blog.francois.raminosona.com/");
        public IEnumerable<Uri> FeedUris
        {
            get
            {
                yield return new Uri("https://blog.francois.raminosona.com/tag/xamarin/rss/");
            }
        }
        public string TwitterHandle => "framinosona";
        public string GravatarHash => "b3b91b8d4bd1e716982eef6e5228c92f";
        public string GitHubHandle => "framinosona";
        public GeoPosition Position => new GeoPosition(58.9720089, 5.7363974);
        public string FeedLanguageCode => "en";
    }
}
