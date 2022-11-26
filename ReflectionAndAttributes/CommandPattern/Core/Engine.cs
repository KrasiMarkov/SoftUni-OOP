using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CommandPattern.Core
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                string inputData = Console.ReadLine();

                string result = this.commandInterpreter.Read(inputData);

                Console.WriteLine(result);

            }

        }
    }
}
