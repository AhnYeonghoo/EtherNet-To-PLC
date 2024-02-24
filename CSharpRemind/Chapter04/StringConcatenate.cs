using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter04
{
    internal class StringConcatenate
    {
        static void MainStringConcatenate()
        {
            string result = "123" + "456";
            Console.WriteLine(result);

            result = "Hello" + " " + "WOrld!";
            Console.WriteLine(result);
        }
    }
}
