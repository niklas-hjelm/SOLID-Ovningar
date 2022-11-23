using System.Collections.Generic;
using WorkshopHandsOn18.Workers;

namespace WorkshopHandsOn18.Commands
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private IList<ICommandReceiver> _receivers = new List<ICommandReceiver>();

        public void Register(ICommandReceiver receiver)
        {
            _receivers.Add(receiver);
        }

        public void Send(ICommand command)
        {
            foreach (ICommandReceiver receiver in _receivers)
            {
                if (receiver.CanExecute(command))
                    receiver.Execute(command);
            }
        }
    }
}