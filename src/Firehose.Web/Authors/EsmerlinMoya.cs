using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
	public class EsmerlinMoya : IAmACommunityMember
    {
		public string FirstName => "Esmerlin";
        public string LastName => "Rosario Moya";
        public string StateOrRegion => "Dominican Republic";
        public string EmailAddress => "esmerlinmoya@gmail.com";
        public string ShortBioOrTagLine => "Software and Mobile Developer";
        public GeoPosition Position => new GeoPosition(18.503112, -69.889555);

        public string TwitterHandle => "merlin1827";
        public string GitHubHandle => "esmerlinmoya";
        public string GravatarHash => "7a6f9f3adcdd5eb3737bce3e52719997";
        public Uri WebSite => new Uri("https://medium.com/@esmerlinmoya");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://medium.com/feed/@esmerlinmoya"); } }
        public string FeedLanguageCode => "en";
	}
}
