using System.ServiceModel.Syndication;
using System.Web.Mvc;
using System.Xml;

namespace Firehose.Web.Infrastructure
{
	public class RssFeedResult : ActionResult
	{
		private readonly SyndicationFeed _feed;

		public RssFeedResult(SyndicationFeed feed)
		{
			_feed = feed;
		}

		public override void ExecuteResult(ControllerContext context)
		{
			context.HttpContext.Response.ContentType = "application/rss+xml";

			var rssFormatter = new Rss20FeedFormatter(_feed);
			using (var writer = XmlWriter.Create(context.HttpContext.Response.Output))
			{
				rssFormatter.WriteTo(writer); 
			}
		}
	}
}
