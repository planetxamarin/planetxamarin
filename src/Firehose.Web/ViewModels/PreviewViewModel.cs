using System.ServiceModel.Syndication;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.ViewModels
{
    public class PreviewViewModel
    {
        public SyndicationFeed Feed { get; set; }
        public IAmACommunityMember[] Bloggers { get; set; }
    }
}