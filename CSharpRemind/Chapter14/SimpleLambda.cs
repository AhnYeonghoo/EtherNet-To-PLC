using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter14
{
    internal class SimpleLambda
    {
        delegate int Calculate(int a, int b);
        static void MainCalculate()
        {
            Calculate calc = (a, b) => a + b;
            Console.WriteLine($"{3} + {4} : {calc(3, 4)}");
        }
    }
}
