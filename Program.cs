using System;
using System.Collections.Generic;
using System.Linq;

namespace SherlockAndSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            List<int> range = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arr => Convert.ToInt32(arr)).ToList();

            int res = sherlockAndSquares(range[0], range[1]);

            Console.WriteLine(res);
        }

        private static int sherlockAndSquares(int v1, int v2)
        {
            var lBound = Math.Ceiling(Math.Sqrt(v1));
            var uBound = Math.Floor(Math.Sqrt(v2));

            return (int)(uBound-lBound +1);
            //var count = 0;
            //for (int i = v1; i <= v2; i++)
            //{
            //    var sqrt = Math.Sqrt(i);
            //    if ( sqrt == (int)sqrt)
            //        count++;

            //}

            //return count;
        }
    }
}
