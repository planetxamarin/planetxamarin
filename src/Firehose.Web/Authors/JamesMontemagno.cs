using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
	public class JamesMontemagno : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "James";

        public string LastName => "Montemagno";

        public string StateOrRegion => "Seattle, WA";

        public string EmailAddress => "";

        public string Title => "Principal Program Manager";

        public Uri WebSite => new Uri("http://motzcod.es");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://motzcod.es/rss"); }
        }

        public string TwitterHandle => "jamesmontemagno";


        public string GravatarHash => "5df4d86308e585c879c19e5f909d8bfe";

		public DateTime Started => new DateTime(2013, 10, 11); 
			
	}
}