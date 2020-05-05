using System.Linq;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Extensions
{
    public static class SyndicationItemExtensions
    {
        public static bool ApplyDefaultFilter(this SyndicationItem item)
        {
            if (item == null)
                return false;

            var hasXamarinCategory = false;
            var hasXamarinKeywords = false;

            if (item.Categories.Count > 0)
            {
                hasXamarinCategory = item.Categories.Any(category =>
                    category.Name.ToLowerInvariant().Contains("xamarin"));
            }

            if (item.ElementExtensions.Count > 0)
            {
                var element = item.ElementExtensions.FirstOrDefault(e => e.OuterName == "keywords");
                if (element != null)
                {
                    var keywords = element.GetObject<string>();
                    hasXamarinKeywords = keywords.ToLowerInvariant().Contains("xamarin");
                }
            }

            var hasXamarinTitle = item.Title?.Text.ToLowerInvariant().Contains("xamarin") ?? false;

            return hasXamarinTitle || hasXamarinCategory || hasXamarinKeywords;
        }

		public static string ToHtml(this SyndicationContent content)
		{
			var textSyndicationContent = content as TextSyndicationContent;
			if (textSyndicationContent != null)
			{
				return textSyndicationContent.Text;
			}

			return content.ToString();
		}
	}
}