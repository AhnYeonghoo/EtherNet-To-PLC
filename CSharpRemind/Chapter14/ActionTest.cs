using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter14
{
    internal class ActionTest
    {
        static void MainActionTest()
        {
            Action ac1 = () => Console.WriteLine("Action()");
            ac1();

            int result = 0;
            Action<int> ac2 = (x) => result = x * x;

            ac2(3);
            Console.WriteLine($"Result: {result}");

            Action<double, double> act3 = (x, y) =>
            {
                double pi = x / y;
                Console.WriteLine($"Action<T1, T2>({x}, {y}) : {pi}");
            };

            act3(22.0, 7.0);
        }
    }
}
