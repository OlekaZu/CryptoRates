using CryptoExchange.Net.Objects.Sockets;
using CryptoRates.Settings;
using System.Xml.Linq;

namespace CryptoRates.Exchanges
{
    public class BybitExchange : IExchange
    {
        private readonly string _name = "Bybit";

        public bool CanPrint { get; set; } = true;


        public async Task<UpdateSubscription> SubscribeTicker(string symbol, Action<decimal> handler)
        {
            var actualSymbol = ExchangeSymbols.GetActualSymbolName(symbol, _name)
              ?? throw new ArgumentException($"{symbol} for {_name} not found");
            var subscription = await IExchange.SocketClient.Bybit.V5SpotApi
                .SubscribeToTickerUpdatesAsync(symbol, (data) => handler(data.Data.LastPrice));
            if (!subscription.Success)
                throw new ArgumentException(subscription.Error?.ToString());
            return subscription.Data;
        }

        public void Unsubscribe()
        {
            IExchange.SocketClient.Bybit.UnsubscribeAllAsync();
            IExchange.SocketClient.Bybit.Dispose();
        }
    }
}
