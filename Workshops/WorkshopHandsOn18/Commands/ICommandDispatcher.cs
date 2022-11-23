using WorkshopHandsOn18.Workers;

namespace WorkshopHandsOn18.Commands
{
    public interface ICommandDispatcher
    {
        void Send(ICommand command);
        void Register(ICommandReceiver receiver);
    }
}
