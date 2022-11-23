using WorkshopHandsOn18.Commands;
using WorkshopHandsOn18.Operations;
using WorkshopHandsOn18.Workers;

namespace WorkshopHandsOn18.Managers
{
    class Manager : IManager
    {
        private ICommandDispatcher _dispatcher;

        public Manager(ICommandDispatcher dispatche)
        {
            _dispatcher = dispatche;
        }

        public void StartWorking()
        {
            _dispatcher.Send(new WorkCommand(new WorkData()));
        }

        public void Register(IWorker worker)
        {
            _dispatcher.Register(worker);
        }

        public void TakeLunch()
        {
            _dispatcher.Send(new TakeLunchCommand(new TakeLunchData()));
        }
    }
}
