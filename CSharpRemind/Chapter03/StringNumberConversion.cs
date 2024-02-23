using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter03
{
    internal class StringNumberConversion
    {
        static void MainStringNumberConversion()
        {
            int a = 123;
            string b = a.ToString();
            Console.WriteLine(b);

            float c = 3.14f;
            string d = c.ToString();

            string e = "12345";
            int f = Convert.ToInt32(e);
            Console.WriteLine(f);

            string g = "1.2345";
            float h = float.Parse(g);
            Console.WriteLine(h);


        }
    }
}
