﻿using System;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                Box<string> myBox = new Box<string>(text);

                Console.WriteLine(myBox);
            }

        }
    }
}
