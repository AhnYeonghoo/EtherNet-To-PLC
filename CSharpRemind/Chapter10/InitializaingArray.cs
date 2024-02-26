using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter10
{
    internal class InitializaingArray
    {
        static void MainInitializingArray()
        {
            string[] array1 = new string[3] { "안녕", "Hello", "Halo" };
            Console.WriteLine("array1...");
            foreach (string greeting in array1) Console.WriteLine(greeting);

            string[] array2 = new string[] { "안녕", "Hello", "Halo" };
            Console.WriteLine("\narray2...");
            foreach (string greeting in array2)
                Console.WriteLine(greeting);

            string[] array3 = { "안녕", "Hello", "Halo" };
            Console.WriteLine("\narray3.,..");
            foreach (string greeting in array2)
                Console.WriteLine(greeting);
        }
            
    }
}
