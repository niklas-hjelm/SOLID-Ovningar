using System;
using System.Collections.Generic;
using WorkshopHandsOn10.Commands;

namespace WorkshopHandsOn10
{
    public interface ICommandInvoker
    {
        void AddCommand(ICommand command);
        void ExecuteCommands();
    }
}
