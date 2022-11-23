using System;
using System.Collections.Generic;
using WorkshopHandsOn32.Extensions;

namespace WorkshopHandsOn32.Containers
{
    public class GenericContainer : IGenericContainer
    {
        private IDictionary<string, object> _values = new Dictionary<string, object>();

         private GenericContainer()
        {}
        public static IGenericContainer Create()
        {
            return new GenericContainer();
        }
  
        /// <summary>
        /// Sets a value.
        /// </summary>
        /// <typeparam name="T">Type of value.</typeparam>
        /// <param name="key">Key for the value.</param>
        /// <param name="value">The value to set.</param>
        /// <returns>Returns myself.</returns>
        /// <remarks>
        /// If the key alredy exist, the item is replaced with the new one.
        /// </remarks>
        public IGenericContainer SetValue<T>(Enum key, T value)
        {
            if (_values.ContainsKey(key.ToString()))
                _values.Remove(key.ToString());

            _values.Add(key.ToString(), value);
            return this;
        }

        /// <summary>
        /// Gets a value.
        /// </summary>
        /// <typeparam name="T">Type of value.</typeparam>
        /// <param name="key">Key for the value.</param>
        /// <returns>The value if found: othervise an default(T).</returns>
        public T GetValue<T>(Enum key)
        {
            KeyValuePair<string, object> item = _values.Find(p => p.Key.Equals(key.ToString()));
            T value = default(T);
            item.IsNotNull().IfTrue(() => { value = item.Value.CastTo<T>(); });
            return value;
        }
    }
}