using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter06
{
    internal class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static void MainCalculator()
        {
            int result = Plus(3, 4);
            Console.WriteLine(result);

            result = Minus(5, 2);
            Console.WriteLine(result);
        }
    }
}
