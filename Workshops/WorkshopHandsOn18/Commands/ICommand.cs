using WorkshopHandsOn18.Operations;

namespace WorkshopHandsOn18.Commands
{
    public interface ICommand
    {
        ICommandData Operation { get; }
        bool CanExecute();
        void Execute(IExecutor executor);
    }
}