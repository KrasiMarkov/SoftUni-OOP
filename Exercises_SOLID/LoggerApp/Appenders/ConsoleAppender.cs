using System;
using System.Collections.Generic;
using System.Text;
using LoggerApp.Layouts;

namespace LoggerApp.Appenders
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; }

        public void Append(string dateTime, string reportLevel, string massage)
        {
            string result = string.Format(this.Layout.Template, dateTime, reportLevel, massage);

            Console.WriteLine(result);
        }
    }
}
