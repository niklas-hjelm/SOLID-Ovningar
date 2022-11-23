namespace WorkshopHandsOn27.ValueObjects
{
    public class NetworkID
    {
        public string LocalNetworkId { get; protected set; }
        public string NetworkId { get; protected set; }

        public static NetworkID Create(string localNetworkId, string networkId) => new NetworkID(localNetworkId, networkId);

        private NetworkID(string localNetworkId, string networkId)
        {
            LocalNetworkId = localNetworkId;
            NetworkId = networkId;
        }
    }
}
