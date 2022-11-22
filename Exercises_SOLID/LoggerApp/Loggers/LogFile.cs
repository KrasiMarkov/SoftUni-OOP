using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LoggerApp.Loggers
{
    public class LogFile : ILogFile
    {
        private const string FilePath = "../../../log.txt";

        private readonly StringBuilder reports;

        public LogFile()
        {
            this.reports = new StringBuilder();
        }

        public string AllText => this.reports.ToString();

        public int Size => this.AllText.Where(char.IsLetter).Sum(c => c);

        public void Write(string error)
        {
            File.AppendAllText(FilePath, error);
            this.reports.Append(error);

        }

        
    }
}
