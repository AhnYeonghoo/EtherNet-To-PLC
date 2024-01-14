using System;

namespace Nullable
{
    class MainApp
    {
        static void MainNullable()
        {
            int? a = null;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);

            a = 3;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);
            return;
        }

    }
}