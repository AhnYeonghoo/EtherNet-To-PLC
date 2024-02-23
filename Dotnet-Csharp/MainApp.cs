using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter01
{
    internal class MainApp
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : MainApp.exe <이름>");
                return;
            }

            Console.WriteLine("Hello, {0}", args[0]);
        }
    }
}
