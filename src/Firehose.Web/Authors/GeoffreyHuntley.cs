using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class GeoffreyHuntley : IAmACommunityMember
    {
        public string FirstName => "Geoffrey";
        public string LastName => "Huntley";
        public string Title => "Lead Consultant";
        public string StateOrRegion => "NSW";
        public string EmailAddress => "geoffrey.huntley@readify.net";
        public string TwitterHandle => "geoffreyhuntley";

        public Uri WebSite => new Uri("https://ghuntley.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://ghuntley.com/atom.xml"); } }
    }
}