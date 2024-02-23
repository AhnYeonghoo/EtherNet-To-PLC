using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter03
{
    internal class Constant
    {
        static void MainConstant()
        {
            const int MAX_INT = 2146483647;
            const int MIN_INT = -2146483648;

            Console.WriteLine(MAX_INT);
            Console.WriteLine(MIN_INT);
        }
    }
}
