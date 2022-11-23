using System;
using System.Collections.Generic;
using WorkshopHandsOn1.Commands;

namespace WorkshopHandsOn1
{
    public interface ICommandInvoker
    {
        void AddCommand(ICommand command);
        void ExecuteCommands();
    }
}
