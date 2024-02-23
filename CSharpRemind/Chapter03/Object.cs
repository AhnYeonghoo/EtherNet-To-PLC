using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter03
{
    internal class Object
    {
        public static void MainObject()
        {
            object a = 123;
            object b = 3.141592534141241124m;
            object c = true;
            object d = "안녕하세요";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
