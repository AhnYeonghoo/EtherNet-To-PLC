using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter03
{
    internal class BoxingUnboxing
    {
        static void MainBoxingUnboxing()
        {
            int a = 123;
            object b = (object)a;
            int c = (int)b;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            double x = 3.1414213;
            double y = x;
            double z = (double)y;
            Console.WriteLine(z);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
