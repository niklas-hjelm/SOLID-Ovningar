namespace WorkshopHandsOn28.ValueObjects
{
    public class NetworkID
    {
        public string CountryNetworkId { get; protected set; }
        public string LocalNetworkId { get; protected set; }
        public string NetworkId { get; protected set; }
        public string Name { get; protected set; }

        public static NetworkID Create(string countryNetworkId, string localNetworkId, string networkId) => new NetworkID(countryNetworkId, localNetworkId, networkId);
        public static NetworkID Create(string countryNetworkId, string localNetworkId, string networkId, string name) => new NetworkID(countryNetworkId, localNetworkId, networkId, name);

        private NetworkID(string countryNetworkId, string localNetworkId, string networkId)
        {
            CountryNetworkId = countryNetworkId;
            LocalNetworkId = localNetworkId;
            NetworkId = networkId;
            Name = string.Empty;
        }
        private NetworkID(string countryNetworkId, string localNetworkId, string networkId, string name)
        {
            CountryNetworkId = countryNetworkId;
            LocalNetworkId = localNetworkId;
            NetworkId = networkId;
            Name = name;
        }
    }
}
