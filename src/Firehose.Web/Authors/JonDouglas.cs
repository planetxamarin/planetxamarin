using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class JonDouglas : IWorkAtXamarinOrMicrosoft
    {
        public string FirstName => "Jon";
        public string LastName => "Douglas";
        public string Title => "Senior Support Engineer";
        public string StateOrRegion => "Utah";
        public string EmailAddress => "";
        public string TwitterHandle => "_jondouglas";

        public Uri WebSite => new Uri("http://www.jon-douglas.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("http://www.jon-douglas.com/atom.xml"); } }

        public DateTime Started => new DateTime(2014, 5, 1);

        public string GravatarHash => "83d67df0b9e002d1c55a2786aeeb0c1b";
    }
}