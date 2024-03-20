using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter16
{
    public static class Trace
    {
        public static void WriteLine(string message,
            [CallerFilePath] string file = "",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member = "")
        {
            Console.WriteLine($"{file}(Line:{line}) {member}: {message}");
        }
    }
    internal class CallerInfo
    {
        static void MainCallerInfo()
        {
            Trace.WriteLine("즐거운 프로그래밍");
        }
    }
}
