using LoggerApp.Layouts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerApp.Appenders
{
    public interface IAppender
    {

        ILayout Layout { get; }
        void Append(string dateTime, string reportLevel, string massage);

    }
}
