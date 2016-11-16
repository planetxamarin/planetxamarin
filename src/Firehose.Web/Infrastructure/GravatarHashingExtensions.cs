using System.Web;

namespace Firehose.Web.Infrastructure
{
    public static class GravatarHashingExtensions
    {
        public static string GravatarImage(this string emailAddress)
        {
            var hashedEmailAddress = emailAddress.Trim().ToLowerInvariant().ToMd5Hash().ToLowerInvariant();
            const int size = 200;
            var defaultImage = HttpUtility.UrlEncode("https://firehose.labs.readify.net/Content/Readify.png");
            return string.Format("http://www.gravatar.com/avatar/{0}.jpg?s={1}&d={2}", hashedEmailAddress, size, defaultImage);
        }
    }
}