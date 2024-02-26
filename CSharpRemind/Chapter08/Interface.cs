using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRemind.Chapter08
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class COnsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;
        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.Write("{0} {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void Start()
        {
            while (true)
            {
                Console.Write("온도를 입력해주세요: ");
                string temperature = Console.ReadLine();
                if (temperature == "") break;
                logger.WriteLog(" 현재 온도 : " + temperature);
            }
        }
    }
    internal class Interface
    {
        static void MainInterface()
        {
            ClimateMonitor monitor = new ClimateMonitor(
                new FileLogger("MyLog.txt"));
            monitor.Start();
        }
    }
}
