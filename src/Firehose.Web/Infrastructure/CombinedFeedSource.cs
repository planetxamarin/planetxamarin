using BlogMonster;
using BlogMonster.Configuration;
using BlogMonster.Infrastructure;
using BlogMonster.Infrastructure.SyndicationFeedSources;
using BlogMonster.Infrastructure.SyndicationFeedSources.Remote;
using Firehose.Web.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.ServiceModel.Syndication;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using ThirdDrawer.Extensions.CollectionExtensionMethods;

namespace Firehose.Web.Infrastructure
{
	public class CombinedFeedSource
	{
		private readonly Lazy<Cached<Dictionary<string, IEnumerable<ISyndicationFeedSource>>>> combinedFeedSource;

		public CombinedFeedSource(IAmACommunityMember[] bloggers)
		{
			Bloggers = bloggers;
			var cached = new Cached<Dictionary<string, IEnumerable<ISyndicationFeedSource>>>(TimeSpan.FromHours(1), new SystemClock(), LoadFeeds);
			combinedFeedSource = new Lazy<Cached<Dictionary<string, IEnumerable<ISyndicationFeedSource>>>>(() => cached, LazyThreadSafetyMode.PublicationOnly);

			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;
		}

		private HttpClient GetHttpClient()
		{
			var httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("PlanetXamarin", $"{GetType().Assembly.GetName().Version}"));
			httpClient.Timeout = TimeSpan.FromMinutes(1);

			return httpClient;
		}

		public SyndicationFeed Feed => GetFeed(null);

		public SyndicationFeed GetFeed(string language)
		{
			var groupedFeeds = combinedFeedSource.Value.Value;

			if (string.IsNullOrEmpty(language) || !groupedFeeds.ContainsKey(language))
			{
				language = "mixed";
				return GetCombinedFeed(language, groupedFeeds.Values.SelectMany(f => f)).Feed;
			}

			return GetCombinedFeed(language, groupedFeeds[language]).Feed;
		}

		public IAmACommunityMember[] Bloggers { get; }

		private ISyndicationFeedSource GetCombinedFeed(string language, IEnumerable<ISyndicationFeedSource> feeds)
		{
			return BlogMonsterBuilder.FromOtherFeedSources(feeds.First(), feeds.Skip(1).ToArray())
				.WithRssSettings(
					new RssFeedSettings(ConfigurationManager.AppSettings["BaseUrl"],
						ConfigurationManager.AppSettings["RssFeedTitle"],
						ConfigurationManager.AppSettings["RssFeedDescription"],
						new SyndicationPerson(ConfigurationManager.AppSettings["SyndicationPersonEmail"],
						ConfigurationManager.AppSettings["SyndicationPersonName"],
						ConfigurationManager.AppSettings["BaseUrl"]),
						ConfigurationManager.AppSettings["RssFeedImageUrl"],
						language,
						"The copyright for each post is retained by its author.",
						new Uri(ConfigurationManager.AppSettings["BaseUrl"])))
				.Grr();
		}

		private Dictionary<string, IEnumerable<ISyndicationFeedSource>> LoadFeeds()
		{
			var feedTasks = Bloggers.DistinctByCollection(b => b.FeedUris).SelectMany(b => b.FeedUris,
																					  TryLoadFeedAsync);
			var feedSources = Task.WhenAll(feedTasks).GetAwaiter().GetResult().NotNull();
			var groupedFeeds = feedSources.GroupBy(feed => feed.Feed.Language).ToDictionary(g => g.Key, g => g.AsEnumerable());

			return groupedFeeds;
		}

		internal Task<ISyndicationFeedSource[]> LoadAllFeedsAsync(IEnumerable<IAmACommunityMember> tamarins)
		{
			var feedTasks = tamarins.SelectMany(b => b.FeedUris, TryLoadFeedAsync);
			return Task.WhenAll(feedTasks);
		}

		private Task<ISyndicationFeedSource> TryLoadFeedAsync(IAmACommunityMember tamarin, Uri uri) =>
			TryLoadFeedAsync(tamarin, uri, true);

		private async Task<ISyndicationFeedSource> TryLoadFeedAsync(IAmACommunityMember tamarin, Uri uri, bool tryAgain)
		{

			try
			{
				var feedSource = new DummyRemoteSyndicationFeedSource();

				var filter = GetFilterFunction(tamarin);
				var client = GetHttpClient();
				var feed = await FetchAsync(client, uri, filter).ConfigureAwait(false);
				feed.Language = CultureInfo.CreateSpecificCulture(tamarin.FeedLanguageCode).Name;
				feedSource.Feed = feed;

				return feedSource;
			}
			catch (Exception ex)
			{
				Logger.Error(ex, $"{tamarin.FirstName} {tamarin.LastName}'s feed of {uri} failed to load.");
				if (tryAgain)
					return await TryLoadFeedAsync(tamarin, uri, false);
			}


			// Not my problem if your feed asplodes but we at least won't crash the app for all the other nice people :)
			return null;
		}

		internal static Func<SyndicationItem, bool> GetFilterFunction(IAmACommunityMember tamarin)
		{
			var iFilterMyBlogPosts = tamarin as IFilterMyBlogPosts;

			var filter = iFilterMyBlogPosts != null
				? (Func<SyndicationItem, bool>)iFilterMyBlogPosts.Filter
				: (si => si.ApplyDefaultFilter());

			return filter;
		}

		private static bool WrappedFilter(SyndicationItem item, Func<SyndicationItem, bool> filterFunc)
		{
			try
			{
				return filterFunc(item);
			}
			catch (NullReferenceException)
			{
				// the authors' filter is derped
				// try some sane defaults

				return item.ApplyDefaultFilter();
			}
		}

		internal static async Task<SyndicationFeed> FetchAsync(HttpClient client, Uri feedUri, Func<SyndicationItem, bool> filter)
		{
			HttpResponseMessage response;
			try
			{
				response = await client.GetAsync(feedUri).ConfigureAwait(false);
				if (response.IsSuccessStatusCode)
				{
					using (var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
					using (var reader = new StreamReader(stream))
					using (var xmlReader = XmlReader.Create(reader))
					{
						var feed = SyndicationFeed.Load(xmlReader);
						var filteredItems = feed.Items
							.Where(item => WrappedFilter(item, filter))
							.Where(item =>
								item.LastUpdatedTime.UtcDateTime <= DateTimeOffset.UtcNow &&
								item.PublishDate.UtcDateTime <= DateTimeOffset.UtcNow)
							.ToArray();

						var itemsField = feed.GetType()
							.GetField("items", BindingFlags.Instance | BindingFlags.NonPublic);
						itemsField?.SetValue(feed, filteredItems);
						return feed;
					}
				}
			}
			catch (HttpRequestException hex)
			{
				throw new RemoteSyndicationFeedFailedException("Loading remote syndication feed failed", hex)
					.WithData("FeedUri", feedUri);
			}
			catch (WebException ex)
			{
				throw new RemoteSyndicationFeedFailedException("Loading remote syndication feed timed out", ex)
					.WithData("FeedUri", feedUri);
			}

			throw new RemoteSyndicationFeedFailedException("Loading remote syndication feed failed.")
				.WithData("FeedUri", feedUri)
				.WithData("HttpStatusCode", (int)response.StatusCode);
		}
	}

	public class DummyRemoteSyndicationFeedSource : ISyndicationFeedSource
	{
		public SyndicationFeed Feed { get; set; }
	}

	internal static class ExceptionExtensions
	{
		public static TException WithData<TException>(this TException exception, string key, object value) where TException : Exception
		{
			exception.Data[key] = value;
			return exception;
		}
	}
}