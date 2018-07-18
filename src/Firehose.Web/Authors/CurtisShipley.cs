using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class CurtisShipley : IAmACommunityMember
    {
        public string FirstName => "Curtis";
        public string LastName => "Shipley";	
        public string StateOrRegion => "Oregon, USA";
        public string EmailAddress => "curtis@saltydogtechnology.com";
        public string ShortBioOrTagLine => "Full stack mobile developer.";
        public Uri WebSite => new Uri("https://www.saltydogtechnology.com/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.saltydogtechnology.com/category/xamarin/feed/"); }
        }

        public string TwitterHandle => "CurtisShipley3";
        public string GravatarHash => "cbeaeab922ba29556c6235aeebc9e6f4";
        public string GitHubHandle => "curtisshipley";
        public GeoPosition Position => new GeoPosition(45.5190048, -122.6739562);

        public string FeedLanguageCode => "en";
    }
}