using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter04
{
    internal class IncDecOperator
    {
        public static void MainIncDecOperator()
        {
            int a = 10;
            Console.WriteLine(a++);
            Console.WriteLine(++a);

            Console.WriteLine(a--);
            Console.WriteLine(--a);
        }
    }
}
