using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpRemind.Chapter03
{
    internal class StringFormatNumber
    {
        static void MainStringFormatNumber()
        {
            // D : 10진수
            WriteLine("10진수: {0:D}", 123);
            WriteLine("10진수: {0:D5}", 123);

            // X : 16진수
            WriteLine("16진수: 0x{0:X}", 0xFF1234);
            WriteLine("16진수: 0x{0:X8}", 0xFF1234);

        }
    }
}
