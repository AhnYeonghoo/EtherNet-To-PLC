using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter04
{
    internal class LogicalOperator
    {
        static void MainLogicalOperator()
        {
            Console.WriteLine("Testing && ...");
            Console.WriteLine(1 > 0 && 4 < 5);
            Console.WriteLine(1 > 0 && 4 > 5);
            Console.WriteLine(1 == 0 && 4 > 5);
            Console.WriteLine(1 == 0 && 4 < 5);
            Console.WriteLine("Testing || ...");

        }
    }
}
