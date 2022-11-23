using System;
using System.Collections.Generic;
using WorkshopHandsOn4.Commands;

namespace WorkshopHandsOn4
{
    public interface ICommandInvoker
    {
        void AddCommand(ICommand command);
        void ExecuteCommands();
    }
}
