using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Interfaces;

namespace Logger.Appenders
{
    class FileAppender:Appender
    {
        public FileAppender(string path,IFormatter formatter):base(formatter)
        {
            this.Path = path;
        }

        public string Path { get; set; }

        private StreamWriter Writer { get; set; }
        public override void Append(string message, ReportLevel level, DateTime date)
        {
           string output= this.Formatter.Format(message, level, date);
            Writer = new StreamWriter(this.Path,true);
            Writer.WriteLine(output);
        }

        public void Close()
        {
            this.Writer.Close();
        }
    }
}
