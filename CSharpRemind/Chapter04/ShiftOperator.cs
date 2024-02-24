using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter04
{
    internal class ShiftOperator
    {
        static void MainShiftOperator()
        {
            Console.WriteLine("Testing << ..");

            int a = 1;
            Console.WriteLine("a     : {0:D5} (0x{0:X8})", a);
            Console.WriteLine("a << 1   : {0:D5} (0x{0:X8})", a << 1);
            Console.WriteLine("a << 2   : {0:D5} (0x{0:X8})", a << 2);
            Console.WriteLine("a << 5   : {0:D5} (0x{0:X8})", a << 5);

            Console.WriteLine("Testing >> ..");

            int b = 255;
            Console.WriteLine("b     : {0:D5} (0x{0:X8}", b);
            Console.WriteLine("b >> 1   : {0:D5} (0x{0:X8}", b >> 1);
            Console.WriteLine("b >> 2   : {0:D5} (0x{0:X8}", b >> 2);
            Console.WriteLine("b >> 5   : {0:D5} (0x{0:X8}", b >> 5);

            Console.WriteLine("\n Testing >> 2");

            int c = -255;
            
        }
    }
}
