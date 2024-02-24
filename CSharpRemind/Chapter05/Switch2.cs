using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter05
{
    internal class Switch2
    {
        static void MainSwitch2()
        {
            object obj = null;

            string s = Console.ReadLine();
            if (int.TryParse(s, out int out_))
            {
                obj = out_;
            }
            else if (float.TryParse(s, out float out_f))
            {
                obj = out_f;
            }
            else
            {
                obj = s;
            }

            switch (obj)
            {
                case int i:
                    Console.WriteLine($"{i}는 int 형식입니다");
                    break;
                case float f:
                    Console.WriteLine($"{f}는 float 형식입니다");
                    break;
                default:
                    Console.WriteLine($"{obj}는 모르는 형식입니다.");
                    break;
            }
        }
    }
}
