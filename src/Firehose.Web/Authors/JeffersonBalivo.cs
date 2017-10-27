﻿using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Authors
{
    public class JeffersonBalivo : IAmACommunityMember
    {
        public string FirstName => "Jefferson";
        public string LastName => "Balivo";
        public string StateOrRegion => "São Paulo, Brazil";
        public string EmailAddress => "jefferson@balivo.com.br";
        public string ShortBioOrTagLine => "Xamarin Developer (since Xamarin was just Mono4Android and MonoTouch, ~2009)";
        public Uri WebSite => new Uri("http://balivo.com.br/");
        public string TwitterHandle => "jbalivo";
        public string GitHubHandle => "balivo";
        public string GravatarHash => string.Empty;
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://balivo.com.br/rss"); } }
        public GeoPosition Position => new GeoPosition(-22.2997067, -48.5931324);
        public bool Filter(SyndicationItem item) => item.Title.Text.ToLowerInvariant().Contains("xamarin") || item.Categories.Any(category => category.Name.ToLowerInvariant().Contains("xamarin"));
    }
}