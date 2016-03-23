using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Appenders;
using Logger.Formats;
using Logger.Interfaces;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {  
            IFormatter format = new SimpleLayout();
            IAppender app = new ConsoleAppender(format);
            Logger log = new Logger(app);
            log.Warn("Warning - missing files.");
            
        }
    }

    class myformat : IFormatter
    {

        public string Format(string msg, ReportLevel level, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
