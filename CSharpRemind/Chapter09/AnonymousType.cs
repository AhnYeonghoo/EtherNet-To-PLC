using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter09
{

    internal class AnonymousType
    {
        static void MainAnonymousType()
        {
            var a = new { Name = "박상현", Age = 123 };
            Console.WriteLine($"Name: {a.Name}, Age: {a.Age}");

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };
            Console.Write($"Subject: {b.Subject} Scores: ");
            foreach (var x in b.Scores)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }
    }
}
