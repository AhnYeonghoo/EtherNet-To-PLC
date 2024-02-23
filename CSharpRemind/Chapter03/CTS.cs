using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter03
{
    internal class CTS
    {
        static void MainCTS()
        {
            System.Int32 a = 123;
            int b = 456;

            Console.WriteLine($"Type: {a.GetType().ToString()}, Value: {a}");
            Console.WriteLine($"Type: {b.GetType().ToString()}, Value: {b}");

            System.String c = "abc";
            string d = "def";
            Console.WriteLine($"Ty[e: {c.GetType().ToString()}, Value:{d}");
            Console.WriteLine($"Type: {d.GetType().ToString()}, Value:{d}");

        }
    }
}
