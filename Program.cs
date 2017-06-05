using System;
//using System.Linq;

namespace LinqApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WhereLinq();
        }


        private static void WhereLinq()
        {
            TestSet set = new TestSet();

            var filteredSet = set.Where(s =>s%2==0);//единственный параметр - это лямбда выражение

            foreach (int i in filteredSet)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        /*
        private static void SelectLinq()
        {
            TestSet set = new TestSet();

            var resultSet = set.Where(s => s > 50).Select(s => "*" + s.ToString() + "*");//единственный параметр - это лямбда выражение

            foreach (string i in resultSet)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        private static void SelectOne()
        {
            TestSet set = new TestSet();

            var result = set.Single(s => s % 2 == 0);//единственный параметр - это лямбда выражение

            Console.WriteLine(result);

            Console.ReadLine();
        }

        private static void AggregateLinq()
        {
            TestSet set = new TestSet();

            var result = set.Where(i => i <= 5).Aggregate(1, (acc, i) => acc * i);

            Console.WriteLine(result);

            Console.ReadLine();
        }


        private static void OrderByLinq()
        {
            TestSet set = new TestSet();

            var resultSet = set.Select(i => new { Number = i, IsEven = i % 2 == 0 }).OrderBy(r => r.IsEven);

            foreach (var element in resultSet)
            {
                Console.WriteLine(element.Number);
            }

            Console.ReadLine();
        }


        private static void InternalFunc()
        {
            TestSet set = new TestSet();

            //множеству будет перебрано только один раз
            var resultSet = set.Where(i => i % 2 == 0)
                .Select(i => "*" + i.ToString() + "*")
                .Where(i => i.Length == 4);

            foreach (var i in resultSet)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }*/
    }
}
