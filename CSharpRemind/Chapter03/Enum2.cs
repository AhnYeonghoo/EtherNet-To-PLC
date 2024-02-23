using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter03
{
    internal class Enum2
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK}

        static void MainEnum2()
        {
            DialogResult result = DialogResult.YES;

            Console.WriteLine(result == DialogResult.YES);
            Console.WriteLine(result == DialogResult.NO);
            Console.WriteLine(result == DialogResult.CANCEL);
            Console.WriteLine(result == DialogResult.CONFIRM);
            Console.WriteLine(result == DialogResult.OK);
        }
    }
}
