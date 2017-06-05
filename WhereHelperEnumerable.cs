using System;
using System.Collections.Generic;


namespace LinqApp
{
    public class WhereHelperEnumerable<T> : IEnumerable<T>
    {
        private readonly IEnumerable<T> _source;
        private readonly Func<T, bool> _predicate;

        public WhereHelperEnumerable(IEnumerable<T> source, Func<T, bool> predicate)
        {
            _source = source;
            _predicate = predicate;
        }

        public IEnumerator<T> GetEnumerator()
        {
            IEnumerator<T> sourceEnumerator = _source.GetEnumerator();
            return new WhereHelperEnumerator<T>(sourceEnumerator, _predicate);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
