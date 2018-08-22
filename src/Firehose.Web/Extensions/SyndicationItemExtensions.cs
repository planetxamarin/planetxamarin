using System.Linq;
using System.ServiceModel.Syndication;

namespace Firehose.Web.Extensions
{
    public static class SyndicationItemExtensions
    {
        public static bool ApplyDefaultFilter(this SyndicationItem item)
        {
            var hasXamarinCategory = false;

            if (item.Categories.Count > 0)
                hasXamarinCategory = item.Categories.Any(category =>
                    category.Name.ToLowerInvariant().Contains("xamarin"));
            else if(item.ElementExtensions.Count > 0)
            {
                var element = item.ElementExtensions.Where(e => e.OuterName == "keywords").FirstOrDefault();
                if(element != null)
                {
                    var keywords = element.GetObject<string>();
                    hasXamarinCategory = keywords.ToLowerInvariant().Contains("xamarin");
                }
            }

            var hasXamarinTitle = item.Title?.Text.ToLowerInvariant().Contains("xamarin") ?? false;

            return hasXamarinTitle || hasXamarinCategory;
        }
    }
}