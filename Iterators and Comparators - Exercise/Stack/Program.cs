using System;
using System.Linq;
using System.Collections.Generic;
namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> Stackche = new MyStack<string>();

            while (true)
            {
                string[] commands = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commands[0] == "END")
                {
                    foreach (var item in Stackche)
                    {
                        Console.WriteLine(item);
                    }
                    foreach (var item in Stackche)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                }

                else if (commands[0] == "Push")
                {
                    List<string> myList = new List<string>(commands.Skip(1));

                    for (int i = 0; i < myList.Count; i++)
                    {
                        string current = myList[i];

                        Stackche.Push(current);
                    }
                }

                else if (commands[0] == "Pop")
                {
                    Stackche.Pop();
                }
            }
        }
    }
}
