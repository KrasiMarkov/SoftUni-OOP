using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {

        public void Browsing(string url)
        {
            Console.WriteLine($"Browsing: {url}!");
        }

        public void Calling(string number)
        {

            Console.WriteLine($"Calling... {number}");
        }
    }
}
