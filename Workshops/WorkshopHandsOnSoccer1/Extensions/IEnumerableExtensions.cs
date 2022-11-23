using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkshopHandsOnSoccer1.Extensions
{
    public static class IEnumerableExtensions
    {
         public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null)
                return Enumerable.Empty<T>();
            else
                foreach (T item in source)
                    action(item);
             return source;
        }
    }
}