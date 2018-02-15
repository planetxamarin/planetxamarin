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

namespace UnitTest
{
    public class AuthorsTest
    {
        string[] _interfaceNames =
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
        public async Task All_Authors_Have_Secure_Feed()
        {
            var assembly = Assembly.GetAssembly(typeof(IAmACommunityMember));

            var types = assembly.GetTypes();
            var authorTypes = types.Where(t => typeof(IAmACommunityMember).IsAssignableFrom(t) &&
                !_interfaceNames.Contains(t.Name)).ToArray();

            var hitFeedTasks = new List<Task>();
            foreach(var authorType in authorTypes)
            {
                var author = (IAmACommunityMember)Activator.CreateInstance(authorType);
                foreach(var feed in author.FeedUris)
                {
                    Assert.Equal("https", feed.Scheme);

                    // hit the url to see if it responds!
                    hitFeedTasks.Add(HitFeedAsync(feed));
                }
            }

            await Task.WhenAll(hitFeedTasks).ConfigureAwait(false);
        }

        private async Task HitFeedAsync(Uri feedUrl)
        {
            try
            {
                await _policy.ExecuteAsync(() => _httpClient.GetAsync(feedUrl))
                    .ConfigureAwait(false);
            }
            catch
            {
                _output.WriteLine($"{feedUrl} sucks...");
            }
        }

        [Fact]
        public void All_Authors_Specified_Valid_LanguageCode()
        {
            var assembly = Assembly.GetAssembly(typeof(IAmACommunityMember));
            var cultureNames = CultureInfo.GetCultures(CultureTypes.NeutralCultures).Select(c => c.Name);

            var types = assembly.GetTypes();
            var authorTypes = types.Where(t => typeof(IAmACommunityMember).IsAssignableFrom(t) &&
                !_interfaceNames.Contains(t.Name)).ToArray();

            foreach (var authorType in authorTypes)
            {
                var author = (IAmACommunityMember)Activator.CreateInstance(authorType);

                Assert.Contains(author.FeedLanguageCode, cultureNames);
            }
        }
    }
}