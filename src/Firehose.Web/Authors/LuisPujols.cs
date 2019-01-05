using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class LuisPujols : IAmACommunityMember
    {
        public string FirstName => "Luis";
        public string LastName => "Pujols";
        public string StateOrRegion => "United States";
        public string EmailAddress => "luispujolso@gmail.com";
        public string ShortBioOrTagLine => "is a Software Engineer with a passion for Mobile Development and Software Architecture. Co-organizer of the .NET Community in the Dominican Republic and a Xamarin Lover.";
        public Uri WebSite => new Uri("https://www.pujolsluis.com/");
        public string TwitterHandle => "Pujolsluis1";
        public string GitHubHandle => "Pujolsluis";
        public string GravatarHash => "c91c0d654f4f06ca6e7a7e54699de85d";

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.pujolsluis.com/rss"); }
        }
        public GeoPosition Position => new GeoPosition(26.0203048, -80.115093);
        public string FeedLanguageCode => "en";
    }
}
