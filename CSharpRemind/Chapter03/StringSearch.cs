using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter03
{
    internal class StringSearch
    {
        static void MainStringSearch()
        {
            string greeting = "Good Morning";

            Console.WriteLine(greeting);
            Console.WriteLine();

            // IndexOf()
            Console.WriteLine($"IndexOf 'Good' {greeting.IndexOf("Good")}");
            Console.WriteLine($"IndexOf 'o' : {greeting.IndexOf("o")}");

            // LastIndexOf()
            Console.WriteLine($"LastIndexOf 'Good': {greeting.LastIndexOf("Good")}");
            Console.WriteLine($"LastIndexOf 'Morning' : {greeting.LastIndexOf("Morning")}");

            // EndsWith()
            Console.WriteLine($"EndsWith 'Good' : {greeting.EndsWith("Good")}");
            Console.WriteLine($"EndsWith 'Morning' : {greeting.EndsWith("Morning")}");

            // StartsWith()
            Console.WriteLine($"StartsWith 'Good' {greeting.StartsWith("Good")}");
            Console.WriteLine($"StartsWith 'Morning' : {greeting.StartsWith("Morning")}");

            // Contains()
            Console.WriteLine($"Contains 'Evening' : {greeting.Contains("Evening")}");
            Console.WriteLine($"COntains 'Morning': {greeting.Contains("Morning")}");

            // Replace()
            Console.WriteLine($"Replace 'Morning' with 'Evening' : {greeting.Replace("Morning", "Evening")}");


        }
    }
}
