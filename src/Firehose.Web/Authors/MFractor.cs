using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MFractor : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "MFractor";
        public string LastName => "";
        public string StateOrRegion => "Brisbane, Australia";
        public string EmailAddress => "matthew@mfractor.com";
        public string ShortBioOrTagLine => "is a powerful productivity tool for Xamarin Developers.";
        public Uri WebSite => new Uri("https://www.mfractor.com/");
        public string TwitterHandle => "mfractor";
        public string GitHubHandle => "mfractor";
        public string GravatarHash => "35bac056166a67222ddcd48b57113a32";

        public IEnumerable<Uri> FeedUris
        {
            get
            {
               return new List<Uri>()
               {
                 new Uri("https://www.mfractor.com/blogs/news.atom")
               };
            }
        }

        public GeoPosition Position => new GeoPosition(-27.470125, 153.021072);
        public string FeedLanguageCode => "en";
		
		public bool Filter(SyndicationItem item)
		{
			// Filter out any topics that are for Visual Studio extensibility;
			var isExtensibilityTopic = item.Categories?.Any(c => c.Name.ToLowerInvariant().Equals("visual studio extensibility")) ?? false;
			
			if (isExtensibilityTopic)
			{
				return false;
			}
			
			return true;
		}
    }
}
