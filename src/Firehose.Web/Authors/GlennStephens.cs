using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class GlennStephens : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Glenn";
        public string LastName => "Stephens";
        public string StateOrRegion => "Sunshine Coast, Australia";
        public string EmailAddress => "Glenn.Stephens@microsoft.com";
        public string ShortBioOrTagLine => "is one of the Xamarin University instructors";
        public Uri WebSite => new Uri("https://glennstephensblog.azurewebsites.net/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://glennstephensblog.azurewebsites.net/tag/mobile/rss/"); }
        }

        public string TwitterHandle => "glenntstephens";
        public string GravatarHash => "ffc4ec4a7133be87d2587325ac7b1d00";
        public string GitHubHandle => "glennstephens";
        public GeoPosition Position => new GeoPosition(-26.6500000, 153.0666670);
        public string FeedLanguageCode => "en";

    }
}