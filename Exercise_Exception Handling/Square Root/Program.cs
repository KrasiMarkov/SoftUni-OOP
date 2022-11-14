using System;

namespace Square_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());

                double result = Math.Sqrt(n);

                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
            //finally
            //{
            //    Console.WriteLine("Krasi");
            //}

        }
    }
}
