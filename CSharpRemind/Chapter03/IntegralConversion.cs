using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter03
{
    internal class IntegralConversion
    {
        static void MainIntegralConversion()
        {
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 128;
            Console.WriteLine(x);

            sbyte y = (sbyte)x;
            Console.WriteLine(y);
        }
    }
}
