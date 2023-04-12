using System;
using System.Linq;
using System.Collections.Generic;
namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Lake stones = new Lake(numbers);

            Console.WriteLine(string.Join(", ", stones));

        }
    }
}
