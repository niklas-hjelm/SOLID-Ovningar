using WorkshopHandsOn18.Operations;

namespace WorkshopHandsOn18.Commands
{
    public abstract class Command : ICommand
    {
        public ICommandData Operation { get; }

        public Command(ICommandData operation)
        {
            Operation = operation;
        }

        public abstract bool CanExecute();
        public abstract void Execute(IExecutor executor);
     }
}
