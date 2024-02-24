using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter05
{
    internal class Break
    {
        static void MainBreak ()
        {
            while (true)
            {
                Console.Write("계속할까요?(예/아니오): ");
                string answer = Console.ReadLine();

                if (answer == "아니요")
                    break;

            }
        }
            
    }
}
