using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter05
{
    internal class DoWhile
    {
        static void MainDoWHile()
            {
            int i = 10;
            do
            {
                Console.WriteLine($"i : {i--}");
            } while (i > 0);

            do
            {
                Console.WriteLine($"i : {i--}");
            }
            while (i > 0);
        }
    }
}
