using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter03
{
    internal class FloatConversion
    {
        static void MainFloatConversion()
        {
            float a = 69.6875f;
            Console.WriteLine($"a: {a}");

            double b = (double)a;
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"69.6875 == b : {69.6875==b}");

            float x = 0.1f;
            Console.WriteLine($"x : {x}");

            double y = (double)x;
            Console.WriteLine($"y: {y}");

            Console.WriteLine($"0.1 == y : {0.1 == y}");

        }
    }
}
