using System;
using WorkshopHandsOn18.Operations;

namespace WorkshopHandsOn18.Commands
{
    class WorkCommand : Command
    {
        public WorkCommand(ICommandData operation)
            : base(operation)
        {
        }

        public override bool CanExecute()
        {
            return false;
        }

        public override void Execute(IExecutor executor)
        {
            Console.WriteLine($"{executor.Name} is {Operation.Operation}!");
        }
    }
}
