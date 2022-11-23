using System;
using System.Collections.Generic;
using WorkshopHandsOn8.Commands;

namespace WorkshopHandsOn8
{
    public interface ICommandInvoker
    {
        void AddCommand(ICommand command);
        void ExecuteCommands();
    }
}
