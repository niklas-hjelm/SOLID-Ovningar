using System;
using System.Collections.Generic;
using WorkshopHandsOn6.Commands;
using WorkshopHandsOn6.ExceptionChain;

namespace WorkshopHandsOn6
{
    public class CommandInvoker : ICommandInvoker
    {
        private Queue<ICommand> _commands;

        public static ICommandInvoker Create()
        {
            return new CommandInvoker();
        }
        private CommandInvoker()
        {
            this._commands = new Queue<ICommand>();
        }
        public void AddCommand(ICommand command)
        {
            this._commands.Enqueue(command);
        }
        public void ExecuteCommands()
        {
            Console.WriteLine("EXECUTING COMMANDS.");
            while (this._commands.Count > 0)
            {
                ICommand command = this._commands.Dequeue();
                command.Execute();
            }
        }
    }
}
