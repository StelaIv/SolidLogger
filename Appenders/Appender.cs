using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Interfaces;

namespace Logger.Appenders
{
     public abstract class Appender:IAppender
    {
        public IFormatter Formatter { get; set; }
        protected Appender(IFormatter formater)
        {
            this.Formatter = formater;
        }

        public abstract void Append(string message, ReportLevel level, DateTime date);

    }
}
