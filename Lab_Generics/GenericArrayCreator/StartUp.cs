using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] myArr = ArrayCreator.Create(5, "Pesho");

            int[] intove = ArrayCreator.Create(6, 7);

            Console.WriteLine(string.Join(" ", myArr));

            Console.WriteLine(string.Join(" ", intove));
        }
    }
}
