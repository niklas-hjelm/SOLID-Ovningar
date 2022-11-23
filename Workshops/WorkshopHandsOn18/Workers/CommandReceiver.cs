using System;
using WorkshopHandsOn18.Commands;

namespace WorkshopHandsOn18.Workers
{
    public abstract class CommandReceiver : ICommandReceiver
    {
        private Func<ICommand, bool> _canExecute;
        public string Name { get; protected set; }

        public CommandReceiver(Func<ICommand, bool> canExecute)
        {
            _canExecute = canExecute;
        }

        public bool CanExecute(ICommand command)
        {
            return _canExecute(command);
        }

        public abstract void Execute(ICommand command);
    }
}
