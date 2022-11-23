using System;
using System.Collections.Generic;
using WorkshopHandsOn11.Commands;

namespace WorkshopHandsOn11
{
    public interface ICommandInvoker
    {
        void AddCommand(ICommand command);
        void ExecuteCommands();
    }
}
