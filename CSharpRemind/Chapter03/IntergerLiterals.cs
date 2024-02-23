using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter03
{
    internal class IntergerLiterals
    {
        static void MainIntegerLiterals()
        {
            byte a = 240;
            Console.WriteLine($"a={a}");

            byte b = 0b1111_0000;
            Console.WriteLine($"b={b}");

            byte c = 0XF0;
            Console.WriteLine($"c={c} ");

            uint d = 0x1234_abcd;
            Console.WriteLine($"d={d}");

        }
    }
}
