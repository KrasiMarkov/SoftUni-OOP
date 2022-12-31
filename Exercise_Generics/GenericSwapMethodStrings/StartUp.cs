using System;
using System.Linq;
using System.Collections.Generic;
using GenericBoxOfString;

namespace GenericSwapMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BoxStore<string> finalBoxes = new BoxStore<string>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();

                Box<string> myBox = new Box<string>(word);

                finalBoxes.AddToTotalBoxes(myBox);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int firstIndex = indexes[0];

            int secondIndex = indexes[1];

            finalBoxes.SwapBoxes(firstIndex, secondIndex);

            Console.WriteLine(finalBoxes);
        }
    }
}
