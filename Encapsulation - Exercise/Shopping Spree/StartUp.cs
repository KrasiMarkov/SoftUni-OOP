using System;
using System.Linq;
using System.Collections.Generic;
namespace ShoppingSpree.Core
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            try
            {
                Engine engine = new Engine();
                engine.Run();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
           

           
        }
    }
}
