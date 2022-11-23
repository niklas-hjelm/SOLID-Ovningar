using System;
using System.Collections.Generic;
using WorkshopHandsOn11.Commands;
using WorkshopHandsOn11.ExceptionChain;

namespace WorkshopHandsOn11
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
