using System;
using System.Linq;
using System.Collections.Generic;
namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split().ToArray();

            string[] url = Console.ReadLine().Split().ToArray();

            foreach (var item in phoneNumbers)
            {
                if (!item.All(char.IsDigit))
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }

                ICallable phone = null;

                if (item.Length == 7)
                {
                    phone = new StationaryPhone();
                    phone.Calling(item);
                }
                else if (item.Length == 10)
                {
                    phone = new Smartphone();
                    phone.Calling(item);
                }


            }

            foreach (var item in url)
            {
                if (item.Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }

                IBrowsable smart = new Smartphone();
                smart.Browsing(item);
                
            }
        }
    }
}
