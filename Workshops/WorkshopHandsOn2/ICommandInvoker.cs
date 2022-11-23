using System;
using System.Collections.Generic;
using WorkshopHandsOn2.Commands;

namespace WorkshopHandsOn2
{
    public interface ICommandInvoker
    {
        void AddCommand(ICommand command);
        void ExecuteCommands();
    }
}
