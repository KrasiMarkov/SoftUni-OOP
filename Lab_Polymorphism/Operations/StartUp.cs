using System;

namespace Operations
{
    public  class StartUp
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            Console.WriteLine(math.Add(4.5, 5.5, 7.6));

            Console.WriteLine(math.Add(6, 7));

            Console.WriteLine(math.Add(4.5m, 2.4m, 7.7m));
        }
    }
}
