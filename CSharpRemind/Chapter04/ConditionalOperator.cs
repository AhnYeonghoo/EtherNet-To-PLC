using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter04
{
    internal class ConditionalOperator
    {
        static void MainConditonalOperator()
        {
            string result = (10 % 2) == 0 ? "짝수" : "홀수";
            Console.WriteLine(result);
        }
    }
}
