using System;
using System.IO;

namespace DelegateTest
{
    public class FileLogger
    {
        private readonly string logPath;
        public FileLogger(string path)
        {
            logPath = path;
            Logger.WriteMessage += LogMessage;
        }

        public void DetachLog() => Logger.WriteMessage -= LogMessage;

        private void LogMessage(string msg)
        {
            try
            {
                using (var log = File.AppendText(logPath))
                {
                    log.WriteLine(msg);
                    log.Flush();
                }
            } 
            catch (Exception)
            {

            }
        }
    }
    public enum Severity
    {
        Verbose,
        Trace,
        Information,
        Warning,
        Error,
        Critical
    }

    public static class Logger
    {
        public static Action<string>? WriteMessage;

        public static Severity LogLevel { get; set; } = Severity.Warning;
        public static void LogMessage(Severity s, string component, string msg)
        {
            if (s < LogLevel) return;
            var outputMsg = $"{DateTime.Now}\t{s}\t{component}\t{msg}";
            if (WriteMessage != null)
                WriteMessage(outputMsg);
        }
    }

    public static class LogginMethods
    {
        public static void LogToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class MainClass
    {
        public static void MainDelegate()
        {
            Logger.WriteMessage += LogginMethods.LogToConsole;
            var file = new FileLogger("log.txt");
            var fileOutput = new FileLogger("log.txt");
            Logger.WriteMessage += LogginMethods.LogToConsole;

        }
    }
}