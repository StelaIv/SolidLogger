using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Interfaces;

namespace Logger.Appenders
{
    public class ConsoleAppender:Appender
    {
        public ConsoleAppender(IFormatter formater):base(formater)
        {
        }
        public override void Append(string message, ReportLevel level, DateTime date)
        {
            string output = this.Formatter.Format(message, level, date);
            date = DateTime.Now;
            Console.WriteLine(output);
        }

    }
}
