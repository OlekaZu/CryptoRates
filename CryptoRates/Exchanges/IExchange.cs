using CryptoClients.Net;
using CryptoExchange.Net.Objects.Sockets;

namespace CryptoRates.Exchanges
{
    public interface IExchange : IDisposable
    {
        protected static ExchangeSocketClient SocketClient = new ExchangeSocketClient(options =>
            {
                options.AutoReconnect = true;
                options.ReconnectInterval = TimeSpan.FromSeconds(5);
            });

        Task<UpdateSubscription> SubscribeTicker(string symbol, Action<decimal> handler);
        void Unsubscribe();
        bool HasSubscriptions();
    }
}