using System;
using System.Collections.Generic;
using WorkshopHandsOn3.Commands;

namespace WorkshopHandsOn3
{
    public interface ICommandInvoker
    {
        void AddCommand(ICommand command);
        void ExecuteCommands();
    }
}
