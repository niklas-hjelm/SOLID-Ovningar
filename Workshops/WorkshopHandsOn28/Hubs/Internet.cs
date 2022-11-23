using System;
using System.Collections.Generic;
using WorkshopHandsOn28.ValueObjects;

namespace WorkshopHandsOn28.Hubs
{
    public class Internet : IInternet
    {
        private IDictionary<string, ICountryHub> _hubs = new Dictionary<string, ICountryHub>();

        public static IInternet Create() => new Internet();

        public IInternet Register(ICountryHub countryHub)
        {
            if (!_hubs.ContainsKey(countryHub.NetworkId))
                _hubs.Add(countryHub.NetworkId, countryHub);
            return this;
        }

        public IInternet UnRegister(ICountryHub countryHub)
        {
            if (_hubs.ContainsKey(countryHub.NetworkId))
                _hubs.Remove(countryHub.NetworkId);
            return this;
        }

        public void Send(Message message)
        {
            if (_hubs.ContainsKey(message.RecipientNetworkId.CountryNetworkId))
            {
                _hubs[message.RecipientNetworkId.CountryNetworkId].Send(message);
            }
            else
            {
                Console.WriteLine($"Country({message.RecipientNetworkId.CountryNetworkId}) has no Internet!.");
            }
        }

        public void Receive(Message message)
        {
            if (_hubs.ContainsKey(message.RecipientNetworkId.CountryNetworkId))
            {
                _hubs[message.RecipientNetworkId.CountryNetworkId].Receive(message);
            }
            else
            {
                Console.WriteLine($"Country({message.RecipientNetworkId.CountryNetworkId}) has no Internet!.");
            }
        }

        public void Broadcast(Message message)
        {
            foreach (ICountryHub p in _hubs.Values)
            {
                p.Broadcast(message);
            }
        }
    }
}
