using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;
using CommandPattern.Core.Commands;


namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string commandTikTok = "Command";
        public string Read(string args)
        {
            string[] tokens = args.Split().ToArray();

            string commandName = tokens[0];

            string commandTypeName = commandName + commandTikTok;

            Type commandType = Assembly.GetCallingAssembly()
            .GetTypes()
            .Where(t => t.GetInterfaces().Any(i => i.Name == nameof(ICommand)))
            .FirstOrDefault(t => t.Name == commandTypeName);

            if (commandType == null)
            {
                throw new InvalidOperationException("Command type is invalid!");
            }




            ICommand command = Activator.CreateInstance(commandType) as ICommand;

            //if (commandName == "Hello")
            //{
               
            //    command = new HelloCommand();

            //}

            //else if (commandName == "Exit")
            //{
            //    command = new ExitCommand();

            //}

            string[] cleared = tokens.Skip(1).ToArray();

            string result = command.Execute(cleared);

            return result;
        }
    }
}
