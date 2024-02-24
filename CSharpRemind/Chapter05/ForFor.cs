using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter05
{
    internal class ForFor
    {
        static void MaiForFor()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
