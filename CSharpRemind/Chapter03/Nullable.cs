using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter03
{
    internal class Nullable
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
        }
    }
}
