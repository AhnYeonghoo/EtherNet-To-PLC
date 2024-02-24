using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter05
{
    internal class Continue
    {
        static void MainContinue()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine("홀수");
            }
        }
    }
}
