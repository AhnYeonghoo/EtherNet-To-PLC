using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter10
{
    internal class ArraySample2
    {
        static void MainArraySample2()
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[^2] = 90;
            scores[^1] = 34;

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            int sum = 0;
            foreach (int score in scores)
                sum += score;

            int average = sum / scores.Length;
            Console.WriteLine(average);
        }
    }
}
