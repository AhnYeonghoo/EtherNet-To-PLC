using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter03
{
    internal class SignedUnsigned
    {
        public static void MainSignedUnsigned(string[] args)
        {
            byte a = 255;
            sbyte b = (sbyte)a;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
