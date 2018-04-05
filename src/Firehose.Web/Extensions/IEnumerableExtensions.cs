using System;
using System.Collections.Generic;

namespace Firehose.Web.Extensions
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<TSource> DistinctBy<TSource>(this IEnumerable<TSource> source, Func<TSource, string> keySelector)
        {
            var seenKeys = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }

        public static IEnumerable<TSource> DistinctByCollection<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TKey>> keySelector)
        {
            var seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                foreach(TKey key in keySelector(element))
                {
                    if (seenKeys.Add(key))
                    {
                        yield return element;
                    }
                }
            }
        }
    }
}