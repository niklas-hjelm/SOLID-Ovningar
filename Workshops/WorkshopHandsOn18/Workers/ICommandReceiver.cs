using WorkshopHandsOn18.Commands;

namespace WorkshopHandsOn18.Workers
{
    public interface ICommandReceiver : IExecutor
    {
        bool CanExecute(ICommand command);
        void Execute(ICommand command);
    }
}
