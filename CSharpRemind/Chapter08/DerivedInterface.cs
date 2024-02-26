using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter08
{
    interface ILogger2
    {
        void WriteLog(string message);
    }

    interface IFormattableLogger : ILogger2
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }

        public void WriteLog(string format, params Object[] args)
        {
            string message = String.Format(format, args);
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
    internal class DerivedInterface
    {
        static void MainDerivedInterface()
        {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("THe world is not flat");
            logger.WriteLog("{0} + {1} * {2}", 1, 1, 2);
        }
    }
}
