using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter03
{
    internal class Overflow
    {
        static void MainOverFlow()
        {
            uint a = uint.MaxValue;

            Console.WriteLine(a);

            a += 1;
            Console.WriteLine(a);
        }
    }
}
