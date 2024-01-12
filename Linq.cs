using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq
{
    public class Linq
    {
        static void MainLinq()
        {
            int[] scores = { 97, 92, 81, 60 };
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;
            foreach (int i in scoreQuery)
                Console.Write(i + " ");

            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };

            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            foreach (int num in numQuery)
                Console.WriteLine("{0,1}", num);
        }
    }
}
