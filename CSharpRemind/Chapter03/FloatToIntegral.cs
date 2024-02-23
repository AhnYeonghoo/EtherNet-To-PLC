using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter03
{
    internal class FloatToIntegral
    {
        static void MainFloatToIntegral()
        {
            float a = 0.9f;
            int b = (int)a;
            Console.WriteLine(b);

            float c = 1.1f;
            int d = (int)c;
            Console.WriteLine(d);
        }
    }
}
