using Firehose.Web.Extensions;
using Xunit;

namespace UnitTest
{
    public class StringExtensionsTest
    {
        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        [InlineData("Spicy jalapeno bacon ipsum dolor amet drumstick meatball chuck, meatloaf tenderloin alcatra salami filet mignon hamburger. Tongue ham chicken, beef ribs alcatra drumstick meatball doner biltong landjaeger hamburger kielbasa. Chuck leberkas prosciutto sausage flank, boudin filet mignon turkey chicken tail. Pork belly tail bacon buffalo flank pork chop picanha. Sausage ham hock flank, pork burgdoggen.", "Spicy jalapeno bacon ipsum dolor amet drumstick meatball chuck, meatloaf tenderloin alcatra salami filet mignon hamburger. Tongue ham chicken, beef ribs alcatra drumstick meatball doner biltong landjaeger hamburger kielbasa. Chuck leberkas prosciutto sausage flank, boudin filet mignon turkey chicken tail. Pork belly tail bacon buffalo flank pork chop picanha. Sausage ham hock flank, pork burgdoggen.")]
        [InlineData("Spicy jalapeno bacon ipsum <html>dolor</html> amet drumstick meatball chuck, <u>meatloaf</u> tenderloin alcatra salami filet mignon hamburger. Tongue ham chicken, beef ribs alcatra drumstick meatball doner biltong landjaeger hamburger kielbasa. Chuck leberkas prosciutto <div>sausage flank, boudin filet mignon turkey chicken tail. Pork belly tail bacon buffalo flank pork chop picanha. Sausage ham hock flank, pork burgdoggen", "Spicy jalapeno bacon ipsum dolor amet drumstick meatball chuck, meatloaf tenderloin alcatra salami filet mignon hamburger. Tongue ham chicken, beef ribs alcatra drumstick meatball doner biltong landjaeger hamburger kielbasa. Chuck leberkas prosciutto sausage flank, boudin filet mignon turkey chicken tail. Pork belly tail bacon buffalo flank pork chop picanha. Sausage ham hock flank, pork burgdogge")]
        public void SanitizeTest(string toSanitize, string expectedString)
        {
            var sanitized = toSanitize.Sanitize();

            Assert.Equal(expectedString, sanitized);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData(null, null)]
        [InlineData("<p>a<div>b</div><a href=\"http://derp.herp\" target=\"_blank\">c</a></p>","abc")]
        public void StripHtmlTagsTest(string htmlString, string expectedOuput)
        {
            var stripped = htmlString.StripHtmlTags();
            Assert.Equal(expectedOuput, stripped);
        }

        [Theory]
        [InlineData("Hello, world", 5, true, 5)]
        [InlineData("Hello, world", 5, false, 5)]
        [InlineData("Hello. world", 5, true, 6)]
        public void TruncateTest(string toTruncate, int maxLength, bool includeLastSentence, int expectedLength)
        {
            var truncated = toTruncate.Truncate(maxLength, includeLastSentence);
            Assert.True(truncated.Length == expectedLength);
        }
    }
}
