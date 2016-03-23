using System;
using Logger.Interfaces;

namespace Logger
{
    class Logger
    {
        public Logger(IAppender appender)
        {
            this.Appender = appender;
        }

        public IAppender Appender{ get; set; }
        public void Info(string message)
        {
            this.Log(message,ReportLevel.Info);
        }
        public void Warn(string message)
        {
            this.Log(message,ReportLevel.Warn);
        }
        public void Error(string message)
        {
            this.Log(message,ReportLevel.Error);
        }
        public void Critical(string message)
        {
            this.Log(message,ReportLevel.Critical);
        }
        public void Fatal(string message)
        {
            this.Log(message,ReportLevel.Fatal);
        }

        public void Log(string msg, ReportLevel level)
        {
            var date = DateTime.Now;
            this.Appender.Append(msg,level,date);
        }
    }
}
