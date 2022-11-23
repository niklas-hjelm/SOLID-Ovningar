using System;
using WorkshopHandsOn27.Computers;
using WorkshopHandsOn27.Hubs;
using WorkshopHandsOn27.ValueObjects;

namespace WorkshopHandsOn27
{
    class Program
    {
        static void Main(string[] args)
        {
            ILocalHub varberg = LocalHub.Create("Varberg");

            IComputer varbergPC1 = Computer.Create("PC1", varberg);
            IComputer varbergPC2 = Computer.Create("PC2", varberg);

            NetworkID sender = NetworkID.Create(varberg.NetworkId, varbergPC1.NetworkId);
            NetworkID recipient = NetworkID.Create(varberg.NetworkId, varbergPC2.NetworkId);
            Message message = Message.Create(sender, recipient, "Hello from PC1!!!");
            varbergPC1.Send(message);
           // varbergPC1.Broadcast(message);

            //sender = NetworkID.Create(varberg.NetworkId, varbergPC2.NetworkId);
            //recipient = NetworkID.Create(varberg.NetworkId, varbergPC1.NetworkId);
            //message = Message.Create(sender, recipient, "Hello from PC2!!!");
            // varbergPC2.Send(message);

            // varberg.Broadcast(Message.Create(NetworkID.Create(varberg.NetworkId, varberg.NetworkId), "Hello everyone from Varberg!!!"));
            // varbergPC1.Broadcast(Message.Create(NetworkID.Create(varberg.NetworkId, varbergPC1.NetworkId), "Hello everyone from Varberg's PC1!!!"));

            //sender = NetworkID.Create(varberg.NetworkId, varbergPC2.NetworkId);
            //recipient = NetworkID.Create(string.Empty, varbergPC1.NetworkId);
            //recipient = NetworkID.Create(string.Empty, string.Empty);
            //message = Message.Create(sender, recipient, "Hello from PC2!!!");
            //varbergPC2.Broadcast(message);
            //varbergPC2.Send(message);

            Console.ReadKey();
        }
    }
}
