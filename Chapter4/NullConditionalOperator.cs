using System;
using System.Collections;

namespace NullConditionalOperator
{
    class MainApp
    {
        static void MainNullConditionalOperator(string[] args)
        {
            ArrayList a = null;
            a?.Add("야구");
            a?.Add("축구");
            Console.WriteLine($"Count: {a?.Count}");
            Console.WriteLine($"{a?[0]}");
            Console.WriteLine($"{a?[1]}");

            a = new ArrayList();
            a?.Add("축구");
            a?.Add("야구");
            Console.WriteLine($"Count: {a?.Count}");
            Console.WriteLine($"{a?[0]}");
            Console.WriteLine($"{a?[1]}");

            // ShiftOperator

            Console.WriteLine("Testing << ...");
            int aa = 1;
            Console.WriteLine("aa      : {0:D5} (0x{0:X8})", aa);
            Console.WriteLine("aa << 1: {0:D5} (0x{0:X8})", aa << 1);
            Console.WriteLine("a << 2: {0:D5} (0x{0:X8})", aa << 2);
            return;

        }
    }
}
