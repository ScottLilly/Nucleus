using System;
using System.Collections.Generic;
using System.Linq;

namespace Nucleus.Extensions
{
    public static class LINQExtensions
    {
        public static bool None<T>(this IEnumerable<T> values, Func<T, bool> predicate)
        {
            return !values.Any(predicate);
        }
    }
}