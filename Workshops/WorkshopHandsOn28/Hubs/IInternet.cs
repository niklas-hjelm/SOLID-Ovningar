using WorkshopHandsOn28.ValueObjects;

namespace WorkshopHandsOn28.Hubs
{
    public interface IInternet
    {
        IInternet Register(ICountryHub countryHub);
        IInternet UnRegister(ICountryHub countryHub);

        void Broadcast(Message message);
        void Receive(Message message);
        void Send(Message message);
    }
}