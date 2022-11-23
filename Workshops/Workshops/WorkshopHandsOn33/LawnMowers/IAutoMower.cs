namespace WorkshopHandsOn33.LawnMowers
{
    interface IAutoMower : ILawnMower
    {
        void SetHours(int hours);
        void SetStartTime(string time);
        void Start();
        void Stop();
    }
}