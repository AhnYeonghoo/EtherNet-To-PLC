using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class HashTable
    {
        public static void Main()
        {
            // 일반 Hash Table
            Hashtable ht = new Hashtable();
            ht.Add("irina", "Irina SP");
            ht.Add("tom", "Tom Cr");

            if (ht.Contains("tom"))
            {
                Console.WriteLine(ht["tom"]);
            }

            // Generic 방식으로 구현한 Hash Table인 Dictionary
            Dictionary<int, string> emp = new Dictionary<int, string>();
            emp.Add(1001, "Jane");
            emp.Add(1002, "Tom");
            emp.Add(1003, "Cindy");

            string name = emp[1002];
            Console.WriteLine(name);

            // 멀티쓰레딩 방식으로 구현된 ConcurrentDictionary
            var dic = new ConcurrentDictionary<int, string>();
            Task t1 = Task.Factory.StartNew(() =>
            {
                int key = 1;
                while (key <= 100)
                {
                    if (dic.TryAdd(key, "D" + key))
                    {
                        key++;
                    }
                    Thread.Sleep(1000);
                }
            });

            Task t2 = Task.Factory.StartNew(() =>
            {
                int key = 1;
                string val;
                while (key <= 100)
                {
                    if (dic.TryGetValue(key, out val))
                    {
                        Console.WriteLine($"{key}, {val}");
                        key++;
                    }
                    Thread.Sleep(100);
                }
            });

            Task.WaitAll(t1, t2);
        }
    }
}
