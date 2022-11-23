using System;
using WorkshopHandsOn18.Commands;

namespace WorkshopHandsOn18.Workers
{
    class People : CommandReceiver, IWorker
    {
        public People(string name)
            : base(o => true)
        {
            Name = name;
        }

        public override void Execute(ICommand command)
        {
            command.Execute(this);
        }
    }
}
