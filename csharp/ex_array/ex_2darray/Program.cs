using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.ex_array
{
    internal class Program
    {
        static void Mainsss(string[] args)
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine($"[{i}, {j}] : {arr[i,j]}");
                }
                Console.WriteLine() ;
            }
            int[,,] arr_3 = new int[,,]
            {
                {{ 1, 2 }, { 3, 4 }, { 5,6} }, {{1,4},{2,5},{ 3,6} },{{6,5 } ,{4,3},{2,1} },{{ 6,3},{5,2},{ 4,1} }
            };



        }
    }
}
