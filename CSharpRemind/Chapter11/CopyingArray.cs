using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter11
{
    internal class CopyingArray
    {
        static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        static void MainCopyingArray()
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];

            CopyArray(source, target);

            foreach (int element in target)
            {
                Console.WriteLine(element);
            }

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯" };
            string[] target2 = new string[source2.Length];
            CopyArray(source2, target2);
            
            foreach (string element in target2)
            {
                Console.WriteLine(element);
            }
        }
    }
}
