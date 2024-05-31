using CryptoClients.Net;
using CryptoExchange.Net.Objects.Sockets;

namespace CryptoRates.Exchanges
{
    public interface IExchange
    {
        protected static ExchangeSocketClient SocketClient = new ExchangeSocketClient();
        bool CanPrint { get; set; }
        Task<UpdateSubscription> SubscribeTicker(string symbol, Action<decimal> handler);
        void Unsubscribe();
    }
}
