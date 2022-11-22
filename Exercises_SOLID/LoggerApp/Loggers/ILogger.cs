using LoggerApp.Appenders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerApp.Loggers
{
    public interface ILogger
    {
        

        void Error(string dateTime, string massage);

        void Info(string dateTime, string massage);
    }
}
