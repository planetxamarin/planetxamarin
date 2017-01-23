using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class RoyCornelissen : IAmAXamarinMVP
    {
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://roycornelissen.wordpress.com/tag/mobile/feed/"); }
        }

        public string EmailAddress => "roy.cornelissen@gmail.com";
        public string FirstName => "Roy";
        public string LastName => "Cornelissen";
        public string StateOrRegion => "Doetinchem, The Netherlands";
        public string ShortBioOrTagLine => "Was already digging it when it was still called MonoTouch";
        public string TwitterHandle => "roycornelissen";
        public Uri WebSite => new Uri("https://roycornelissen.wordpress.com/");
        public string GravatarHash => "7add183b9b903f279d61298508fb06ad";
        public string GitHubHandle => "roycornelissen";
        public GeoPosition Position => new GeoPosition(51.956047, 6.267367);
    }
}