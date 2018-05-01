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

            var hasXamarinTitle = item.Title?.Text.ToLowerInvariant().Contains("xamarin") ?? false;

            return hasXamarinTitle || hasXamarinCategory;
        }
    }
}