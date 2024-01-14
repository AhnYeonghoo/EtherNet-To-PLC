using System;

namespace UsingVar
{
    class MainApp
    {
        static void MainUsingVar()
        {
            var a = 20;
            Console.WriteLine($"Type: {a.GetType()}, Value: {a}");

            var b = 3.1414213;
            Console.WriteLine($"Type: {b.GetType()}, Value: {b}");

            var c = "Hello, World";
            Console.WriteLine($"Type: {c.GetType()}, Value: {c}");

            var d = new int[] { 10, 20, 30 };
            Console.WriteLine($"Type: {d.GetType()}, Value: ");
            foreach (var e in d)
            {
                Console.Write(e);
            }
            return;
        }
    }
}