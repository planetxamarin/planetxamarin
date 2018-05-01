using System.Linq;
using System.ServiceModel.Syndication;
using Firehose.Web.Extensions;
using Xunit;

namespace UnitTest
{
    public class IEnumerableExtensionsTest
    {
        [Fact]
        public void DistinctBySyndicationItemId_WithDuplicateIds_Test()
        {
            var items = new SyndicationItem[]
            {
                new SyndicationItem { Id = "http://blog.com/?p=23" },
                new SyndicationItem { Id = "http://blog.com/?p=23" }
            };

            var filteredItems = items.DistinctBy(i => i.Id).ToList();
            Assert.Single(filteredItems);
        }

        [Fact]
        public void DistinctBySyndicationItemId_WithDuplicateIdsInDifferentLetterCases_Test()
        {
            var items = new SyndicationItem[]
            {
                new SyndicationItem { Id = "http://blog.com/?p=23" },
                new SyndicationItem { Id = "http://blog.com/?P=23" }
            };
            var filteredItems = items.DistinctBy(i => i.Id).ToList();
            Assert.Single(filteredItems);
        }

        [Fact]
        public void DistinctBySyndicationItemId_WithoutDuplicateIds_Test()
        {
            var items = new SyndicationItem[]
            {
                new SyndicationItem { Id = "http://blog.com/?p=23" },
                new SyndicationItem { Id = "http://blog.com/?p=24" }
            };
            var filteredItems = items.DistinctBy(i => i.Id).ToList();
            Assert.Equal(items.Length, filteredItems.Count);
        }

        [Fact]
        public void DistinctBySyndicationItemId_WithEmptyArray_Test()
        {
            var items = new SyndicationItem[] { };
            var filteredItems = items.DistinctBy(i => i.Id).ToList();
            Assert.Equal(items.Length, filteredItems.Count);
        }
    }
}