using Firehose.Web.Infrastructure;
using System.Linq;
using System.Reflection;
using Xunit;

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
            var authors = types.Where(t => typeof(IAmACommunityMember).IsAssignableFrom(t)).ToArray();

            foreach(var author in authors)
            {
                if (_interfaceNames.Contains(author.Name)) continue;

                Assert.True(author.Namespace == "Firehose.Web.Authors",
                    $"{author.Name} is not in the correct namespace");
            }
        }
    }
}
