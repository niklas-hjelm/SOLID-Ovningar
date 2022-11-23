using System;

namespace WorkshopHandsOn19.Recipients
{
    public interface IRecipient
    {
        string EMail { get; }
        string Name { get; }
        string Phone { get; }
        void Notify(string message);
    }
}
