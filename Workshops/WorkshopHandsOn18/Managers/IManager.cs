using WorkshopHandsOn18.Workers;

namespace WorkshopHandsOn18.Managers
{
    interface IManager
    {
        void StartWorking();
        void TakeLunch();
        void Register(IWorker worker);
    }
}
