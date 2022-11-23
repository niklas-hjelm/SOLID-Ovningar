using System;
using WorkshopHandsOn18.Commands;

namespace WorkshopHandsOn18.Workers
{
    class Robot : CommandReceiver, IWorker
    {
        public Robot(string name)
            : base(c => c.GetType().Name == typeof(WorkCommand).Name)
        {
            Name = name;
        }

        public override void Execute(ICommand command)
        {
            command.Execute(this);
        }
    }
}
