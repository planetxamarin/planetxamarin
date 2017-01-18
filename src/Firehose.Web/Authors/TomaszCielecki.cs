using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class TomaszCielecki : IAmAXamarinMVP
    {
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://blog.ostebaronen.dk/feeds/posts/default"); }
        }

        public string FirstName => "Tomasz";
        public string LastName => "Cielecki";
        public string StateOrRegion => "Copenhagen, Denmark";
        public string EmailAddress => "tomasz@ostebaronen.dk";
        public string Title => "software engineer";
        public Uri WebSite => new Uri("http://blog.ostebaronen.dk");
        public string TwitterHandle => "Cheesebaron";
        public string GithubHandle => string.Empty;
        public DateTime FirstAwarded => new DateTime(2015, 1, 1);
        public string GravatarHash => "f780d57997526876b0625e517c1e0884";
    }
}
