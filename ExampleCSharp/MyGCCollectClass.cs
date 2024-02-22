using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ExampleCSharp
{
    class MyGCCollectClass
    {
        private const long maxGarbage = 1000;
        static void MainMyGCColectClass()
        {
            MyGCCollectClass myGCCol = new MyGCCollectClass();

            Console.WriteLine("The highest generation is {0}", GC.MaxGeneration);

            myGCCol.MakeSomeGarbage();

            Console.WriteLine($"Generation: {GC.GetGeneration(myGCCol)}");

            Console.WriteLine($"TOtal Memory: {GC.GetTotalMemory(false)}");

            GC.Collect(0);

            Console.WriteLine($"Generation : {GC.GetGeneration(myGCCol)}");

            Console.WriteLine($"Total Memory: {GC.GetTotalMemory(false)}");

            GC.Collect(2);

            Console.WriteLine($"Generation: {GC.GetGeneration(myGCCol)}");
            Console.WriteLine($"Total Memory: {GC.GetTotalMemory(false)}");
            //Console.Read();

            foreach(int num in GetNumber())
            {
                Console.WriteLine(num);
            }

            var list = new MyList();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            IEnumerator it = list.GetEnumerator();
            it.MoveNext();
            Console.WriteLine(it.Current);
            it.MoveNext();
            Console.WriteLine(it.Current);





        }

        static IEnumerable<int> GetNumber()
        {
            yield return 10;
            yield return 20;
            yield return 30;
        }

        void MakeSomeGarbage()
        {
            Version vt;
            for (int i = 0; i < maxGarbage; i++)
            {
                vt = new Version();
            }
        }
    }

    public class MyList
    {
        private int[] data = { 1, 2, 3, 4, 5 };
        public IEnumerator GetEnumerator()
        {
            int i = 0;
            while (i < data.Length)
            {
                yield return data[i];
                i++;
            }
        }
    }
}
