using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class KentBoogaart : IAmAMicrosoftMVP
    {
        public string FirstName => "Kent";

        public string LastName => "Boogaart";

        public string StateOrRegion => "Australia";

        public string EmailAddress => "kent.boogaart@gmail.com";

        public string ShortBioOrTagLine => "kick-ass software engineer";

        public Uri WebSite => new Uri("http://kent-boogaart.com/");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("http://kent-boogaart.com/atom.xml"); }
        }

        public string TwitterHandle => "kent_boogaart";

        public DateTime FirstAwarded => new DateTime(2009, 04, 01);
        public string GravatarHash => "";
    }
}
