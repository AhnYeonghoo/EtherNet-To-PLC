using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class Stack
    {
        public static void MainStack(string[] args)
        {
            // 일반 스택
            Stack<double> s = new Stack<double>();
            s.Push(10.5);
            s.Push(3.54);
            s.Push(4.22);
            double val = s.Pop();

            var s2 = new ConcurrentStack<int>();

            // 데이터를 스택에 넣는 쓰레드
            Task tPush = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    s2.Push(i);
                    Thread.Sleep(100);

                }
            });

            // 데이터를 스택에서 읽는 쓰레드
            Task tPop = Task.Factory.StartNew(() =>
            {
                int n = 0;
                int result;
                while (n < 100)
                {
                    if (s2.TryPop(out result))
                    {
                        Console.WriteLine(result);
                        n++;
                    }
                    Thread.Sleep(100);
                }
            });

            Task.WaitAll(tPush, tPop);
        }
    }
}
