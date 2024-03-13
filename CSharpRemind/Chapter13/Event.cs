using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter13
{
    class MyTimer
    {
        public delegate void Tick(DateTime now);
        public event Tick Ticked;
        private int interval;

        public MyTimer(int interval)
        {
            this.interval = interval;
        }

        public void Start()
        {
            DateTime before = DateTime.Now;
            while (true)
            {
                DateTime current = DateTime.Now;
                if (before.AddSeconds(interval) < current)
                {
                    Ticked(current);
                    before = current;
                }
            }
        }
    }
    internal class Event
    {

        static void TimeEllapsed(DateTime current)
        {
            Console.WriteLine("Time Ellapsed : {0}", current.ToLongTimeString());
        }

        static void MainEvent()
        {
            MyTimer timer = new MyTimer(5);
            timer.Ticked += new MyTimer.Tick(TimeEllapsed);
            timer.Start();
        }
    }
}
