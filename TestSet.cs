using System;
using System.Collections.Generic;


namespace LinqApp
{
    public class TestSet: IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Accessing an element: {0}", i);
                yield return i;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
