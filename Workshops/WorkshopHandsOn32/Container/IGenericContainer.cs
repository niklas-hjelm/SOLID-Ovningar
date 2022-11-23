using System;

namespace WorkshopHandsOn32.Containers
{
    /// <summary>
    /// Base Interface for datacontainers.
    /// </summary>
    public interface IGenericContainer 
    {
        /// <summary>
        /// Sets a value.
        /// </summary>
        /// <typeparam name="T">Type of value.</typeparam>
        /// <param name="key">Key for the value.</param>
        /// <param name="value">The value to set.</param>
        /// <returns></returns>
        IGenericContainer SetValue<T>(Enum key, T value);

        /// <summary>
        /// Gets a value.
        /// </summary>
        /// <typeparam name="T">Type of value.</typeparam>
        /// <param name="key">Key for the value.</param>
        /// <returns>The value if found: othervise an default(T).</returns>
        T GetValue<T>(Enum key);
    }
}