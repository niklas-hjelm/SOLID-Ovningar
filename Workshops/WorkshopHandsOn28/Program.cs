using System;
using WorkshopHandsOn28.Computers;
using WorkshopHandsOn28.Hubs;
using WorkshopHandsOn28.ValueObjects;

namespace WorkshopHandsOn28
{
    class Program
    {
        static void Main(string[] args)
        {
            IInternet internet = Internet.Create();

            ICountryHub sweden = CountryHub.Create("Sweden", internet);
            ICountryHub norway = CountryHub.Create("Norway", internet);
            ICountryHub denmark = CountryHub.Create("Denmark", internet);

            ILocalHub varberg = LocalHub.Create("Varberg", sweden);
            ILocalHub gothenburg = LocalHub.Create("Göteborg", sweden);
            ILocalHub oslo = LocalHub.Create("Oslo", norway);
            ILocalHub copenhagen = LocalHub.Create("Copenhagen", denmark);

            IComputer varbergPC1 = Computer.Create("VarbergPC1", varberg);
            IComputer varbergPC2 = Computer.Create("VarbergPC2", varberg);
            IComputer gothenburgPC1 = Computer.Create("GöteborgPC1", gothenburg);
            IComputer gothenburgPC2 = Computer.Create("GöteborgPC2", gothenburg);
            IComputer osloPC1 = Computer.Create("OsloPC1", oslo);
            IComputer osloPC2 = Computer.Create("osloPC2", oslo);
            IComputer copenhagenPC1 = Computer.Create("CopenhagenPC1", copenhagen);
            IComputer copenhagenPC2 = Computer.Create("CopenhagenPC2", copenhagen);

            NetworkID sender = NetworkID.Create(sweden.NetworkId, varberg.NetworkId, varbergPC1.NetworkId);
            NetworkID recipient = NetworkID.Create(sweden.NetworkId, varberg.NetworkId, varbergPC2.NetworkId);
            Message message = Message.Create(sender, recipient, "Hello from Varberg's PC1!!!");
            //varbergPC1.Send(message);

            sender = NetworkID.Create(sweden.NetworkId, varberg.NetworkId, varbergPC1.NetworkId);
            //sender = NetworkID.Create(sweden.NetworkId, varberg.NetworkId, varbergPC1.NetworkId, varbergPC1.Name);
            recipient = NetworkID.Create(norway.NetworkId, oslo.NetworkId, osloPC1.NetworkId);
            message = Message.Create(sender, recipient, "Hello from Varberg, Sweden!!!");
            //varbergPC2.Send(message);

            //recipient = NetworkID.Create(sweden.NetworkId, varberg.NetworkId, varbergPC.NetworkId);
            //sender = NetworkID.Create(norway.NetworkId, oslo.NetworkId, osloPC.NetworkId);
            //message = Message.Create(sender, recipient, "Hello from Norway!!!");
            //osloPC.Send(message);

            //internet.Broadcast(Message.Create(NetworkID.Create(string.Empty, string.Empty, string.Empty), "Hello everyone from Internet!!!"));
            //sweden.Broadcast(Message.Create(NetworkID.Create(sweden.NetworkId, sweden.NetworkId, sweden.NetworkId), "Hello everyone from Sweden!!!"));
           // varberg.Broadcast(Message.Create(NetworkID.Create(sweden.NetworkId, varberg.NetworkId, varberg.NetworkId), "Hello everyone from Varberg!!!"));
           // varbergPC1.Broadcast(Message.Create(NetworkID.Create(sweden.NetworkId, varberg.NetworkId, varbergPC1.NetworkId), "Hello everyone from Varberg's PC1!!!"));
          //  varbergPC1.Broadcast(Message.Create(NetworkID.Create(string.Empty, string.Empty, string.Empty), "Hello everyone from Varberg's PC1!!!"));

            //sender = NetworkID.Create(sweden.NetworkId, sweden.NetworkId, sweden.NetworkId);
            //recipient = NetworkID.Create(string.Empty, string.Empty, string.Empty);
            //message = Message.Create(sender, recipient, "Hello from the country Sweden!!!");
            //sweden.Broadcast(message);
            sweden.Send(message);
            //internet.Broadcast(message);

            Console.ReadKey();
        }
    }
}
