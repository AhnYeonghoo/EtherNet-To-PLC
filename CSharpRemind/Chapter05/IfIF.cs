using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter05
{
    internal class IfIF
    {
        static void MainIfIf()
        {
            Console.WriteLine("숫자를 입력하세요 : ");
            int number = Int32.Parse(Console.ReadLine());

            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("0보다 큰 짝수");
                }
                else
                {
                    Console.WriteLine("0보다 큰 홀수");
                }
            }
            else
            {
                Console.WriteLine("0보다 작거나 같은 수 ");
            }
        }


    } 
}
