using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Xml;
using Firehose.Web.Extensions;
using Firehose.Web.Infrastructure;
using Humanizer;

namespace Firehose.Web.ViewModels
{
    public class PreviewViewModel
    {
        public List<PreviewModelItem> Items { get; }

		public PreviewViewModel(SyndicationFeed feed, IAmACommunityMember[] authors)
		{
			var items = new List<PreviewModelItem>();
			foreach(var item in feed.Items)
			{
				var itemUri = item.Links.FirstOrDefault();
				var author = authors.FirstOrDefault(b => 
					b.FeedUris.Any(u => itemUri != null && (itemUri.Uri.Host == u.Host || itemUri.Uri.Host.Replace("www.", "") == u.Host.Replace("www.", ""))));

				string authorName;

				if (author != null)
				{
					authorName = author.FirstName + " " + author.LastName;
				}
				// If no author was matched, extract the name from the RSS feed, something is better than nothing right?!
				else
				{
					var creator = item.ElementExtensions.FirstOrDefault(x => x.OuterName == "creator" && x.OuterNamespace == "http://purl.org/dc/elements/1.1/");
					authorName = creator.GetObject<XmlElement>().Value ?? string.Empty;
				}

				var link = item.Links.FirstOrDefault()?.Uri.ToString() ?? string.Empty;
				var html = item.Content?.ToHtml() ?? item.Summary?.ToHtml() ?? string.Empty;

				var previewItem = new PreviewModelItem
				{
					AuthorName = authorName,
					Gravatar = author?.GravatarImage(),
					Title = item.Title.Text,
					Link = link,
					Body = html.Sanitize(),
					PublishDate = item.PublishDate.Humanize()
				};

				items.Add(previewItem);
			}

			Items = items;
		}
    }

	public class PreviewModelItem
	{
		public string AuthorName { get; set; }
		public string Gravatar { get; set; }
		public string Title { get; set; }
		public string Link { get; set; }
		public string Body { get; set; }
		public string PublishDate { get; set; }
	}
}