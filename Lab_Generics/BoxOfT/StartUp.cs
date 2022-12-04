using System;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> myStack = new Box<int>();

            myStack.Add(10);
            myStack.Add(40);

            int result = myStack.Count;

            myStack.Remove();
            int finalResult = myStack.Count;


            Console.WriteLine(result);
            Console.WriteLine(finalResult);

            Console.WriteLine(myStack.Remove());

        }
    }
}
