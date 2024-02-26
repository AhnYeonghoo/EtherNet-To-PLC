using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter10
{
    internal class InitializingCollection
    {
        static void MainInitializingCollection()
        {
            int[] arr = { 123, 456, 789 };

            ArrayList list = new ArrayList(arr);
            foreach (object item in list)
                Console.WriteLine($"ArrayList: {item}");
            Console.WriteLine();

            Stack stack = new Stack(arr);
            foreach (object item in stack)
            {
                Console.WriteLine($"Stack: {item}");
            }
            Console.WriteLine();

            Queue queue = new Queue(arr);
            foreach (object item in queue)
                Console.WriteLine($"Queue : {item}");
            Console.WriteLine();

            ArrayList list2 = new ArrayList(arr) { 11, 22, 33 };
            foreach (object item in list2)
                Console.WriteLine($"ArrayList2 : {item}");
            Console.WriteLine(0);
        }
    }
}
