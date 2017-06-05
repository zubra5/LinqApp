using System;
using System.Collections.Generic;

namespace LinqApp
{
    public class WhereHelperEnumerator<T> : IEnumerator<T>
    {
        private readonly IEnumerator<T> _sourceEnumerator;
        private readonly Func<T, bool> _predicate;

        public WhereHelperEnumerator(IEnumerator<T> sourceEnumerator, Func<T, bool> predicate)
        {
            _sourceEnumerator = sourceEnumerator;
            _predicate = predicate;
        }

        public T Current
        {
            get { return _sourceEnumerator.Current; }
        }

        public void Dispose()
        {
            _sourceEnumerator.Dispose();
        }

        object System.Collections.IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            bool isValid = false;
            while (_sourceEnumerator.MoveNext())
            {
                T current = _sourceEnumerator.Current;
                isValid = _predicate(current);

                if (isValid)
                {
                    break;
                }
            }

            return isValid;
        }

        public void Reset()
        {
            _sourceEnumerator.Reset();
        }
    }

}