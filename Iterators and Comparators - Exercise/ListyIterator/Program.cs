using System;
using System.Linq;
using System.Collections.Generic;
namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {

            ListyIterator<string> iterator = null;

            string commandInput = Console.ReadLine();

            while (commandInput != "END")
            {

                try
                {
                    string[] tokens = commandInput.Split();

                    string command = tokens[0];

                    if (command == "Create")
                    {
                        List<string> elements = tokens.Skip(1).ToList();

                        iterator = new ListyIterator<string>(elements);
                    }

                    else if (command == "HasNext")
                    {
                        Console.WriteLine(iterator.HasNext());
                    }

                    else if (command == "Move")
                    {
                        Console.WriteLine(iterator.Move());
                    }

                    else if (command == "Print")
                    {
                        iterator.Print();
                    }

                    else if (command == "PrintAll")
                    {
                        foreach (var item in iterator)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                    }
                }
                catch (InvalidOperationException e)
                {

                    Console.WriteLine(e.Message);
                }

                commandInput = Console.ReadLine();


            }

           
        }
    }
}
