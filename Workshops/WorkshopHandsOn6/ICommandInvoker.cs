using System;
using System.Collections.Generic;
using WorkshopHandsOn6.Commands;

namespace WorkshopHandsOn6
{
    public interface ICommandInvoker
    {
        void AddCommand(ICommand command);
        void ExecuteCommands();
    }
}
