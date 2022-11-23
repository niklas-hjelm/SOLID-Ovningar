using System;
using System.Collections.Generic;
using WorkshopHandsOn7.Commands;

namespace WorkshopHandsOn7
{
    public interface ICommandInvoker
    {
        void AddCommand(ICommand command);
        void ExecuteCommands();
    }
}
