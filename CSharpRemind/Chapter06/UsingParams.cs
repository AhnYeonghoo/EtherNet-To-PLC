using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter06
{
    internal class UsingParams
    {
        static int Sum(params int[] args)
        {
            Console.WriteLine("Summing... ");
            int sum = 0;
            for (int i = 0; i < args.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");
                Console.Write(args[i]);
                sum += args[i];
            }

            Console.WriteLine();
            return sum;
        }

        static void MainUsingParams(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine($"sum: {sum}");
        }
    }
}
