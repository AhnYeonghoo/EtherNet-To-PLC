using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter10
{
    class MyList2 : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;

        public MyList2()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize(ref array, index + 1);
                    Console.WriteLine($"ARray Resized: {array.Length}");
                }
                array[index] = value;
            }
        }

        public object Current
        {
            get
            {
                return array[position];
            }
        }

        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }
            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
    internal class Enumerable
    {
        static void MainEnumerable()
        {
            MyList2 list = new MyList2();
            for (int i = 0; i < 5; i++)
                list[i] = i;
            foreach (int e in list)
                
                Console.WriteLine(e);
        }
    }
}
