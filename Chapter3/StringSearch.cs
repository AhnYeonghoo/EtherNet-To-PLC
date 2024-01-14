using static System.Console;

namespace StringSearch
{
    class MainApp
    {
        static void MainStringSearch()
        {
            string greeting = "Good Morning";

            WriteLine(greeting);
            WriteLine();

            // IndexOf()
            WriteLine($"IndexOf 'Good' {greeting.IndexOf("Good")}");
            WriteLine($"IndexOf 'o' {greeting.IndexOf("o")}");

            // LastIndexOf()
            WriteLine($"LastIndexOF 'Good': {greeting.LastIndexOf("good")}");
            WriteLine($"LastIndexOf 'o': {greeting.LastIndexOf("o")}");

            // StartsWith()
            WriteLine($"StartsWith 'Good' : {greeting.StartsWith("Good")}");
            WriteLine($"StartsWitn 'Morning' : {greeting.StartsWith("Morning")}");

            // EndsWith()
            WriteLine($"EndsWith 'Good' : {greeting.EndsWith("good")}");
            WriteLine($"EndsWith 'Morning' : {greeting.EndsWith("Morning")}");

            // Replace()
            WriteLine($"Replaced 'Morning' with 'Evening' : {greeting.Replace("Morning", "Evening")}");

            // ToLower(), ToUpper()
            WriteLine($"ToLower() : {"ABC".ToLower()}");
            WriteLine($"ToUpper(): {"abc".ToUpper()}");

            // Insert(), Remove()
            WriteLine($"Insert() : {"Happy Friday!".Insert(5, " Sunny")}");
            WriteLine($"Remove(): {"I Don`t Love You".Remove(2, 6)}");

            // Trim(), TrimStart(), TrimEnd();
            WriteLine($"Trim(): {" No Spaces ".Trim()}");
            WriteLine($"TrimStart(): {" No Spaces ".TrimStart()}");
            WriteLine($"TrimEnd() : {" No Spaces ".TrimEnd()}");
            return;
        }
    }
}