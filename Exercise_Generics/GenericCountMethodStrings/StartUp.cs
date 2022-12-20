using GenericBoxOfString;
using System;
using System.Collections.Generic;
using System.Linq;
namespace GenericCountMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            ElementStore<string> elementStore = new ElementStore<string>();

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                Box<string> mybox = new Box<string>(text);

                elementStore.AddToBoxes(mybox);

            }

            string element = Console.ReadLine();

            int result = elementStore.CompareElements(element);

            Console.WriteLine(result);
        }
    }
}
