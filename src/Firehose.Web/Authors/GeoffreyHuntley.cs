using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class GeoffreyHuntley : IAmAMicrosoftMVP
    {
        public string FirstName => "Geoffrey";
        public string LastName => "Huntley";
        public string Title => "Like's both promite and vegemite.";
        public string StateOrRegion => "Sydney, Australia";
        public string EmailAddress => "geoffrey@ghuntley.com";
        public string TwitterHandle => "geoffreyhuntley";

        public Uri WebSite => new Uri("https://ghuntley.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://ghuntley.com/atom.xml"); } }

        public DateTime FirstAwarded => new DateTime(2017, 1, 1);
    }
}