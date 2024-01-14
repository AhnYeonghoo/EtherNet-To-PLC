using System;

namespace StringSlice
{
    class MainApp
    {
        static void Main()
        {
            string greeting = "Good Morning";
            Console.WriteLine(greeting.Substring(0, 5));
            Console.WriteLine(greeting.Substring(5));
            Console.WriteLine();

            string[] arr = greeting.Split(
                new string[] { " " }, StringSplitOptions.None);
            Console.WriteLine($"Word Count : {arr.Length}");

            foreach (string element in arr)
            {
                Console.WriteLine($"{element}");
            }
        }
    }
}