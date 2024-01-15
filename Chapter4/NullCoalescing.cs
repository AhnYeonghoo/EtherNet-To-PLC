using System;

namespace NullCoalescing
{
    class MainApp
    {
        static void MainNullCoalescing()
        {
            int? num = null;
            Console.WriteLine($"{num ?? 0}");
            num = 99;
            Console.WriteLine($"{num ?? 0}");

            string str = null;
            Console.WriteLine($"{str ?? "Default"}");

            str = "Specific";
            Console.WriteLine($"{str ?? "Default"}");
        }
    }
}