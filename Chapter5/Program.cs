using System;

namespace Chapter5
{
    class Program
    {
        static void MainProgram(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("숫자를 입력하세요: ");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number < 0)
                Console.WriteLine("음수");
            else if (number > 0)
                Console.WriteLine("양수");
            else
                Console.WriteLine("0");

            if (number % 2 == 0)
                Console.WriteLine("짝수");
            else
                Console.WriteLine("홀수");

            Console.WriteLine("다시 입력해주세요: ");
            input = Console.ReadLine();
            number = Int32.Parse(input);

            if (number > 0 )
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("0보다 큰 짝수");
                }
                else
                {
                    Console.WriteLine("0보다 큰 음수");
                }
            }
        
            else
            {
                Console.WriteLine("0보다 작거나 같은 수");
            }

        }
    }
}
