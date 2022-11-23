using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using WorkshopHandsOn32.Vehicles;

namespace WorkshopHandsOn32.Extensions
{
    public static class ObjectExtensions
    {
        public static void ToConsole(this string message, bool newLine = false)
        {
            Console.WriteLine(message + (newLine ? "\n" : string.Empty));
        }

        public static string DoFormat<T1,T2, T3>(this string message, T1 value1, T2 value2, T3 value3)
        {
            return string.Format(message, value1, value2, value3);
        }

        public static Boolean IsNotNull<T>(this T value)
        {
            return value is object;
        }

        public static void IfTrue(this Boolean value, Action action)
        {
            if (value) action();
        }

        public static T Find<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            foreach (var item in source)
                if (predicate(item)) return item;
            return default(T);
        }

        public static Boolean IsAssignableTo(this object obj, Type type)
        {
            var objectType = obj.GetType();
            return type.IsAssignableFrom(objectType);
        }

        public static T CastTo<T>(this object value)
        {
            if (value.IsAssignableTo(typeof(T)))
                return (T)value;
            else
                return default(T);
        }
    }
}