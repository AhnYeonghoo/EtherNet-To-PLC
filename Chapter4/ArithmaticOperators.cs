using System;

namespace ArithmaticOperators
{
    class MainApp
    {
        static void MainArithmaticOperators()
        {
            int a = 111 + 222;
            Console.WriteLine($"a: {a}");

            int b = a - 100;
            Console.WriteLine($"b: {b}");

            int c = b * 10;
            Console.WriteLine($"c: {c}");

            double d = c / 6.3;
            Console.WriteLine($"d: {d}");

            Console.WriteLine($"22 / 7 = {22 / 7}({22 % 7})");

            a = 10;
            Console.WriteLine(a++);
            Console.WriteLine(++a);

            Console.WriteLine(a--);
            Console.WriteLine(--a);

            string result = "123" + "456";
            Console.WriteLine(result);

            result = "Hello" + " " + "World!";
            Console.WriteLine(result);

            Console.WriteLine($"3 > 4: {3 > 4}");
            Console.WriteLine($"3 >= 4: {3 >= 4}");
            Console.WriteLine($"3 <= 4: {3 <= 4}");
            Console.WriteLine($"3 == 4: {3 == 4}");
            Console.WriteLine($"3 != 4: {3 != 4}");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Testing && ...");
            Console.WriteLine($"1 > 0 && 4 < 5: {1 > 0 && 4 < 5}");
            Console.WriteLine($"1 > 0 && 4 > 5: {1 > 0 && 4 > 5}");
            Console.WriteLine($"1 == 0 && 4 > 5: {1 == 0 && 4 > 5}");
            Console.WriteLine($"1 == 0 && 4 < 5: {1 == 0 && 4 < 5}");

            Console.WriteLine("\n Testing || ...");
            Console.WriteLine($"1 > 0 || 4 < 5: {1 > 0 || 4 < 5}");
            Console.WriteLine($"1 > 0 || 4 > 5: {1 > 0 || 4 > 5}");
            Console.WriteLine($"1 == 0 || 4 > 5: {1 == 0 || 4 > 5}");
            Console.WriteLine($"1 == 0 || 4 < 5: {1 == 0 || 4 < 5}");

            Console.WriteLine("\nTesting ! ...");
            Console.WriteLine($"!True: {!true}");
            Console.WriteLine($"!False: {!false}");

            result = (10 % 2) == 0 ? "짝수" : "홀수";
            Console.WriteLine(result);
            Console.WriteLine();
            return;
        }
    }
}