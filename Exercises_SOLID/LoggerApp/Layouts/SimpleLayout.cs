using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerApp.Layouts
{
    public class SimpleLayout : ILayout
    {
        private const string DefaultTemplate = "{0} - {1} - {2}";

        public string Template => DefaultTemplate;


    }
}
