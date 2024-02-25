using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter05
{
    internal class InfiniteFor
    {
        static void MainInfiniteFor()
        {
            int i = 0;
            for (; ; )
            {
                Console.WriteLine(i++);
            }

            int j = 0;
            while (true)
                Console.WriteLine(j++);
        }
    }
}
