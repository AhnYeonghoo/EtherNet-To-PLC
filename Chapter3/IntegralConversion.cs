using System;

namespace IntergralConversion
{
    class MainApp
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }
        static void MainIntergralConversion(string[] args)
        {
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 128;
            Console.WriteLine(x);

            sbyte y = (sbyte)x;
            Console.WriteLine(y);

            float floatA = 69.6875f;
            Console.WriteLine($"floatA = {floatA}");

            double doubleA = (double)floatA;
            Console.WriteLine($"doubleA = {doubleA}");
            Console.WriteLine($"{doubleA == 69.6875}");

            float floatX = 0.1f;
            Console.WriteLine($"floatX = {floatX}");

            double doubleY = (double)floatX;
            Console.WriteLine($"doubleY = {doubleY}");
            Console.WriteLine($"{0.1 == doubleY}");

            int intA = 123;
            string stringB = intA.ToString();
            Console.WriteLine(stringB);

            float floatC = 3.14f;
            string stringD = floatC.ToString();
            Console.WriteLine(stringD);

            string stringE = "123456";
            int intF = Convert.ToInt32(stringE);
            Console.WriteLine(intF);

            string stringG = "1.2345";
            float floatH = float.Parse(stringG);
            Console.WriteLine(floatH);

            const int MAX_INT = 2147483647;
            const int MIN_INT = -2147483648;
            Console.WriteLine(MAX_INT);
            Console.WriteLine(MIN_INT);

            Console.WriteLine(DialogResult.YES);
            Console.WriteLine(DialogResult.NO);
            Console.WriteLine(DialogResult.CANCEL);
            Console.WriteLine(DialogResult.CONFIRM);
            Console.WriteLine(DialogResult.OK);

        }
    }
}