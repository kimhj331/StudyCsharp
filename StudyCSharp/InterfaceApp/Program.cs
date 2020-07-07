using System;
using System.IO;

//인터페이스는 어떤 화면에 찍어낼것인지를 결정
//누겟에서 로그포넷(log4net)다운받아서 사용가능
namespace InterfaceApp
{
    interface ILogger
    {
        void WriteLog(string message);
    }
    class ConsoleLogger : ILogger //모니터에 찍힘
    {
        public void WriteLog(string message)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"[{now.ToLocalTime()}], {message}");
        }

    }
    class FileLogger : ILogger //로그 파일에 찍힘
    {
        private StreamWriter writer;
        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }
        public void WriteLog(string message)
        {
            DateTime now = DateTime.Now;
            writer.WriteLine($"[{now.ToLocalTime()}], {message}");
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;
        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }
        public void start()
        {
            while (true)
            {
                Console.Write("온도를 입력해주세요.:");
                string temperature = Console.ReadLine();
                if (temperature == "")break;
                logger.WriteLog("현재온도 : "+temperature); //loger에 해당 message를 넘김
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
            ClimateMonitor monitor = new ClimateMonitor(new ConsoleLogger());
            monitor.start();
        }
    }
}
