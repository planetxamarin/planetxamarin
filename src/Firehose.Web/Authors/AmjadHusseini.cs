using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Authors
{
    public class AmjadAlhusseini: IAmACommunityMember
    {
        public string FirstName => "Amjad";
        public string LastName => "Alhusseini";
        public string StateOrRegion => "Jordan";
        public string TwitterHandle => "Amjad_Husseini";
        public string EmailAddress => "amjad_h_cool@hotmail.com";
        public string ShortBioOrTagLine => "A Web/Mobile lead developer @aramex | Technology enthusiastic | Body builder and Guitar player";
        public string GravatarHash => "7eb71ff7195835154692f3fe61a0dfa8";
        public Uri WebSite => new Uri("https://amjadhusseini.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://amjadhusseini.com/feed"); }
        }

        public string GitHubHandle => "amjad-Alhusseini";

        public bool Filter(SyndicationItem item) =>
            item.Title.Text.ToLowerInvariant().Contains("xamarin") ||
            item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
        public GeoPosition Position => new GeoPosition(31.973531, 35.860334);
    }
}
