using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BasicThread
{

    class SideTask
    {
        int count;

        public SideTask(int count)
        {
            this.count = count;
        }

        public void KeepAlive()
        {
            try
            {
                while (count > 0)
                {
                    Console.WriteLine($"{count--} left");
                    Thread.Sleep(10);
                }
                Console.WriteLine("Count: 0");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine(e);
                Thread.ResetAbort();
            }
            finally
            {
                Console.WriteLine("Clearing resource...");
            }
        }
    }
    class MainApp
    {
        static void DoSomething()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"DoSomethng: {i}");
                Thread.Sleep(10);
            }
        }

        private static void PrintThreadState(ThreadState state)
        {
            Console.WriteLine("{0,-16}: {1}", state, (int)state);
        }

     

        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(DoSomething));

            Console.WriteLine("Starting thread...");
            t1.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main: {i}");
                Thread.Sleep(10);
            }

            Console.WriteLine("Wating until thread stops");
            t1.Join();
            Console.WriteLine("Finished");

            Console.WriteLine("....");

            SideTask task = new SideTask(100);
            Thread t2 = new Thread(new ThreadStart(task.KeepAlive));
            t2.IsBackground = false;

            Console.WriteLine("Starting thread2..");
            t2.Start();
            Thread.Sleep(10);

            Console.WriteLine("Aborting thread...");
            t2.Abort();

            Console.WriteLine("Wating until thread stops");
            t2.Join();

            Console.WriteLine("Finished");

            PrintThreadState(ThreadState.Running);
            PrintThreadState(ThreadState.StopRequested);
            PrintThreadState(ThreadState.Background);
        }
    }
}
