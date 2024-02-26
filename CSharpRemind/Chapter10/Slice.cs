using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter10
{
    internal class Slice
    {
        static void PrintArray(System.Array array)
        {
            foreach (var e in array)
            {
                Console.Write(e);
            }
            Console.WriteLine();
        }

        static void MainSlice()
        {
            char[] array = new char['Z' - 'A' + 1];
            for (int i = 0; i < array.Length; i++)
                array[i] = (char)('A' + i);

            PrintArray(array[..]);
            PrintArray(array[5..]);

            Range range_5_10 = 5..10;
            PrintArray(array[range_5_10]);

            Index last = ^0;
            Range range_5_last = 5..last;
            PrintArray(array[range_5_last]);
            PrintArray(array[^4..^1]);
        }
    }
}
