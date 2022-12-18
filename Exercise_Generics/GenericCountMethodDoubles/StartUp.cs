using GenericBoxOfString;
using System;

namespace GenericCountMethodDoubles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            ElementStore<double> elementStore = new ElementStore<double>();

            for (int i = 0; i < n; i++)
            {
                double text = double.Parse(Console.ReadLine());

                Box<double> mybox = new Box<double>(text);

                elementStore.AddToBoxes(mybox);

            }

            double element = double.Parse(Console.ReadLine());

            int result = elementStore.CompareElements(element);

            Console.WriteLine(result);



        }
    }
}
