using System;
using System.Linq;
using System.Collections.Generic;
using GenericBoxОfInteger;

namespace GenericSwapMethodIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BoxStore<int> finalBoxes = new BoxStore<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                Box<int> myBox = new Box<int>(number);

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
