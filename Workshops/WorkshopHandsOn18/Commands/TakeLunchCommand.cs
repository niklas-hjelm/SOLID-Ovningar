using System;
using WorkshopHandsOn18.Operations;

namespace WorkshopHandsOn18.Commands
{
    class TakeLunchCommand : Command
    {
        public TakeLunchCommand(ICommandData operation)
            :base(operation)
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
