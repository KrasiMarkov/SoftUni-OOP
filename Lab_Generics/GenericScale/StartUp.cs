using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var myScale = new EqualityScale<int>(5, 5);
            var result = myScale.AreEqual();

            Console.WriteLine(result);
        }
    }
}
