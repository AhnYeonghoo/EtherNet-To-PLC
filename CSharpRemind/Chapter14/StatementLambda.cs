using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter14
{
    internal class StatementLambda
    {
        delegate string Concatenate(string[] args);
        static void MainConcatenate(string[] args)
        {
            Concatenate concat =
                (arr) =>
                {
                    string result = "";
                    foreach (string s in arr)
                    {
                        result += s;
                    }
                    return result;
                };
            Console.WriteLine(concat(args));
        }
    }
}
