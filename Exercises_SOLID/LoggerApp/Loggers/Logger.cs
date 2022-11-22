using LoggerApp.Appenders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerApp.Loggers
{
    public class Logger : ILogger
    {
        private readonly IAppender appender;

        public Logger(IAppender appender)
        {
            this.appender = appender;
        }

        

        public void Error(string dateTime, string massage)
        {
            this.appender.Append(dateTime, "Error", massage);
        }

        public void Info(string dateTime, string massage)
        {
            this.appender.Append(dateTime, "Info", massage);
        }
    }
}
