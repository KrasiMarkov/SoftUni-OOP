using System;
using System.Collections.Generic;
using System.Text;
using LoggerApp.Layouts;
using LoggerApp.Loggers;

namespace LoggerApp.Appenders
{
    public class FileAppender : IAppender
    {

        private readonly ILogFile logFile;
        public FileAppender(ILayout layout, ILogFile logFile)
        {
            this.Layout = layout;
            this.logFile = logFile;
        }

        public ILayout Layout { get; }

        public void Append(string dateTime, string reportLevel, string massage)
        {
            string result = string.Format(this.Layout.Template, dateTime, reportLevel, massage);
            this.logFile.Write(result);
        }
    }
}
