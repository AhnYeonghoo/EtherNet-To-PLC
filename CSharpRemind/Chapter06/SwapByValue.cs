using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter06
{
    internal class SwapByValue
    {

        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void MainSwapByValue()
        {
            int x = 3;
            int y = 4;
            Console.WriteLine($"x : {x}, y: {y}");

            Swap(x, y);
            Console.WriteLine($"x : {x}, y: {y}");

        }
    }
}
