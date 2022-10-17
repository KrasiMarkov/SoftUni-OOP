using System;
using System.Linq;
using System.Collections.Generic;
namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var myCoolStack = new StackOfStrings();

            var result = myCoolStack.IsEmpty();

            Console.WriteLine(result);

            myCoolStack.AddRange(new List<string> { "pesho", "gosho" });

            Console.WriteLine(string.Join(" ", myCoolStack));
        }
    }
}
