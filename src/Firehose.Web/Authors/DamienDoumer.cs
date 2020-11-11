using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace Firehose.Web.Authors
{
    public class DamienDoumer : IAmACommunityMember
    {
        public string FirstName => "Damien";

        public string LastName => "Doumer";

        public string StateOrRegion => "Douala, Cameroon";

        public string EmailAddress => "damientohin@gmail.com";

        public string ShortBioOrTagLine => "Fresh Fullstack .Net developer, who loves mobile app development in particular.";

        public Uri WebSite => new Uri("https://doumer.me/");

        public IEnumerable<Uri> FeedUris
        {
            get 
			{
				return new[] 
				{
					new Uri("https://doumer.me/feed/"),
					new Uri("https://www.youtube.com/feeds/videos.xml?channel_id=UCdIg2HyCYIa4u75NLnfpt7A")
				};
			}
        }

        public string TwitterHandle => "Damien_Doumer";

        public string GravatarHash => "ecdd93df62c61daa04da17967f82d08d";
        public string GitHubHandle => "damiendoumer";
        public GeoPosition Position => new GeoPosition(4.07316844239285, 9.684240818616558);

        public string FeedLanguageCode => "en";
	}
}