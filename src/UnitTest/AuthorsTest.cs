using Firehose.Web.Infrastructure;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using System.Globalization;
using System.ServiceModel.Syndication;

namespace UnitTest
{
    public class AuthorsTest
    {
        static string[] _interfaceNames =
        {
            nameof(IAmACommunityMember),
            nameof(IWorkAtXamarinOrMicrosoft),
            nameof(IAmAXamarinMVP),
            nameof(IAmAMicrosoftMVP),
            nameof(IAmAPodcast),
            nameof(IAmANewsletter),
            nameof(IAmAFrameworkForXamarin)
        };

        readonly ITestOutputHelper _output;

        Policy _policy = Policy.Handle<WebException>(
            ex => !ex.Message.Contains("Could not create SSL/TLS secure channel"))
            .WaitAndRetryAsync(3, retryAttempt =>
                TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
        static HttpClient _httpClient = new HttpClient();

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

            foreach(var author in authors)
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

            return Task.WhenAll(authors.Select(Author_Has_Secure_And_Parseable_Feed));
        }

        //[Theory]
        //[MemberData(nameof(GetAuthorTestData))]
        //public 
        async Task Author_Has_Secure_And_Parseable_Feed(IAmACommunityMember author)
        {
            foreach (var feedUri in author.FeedUris)
            {
                Assert.Equal("https", feedUri.Scheme);
            }

            var authors = new IAmACommunityMember[] { author };
            var feedSource = new CombinedFeedSource(authors);
            var feed = await feedSource.LoadAllFeedsAsync(authors).ConfigureAwait(false);

            Assert.NotEmpty(feed);
            Assert.True(feed.SelectMany(f => f.Feed.Items).Count() > 0, $"Feed(s) for {author.FirstName} {author.LastName} is empty");
        }

        private async Task<(bool, SyndicationFeed)> HitFeedAsync(IAmACommunityMember author, Uri feedUrl)
        {
            try
            {
                var response = await _policy.ExecuteAsync(() => _httpClient.GetAsync(feedUrl))
                    .ConfigureAwait(false);

                var filter = CombinedFeedSource.GetFilterFunction(author);
                var feed = await CombinedFeedSource.FetchAsync(feedUrl, filter).ConfigureAwait(false);
                return (true, feed);
            }
            catch
            {
                _output.WriteLine($"{feedUrl} sucks...");
                return (false, null);
            }
        }

        [Theory]
        [MemberData(nameof(GetAuthorTestData))]
        public void Author_Specified_Valid_LanguageCode(IAmACommunityMember author)
        {
            var cultureNames = CultureInfo.GetCultures(CultureTypes.NeutralCultures).Select(c => c.Name);
            Assert.Contains(author.FeedLanguageCode, cultureNames);
        }

        public static IEnumerable<object[]> GetAuthorTestData() => GetAuthors().Select(author => new object[] { author });

        private static IEnumerable<IAmACommunityMember> GetAuthors()
        {
            var assembly = Assembly.GetAssembly(typeof(IAmACommunityMember));
            var cultureNames = CultureInfo.GetCultures(CultureTypes.NeutralCultures).Select(c => c.Name);

            var types = assembly.GetTypes();
            var authorTypes = types.Where(t => typeof(IAmACommunityMember).IsAssignableFrom(t) &&
                !_interfaceNames.Contains(t.Name));

            foreach(var authorType in authorTypes)
            {
                var author = (IAmACommunityMember)Activator.CreateInstance(authorType);
                yield return author;
            }
        }
    }
}