using System;
using System.Collections.Generic;
using WorkshopHandsOn9.Commands;

namespace WorkshopHandsOn9
{
    public interface ICommandInvoker
    {
        void AddCommand(ICommand command);
        void ExecuteCommands();
    }
}
