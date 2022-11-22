using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerApp.Loggers
{
    public interface ILogFile
    {
        string AllText { get; }
        int Size { get; }
        void Write(string error);

    }
}
