using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter03
{
    internal class Decimal
    {
        static void MainDecimal()
        {
            float a = 3.1415_9265_3589_7932_3846_2643_3832_79f;
            double b = 3.1415_9265_3589_7932_3846_2643_3832_79;
            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
