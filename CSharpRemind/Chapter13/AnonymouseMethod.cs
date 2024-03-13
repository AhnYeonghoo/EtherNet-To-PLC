using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter13
{

    delegate int Compare(int a, int b);
    internal class AnonymouseMethod
    {
        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void MainAnonymouseMethod()
        {
            int[] array = { 3, 7, 4, 2, 10 };
            Console.WriteLine("Sorting Ascending...");
            BubbleSort(array, delegate (int a, int b)
            {
                if (a > b)
                    return 1;
                else if (a == b) return 0;
                else return -1;
            });

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"{array[i]}");

            int[] array2 = { 7, 2, 8, 10, 11 };
            Console.WriteLine("\nSorting Descending");
            BubbleSort(array2, delegate (int a, int b)
            {
                if (a < b)
                    return 1;
                else if (a == b) return 0;
                else return -1;
            });

            for (int i = 0; i < array2.Length; i++)
                Console.WriteLine($"{array2[i]}");
            Console.WriteLine();
        }
    }
}
