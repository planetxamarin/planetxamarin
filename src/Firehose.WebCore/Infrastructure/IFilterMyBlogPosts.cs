using System.ServiceModel.Syndication;

namespace Firehose.Web.Infrastructure
{
    public interface IFilterMyBlogPosts
    {
        bool Filter(SyndicationItem item);
    }
}