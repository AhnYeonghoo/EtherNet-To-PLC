using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter04
{
    internal class AssignmentOperator
    {
        static void MainAssignmentOperator()
        {
            int a;
            a = 100;
            Console.WriteLine(a);
            a += 90;
            Console.WriteLine(a);
            a -= 80;
            Console.WriteLine(a);
            a *= 70;
            Console.WriteLine(a);
            a /= 60;
            Console.WriteLine(a);
            a %= 50;
            Console.WriteLine(a);

            a &= 40;
            Console.WriteLine(a);
            a |= 30;
            Console.WriteLine(a);
            a ^= 20;
            Console.WriteLine(a);
            a <<= 10;
            Console.WriteLine(a);
            a >>= 1;
            Console.WriteLine(a);








        }

    }
}
