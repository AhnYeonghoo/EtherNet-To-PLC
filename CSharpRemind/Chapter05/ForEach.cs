using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter05
{
    internal class ForEach
    {
        static void MainForEach()
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4 };
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}
