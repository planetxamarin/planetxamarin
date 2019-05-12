using Firehose.Web.Infrastructure;
using Polly;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace UnitTest
{
	public class AuthorsTest
	{
		private static string[] _interfaceNames =
		{
			nameof(IAmACommunityMember),
			nameof(IWorkAtXamarinOrMicrosoft),
			nameof(IAmAXamarinMVP),
			nameof(IAmAMicrosoftMVP),
			nameof(IAmAPodcast),
			nameof(IAmANewsletter),
			nameof(IAmAFrameworkForXamarin),
			nameof(IAmAYoutuber)
		};

		private readonly ITestOutputHelper _output;

		private Policy _policy = Policy.Handle<WebException>(
			ex => !ex.Message.Contains("Could not create SSL/TLS secure channel"))
			.WaitAndRetryAsync(3, retryAttempt =>
				TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));

		public AuthorsTest(ITestOutputHelper output)
		{
			_output = output;

			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;
		}

		[Fact]
		public void All_Authors_Implement_Interface()
		{
			var assembly = Assembly.GetAssembly(typeof(IAmACommunityMember));

			var types = assembly.GetTypes();
			var authors = types.Where(t => t.IsClass && t.Namespace == "Firehose.Web.Authors" &&
				!t.Name.Contains("<"));

			foreach (var author in authors)
			{
				Assert.True(typeof(IAmACommunityMember).IsAssignableFrom(author),
					$"{author.Name} does not implement interface IAmACommunityMember");
			}
		}

		[Fact]
		public void All_Authors_Are_In_Authors_Namespace()
		{
			var assembly = Assembly.GetAssembly(typeof(IAmACommunityMember));

			var types = assembly.GetTypes();
			var authors = types.Where(t => typeof(IAmACommunityMember).IsAssignableFrom(t) &&
				!_interfaceNames.Contains(t.Name)).ToArray();

			foreach (var author in authors)
			{
				Assert.True(author.Namespace == "Firehose.Web.Authors",
					$"{author.Name} is not in the correct namespace");
			}
		}

		[Fact]
		public Task All_Authors_Have_Secure_And_Parsable_Feed()
		{
			var authors = GetAuthors();

			// using MemberData for this test is slow. Intentionally using Task.WhenAll here!
			return Task.WhenAll(authors.Select(Author_Has_Secure_And_Parseable_Feed).Select(t => _policy.ExecuteAsync(() => t)));
		}

		private async Task Author_Has_Secure_And_Parseable_Feed(IAmACommunityMember author)
		{
			try
			{
				foreach (var feedUri in author.FeedUris)
					Assert.Equal("https", feedUri.Scheme);

				var authors = new[] { author };
				var feedSource = new CombinedFeedSource(authors);
				var allFeeds = await feedSource.LoadAllFeedsAsync(authors).ConfigureAwait(false);

				Assert.NotNull(allFeeds);

				var allItems = allFeeds.SelectMany(f => f?.Feed?.Items).Where(i => i != null).ToList();

				Assert.True(allItems?.Count > 0, $"Author {author?.FirstName} {author?.LastName} @{author?.GitHubHandle} doesn't meet post policy @{author?.FeedUris?.FirstOrDefault()?.OriginalString}");
			}
			catch (Exception)
			{
				Assert.True(false, $"Feed(s) for {author.FirstName} {author.LastName}  @{author?.GitHubHandle}  is null or empty @{author?.FeedUris?.FirstOrDefault()?.OriginalString}");
				_output.WriteLine($"Feed(s) for {author.FirstName} {author.LastName} is null or empty");

				if (author is IAmAYoutuber youtuber)
				{
					_output.WriteLine("Auhtor is a YouTuber, and will at max have 15 items in feed, ignore empty feed");
					return;
				}

				throw;
			}
		}

		[Theory]
		[MemberData(nameof(GetAuthorTestData))]
		public void Author_Specified_Valid_LanguageCode(IAmACommunityMember author)
		{
			var cultureNames = CultureInfo.GetCultures(CultureTypes.NeutralCultures).Select(c => c.Name);
			Assert.Contains(author.FeedLanguageCode, cultureNames);
		}

		[Theory]
		[MemberData(nameof(GetAuthorTestData))]
		public void Author_Has_FirstName(IAmACommunityMember author)
		{
			Assert.NotEmpty(author.FirstName);
		}

		[Theory]
		[MemberData(nameof(GetAuthorTestData))]
		public void Author_Has_Website(IAmACommunityMember author)
		{
			Assert.NotNull(author.WebSite);
			Assert.True(author.WebSite.IsWellFormedOriginalString());
		}

		[Theory]
		[MemberData(nameof(GetAuthorTestData))]
		public void Author_Has_Valid_Coordinates(IAmACommunityMember author)
		{
			if (author.Position == null)
				return;

			if (author.Position == GeoPosition.Empty)
				return;

			Assert.InRange(author.Position.Lat, -90.0, 90);
			Assert.InRange(author.Position.Lng, -180.0, 180);
		}

		public static IEnumerable<object[]> GetAuthorTestData() => GetAuthors().Select(author => new object[] { author });

		private static IEnumerable<IAmACommunityMember> GetAuthors()
		{
			var assembly = Assembly.GetAssembly(typeof(IAmACommunityMember));

			var types = assembly.GetTypes();
			var authorTypes = types.Where(t => typeof(IAmACommunityMember).IsAssignableFrom(t) &&
				!_interfaceNames.Contains(t.Name));

			foreach (var authorType in authorTypes)
			{
				var author = (IAmACommunityMember)Activator.CreateInstance(authorType);
				yield return author;
			}
		}
	}
}