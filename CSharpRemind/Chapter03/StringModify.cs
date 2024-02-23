using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpRemind.Chapter03
{
    internal class StringModify
    {
        static void MainStringModify()
        {
            WriteLine($"ToLower(): {"ABC".ToLower()}");
            WriteLine($"ToUpper(): {"abc".ToUpper()}");

            WriteLine($"INsert(): {"Happy Friday!".Insert(5, " Sunny")}");
            WriteLine($"Remove() : {"I Don`t Love You".Remove(2, 6)}");

            WriteLine($"Trim(): {" No Spaces ".Trim()}");
            WriteLine($"TrimStart(): {" No Spaces ".TrimStart()}");
            WriteLine($"TrimEnd() : {" No Spaces ".TrimEnd()}");
        }
    }
}
