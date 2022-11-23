using System;
using System.Collections.Generic;
using WorkshopHandsOn5.Commands;

namespace WorkshopHandsOn5
{
    public interface ICommandInvoker
    {
        void AddCommand(ICommand command);
        void ExecuteCommands();
    }
}
