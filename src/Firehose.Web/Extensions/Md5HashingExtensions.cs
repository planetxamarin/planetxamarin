using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Firehose.Web.Extensions
{
    public static class Md5HashingExtensions
    {
        public static string ToMd5Hash(this string toHash)
        {
            var unhashedBytes = Encoding.UTF8.GetBytes(toHash);
            var hashedBytes = MD5.Create().ComputeHash(unhashedBytes);

            var hashedString = string.Join(string.Empty,
                hashedBytes.Select(b => b.ToString("X2")).ToArray());
            return hashedString;
        }
    }
}