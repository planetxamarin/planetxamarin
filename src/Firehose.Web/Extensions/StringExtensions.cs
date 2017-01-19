using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Firehose.Web.Extensions
{
    public static class StringExtensions
    {
        private static int MaxLength = 400;

        public static string Sanitize(this string htmlContent)
        {
            var strippedContent = string.Empty;

            // Strip out any HTML content.
            strippedContent = Regex.Replace(htmlContent, @"<[^>]*>", String.Empty);

            // 
            if (strippedContent.Length > MaxLength)
            {
                var truncatedContent = strippedContent.Substring(0, MaxLength);

                if (strippedContent.IndexOf('.', MaxLength) > -1)
                {
                    truncatedContent += strippedContent.Substring(MaxLength, strippedContent.IndexOf('.', MaxLength) - MaxLength + 1);
                }

                return truncatedContent;
            }

            return strippedContent;
        }
    }
}