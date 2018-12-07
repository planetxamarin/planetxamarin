using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
 namespace Firehose.Web.Authors
{
    public class DanielHindrikes : IAmAMicrosoftMVP
    {
        public string FirstName => "Daniel";
         public string LastName => "Hindrikes";
         public string StateOrRegion => "Borlänge, Sweden";
         public string EmailAddress => "daniel@hindrikes.se";
         public string ShortBioOrTagLine => "is an architect and developer using Xamarin and Azure. Working as a Ninja at tretton37. Also recording \"The Code Behind\" podcast!";
         public Uri WebSite => new Uri("https://danielhindrikes.se");
         public string TwitterHandle => "hindrikes";
         public string GitHubHandle => "dhindrik";
         public string GravatarHash => "054db2cfd79654ec5d92e20c180f2d72";
         public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://danielhindrikes.se/index.php/feed/"); }
        }
         public GeoPosition Position => new GeoPosition(60.48604, 15.43391);
         public string FeedLanguageCode => "en";
    }
}
