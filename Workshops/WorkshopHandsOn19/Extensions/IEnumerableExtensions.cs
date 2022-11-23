using System;
using System.Collections.Generic;

namespace WorkshopHandsOn19.Extensions
{
    //<summary>
    // Extension methods for IEnumerable instances.
    //</summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Execute a action for each item in the list.
        /// </summary>
        /// <typeparam name="T">Sequence element type.</typeparam>
        /// <param name="source">The list itself.</param>
        /// <param name="action">Action to take on each item</param>
        /// <returns>The list itself.</returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null)
                return null;
            else
                foreach (T item in source)
                    action(item);
             return source;
        }
    }
}