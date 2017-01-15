using System.Configuration;
using System.Web;

namespace Firehose.Web.Infrastructure
{
    public static class GravatarHashingExtensions
    {
        public static string GravatarImage(this string emailAddress)
        {
            var hashedEmailAddress = emailAddress.Trim().ToLowerInvariant().ToMd5Hash().ToLowerInvariant();
            const int size = 200;
            var defaultImage = HttpUtility.UrlEncode(ConfigurationManager.AppSettings["DefaultGravatarImage"]);
            return $"http://www.gravatar.com/avatar/{hashedEmailAddress}.jpg?s={size}&d={defaultImage}";
        }
    }
}