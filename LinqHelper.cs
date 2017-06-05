using System;
using System.Collections.Generic;


namespace LinqApp
{
    public static class LinqHelper
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            return new WhereHelperEnumerable<T>(source, predicate);
        }
    }
}
