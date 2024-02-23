using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter03
{
    internal class SignedUnsingedConversion
    {
        static void MainSignedUisngedConversion()
        {
            int a = 500;
            Console.WriteLine(a);

            uint b = (uint)a;
            Console.WriteLine(b);

            int x = -30;

            Console.WriteLine(x);
            uint y = (uint)x;
            Console.WriteLine(y);
        }
    }
}
