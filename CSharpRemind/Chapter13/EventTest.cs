using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter13
{
    delegate void EventHandler(string message);
    class MyNotifier
    {
        public event EventHandler SomethingHappenned;
        public void DoSomething(int number)
        {
            int temp = number % 10;
            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappenned(String.Format("{0} : 짝", number));
            }
        }
    }
    internal class EventTest
    {
        static public void MyHanlder(string message)
        {
            Console.WriteLine(message);
        }

        static void MainEventTest()
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappenned += new EventHandler(MyHanlder);

            for (int i = 1; i <30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
