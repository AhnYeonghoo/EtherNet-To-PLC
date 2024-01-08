using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class ThreadInterrup
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
                    Console.WriteLine("Running thread isn`t gonna be interrupted");
                    Thread.SpinWait(1000000000);

                    while (count > 0)
                    {
                        Console.WriteLine($"{count--} left");
                        Console.WriteLine("Entering into WaitJoinSleep state...");
                        Thread.Sleep(10);
                    }
                    Console.WriteLine("count : 0");
                }
                catch (ThreadInterruptedException e)
                {
                    Console.WriteLine(e);
                }
                finally
                {
                    Console.WriteLine("Clearing resource... ");
                }
            }
        }

        class Counter
        {
            const int LOOP_COUNT = 1000;

            readonly object thisLock;

            private int count;
            public int Count
            {
                get { return count; }
            }

            public Counter()
            {
                thisLock = new object();
                count = 0;
            }

            public void Increase()
            {
                int loopCount = LOOP_COUNT;

                while (loopCount-- > 0)
                {
                    lock (thisLock)
                    {
                        count++;
                    }
                    Thread.Sleep(1);
                }
            }
            public void Decrease()
            {
                int loopCount = LOOP_COUNT;

                while (loopCount-- > 0)
                {
                    lock (thisLock)
                    {
                        count--;
                    }
                    Thread.Sleep(1);
                }
            }
        }

        class MainApp
        {
            static void MainThreadInterrup(string[] args)
            {
                SideTask task = new SideTask(100);
                Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
                t1.IsBackground = false;

                Console.WriteLine("Starting thread... ");
                t1.Start();

                Thread.Sleep(100);

                Console.WriteLine("Interrupting thread..");
                t1.Interrupt();

                Console.WriteLine("Wating until thread stops");
                t1.Join();

                Console.WriteLine("Finished");
            }
        }
    }
}
