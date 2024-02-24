using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter04
{
    internal class NullCoalescing
    {
        static void MainNullCoalescing()
        {
            int? num = null;
            Console.WriteLine(num ?? 0);
            num = 99;
            Console.WriteLine(num ?? 0);
            string str = null;
            Console.WriteLine(str ?? "Default");
            str = "Specific";
            Console.WriteLine(str ?? "Default");

        }
    }
}
