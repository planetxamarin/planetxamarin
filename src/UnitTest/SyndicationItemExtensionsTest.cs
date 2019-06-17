using Firehose.Web.Extensions;
using System;
using System.ServiceModel.Syndication;
using Xunit;

namespace UnitTest
{
    public class SyndicationItemExtensionsTest
    {
        [Fact]
        public void FilterXamarinTitleTest()
        {
            var item = new SyndicationItem("some blog post about xamarin android stuff", "whatever", new Uri("http://derp.org"));

            var ok = item.ApplyDefaultFilter();
            Assert.True(ok);

            item = new SyndicationItem("some blog post about native android stuff", "whatever", new Uri("http://derp.org"));

            ok = item.ApplyDefaultFilter();
            Assert.False(ok);
        }

        [Fact]
        public void FilterXamarinCategoryTest()
        {
            var item = new SyndicationItem();
            item.Categories.Add(new SyndicationCategory("android"));
            item.Categories.Add(new SyndicationCategory("ios"));
            item.Categories.Add(new SyndicationCategory("xamarin"));

            var ok = item.ApplyDefaultFilter();
            Assert.True(ok);

            item.Categories.RemoveAt(2);

            ok = item.ApplyDefaultFilter();
            Assert.False(ok);
        }

        [Fact]
        public void FitlerXamarinTitleAndCategoryTest()
        {
            var item = new SyndicationItem("some blog post about xamarin android stuff", "whatever", new Uri("http://derp.org"));
            item.Categories.Add(new SyndicationCategory("xamarin"));

            var ok = item.ApplyDefaultFilter();
            Assert.True(ok);

            item = new SyndicationItem("some blog post about java android stuff", "whatever", new Uri("http://derp.org"));
            item.Categories.Add(new SyndicationCategory("java"));

            ok = item.ApplyDefaultFilter();
            Assert.False(ok);

            item = new SyndicationItem("some blog post about java android stuff", "whatever", new Uri("http://derp.org"));
            item.Categories.Add(new SyndicationCategory("xamarin"));

            ok = item.ApplyDefaultFilter();
            Assert.True(ok);

            item = new SyndicationItem("some blog post about xamarin android stuff", "whatever", new Uri("http://derp.org"));
            item.Categories.Add(new SyndicationCategory("java"));

            ok = item.ApplyDefaultFilter();
            Assert.True(ok);
        }
    }
}
