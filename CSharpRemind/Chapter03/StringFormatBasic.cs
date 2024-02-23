using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpRemind.Chapter03
{
    internal class StringFormatBasic
    {
        static void MainStringFormatBasic()
        {
            string fmt = "{0,-20}{1,-15}{2,30}";

            WriteLine(fmt, "Publisher", "Auther", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Hanbit", "Sanghyun Park", "this is c#");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");
        }
    }
}
