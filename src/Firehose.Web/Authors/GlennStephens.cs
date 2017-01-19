using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web
{
    public class GlennStephens : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Glenn";

        public string LastName => "Stephens";

        public string StateOrRegion => "Sunshine Coast, Australia";

        public string EmailAddress => "";

        public string ShortBioOrTagLine => Ssenior Trainer at Xamarin University";

        public Uri WebSite => new Uri("http://www.glennstephens.com.au/tag/xamarin/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://www.glennstephens.com.au/tag/xamarin/rss/"); }
        }

        public string TwitterHandle => "glenntstephens";

        public string GravatarHash => "ffc4ec4a7133be87d2587325ac7b1d00";

        public string GitHubHandle => string.Empty;
        public GeoPosition Position => new GeoPosition(-26.6500000, 153.0666670);
    }
}