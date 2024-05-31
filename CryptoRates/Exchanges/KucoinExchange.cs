using CryptoExchange.Net.Objects.Sockets;
using CryptoRates.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRates.Exchanges
{
    public class KucoinExchange : IExchange
    {
        private readonly string _name = "Kucoin";

        public bool CanPrint { get; set; } = true;

        public async Task<UpdateSubscription> SubscribeTicker(string symbol, Action<decimal> handler)
        {
            var actualSymbol = ExchangeSymbols.GetActualSymbolName(symbol, _name)
                ?? throw new ArgumentException($"{symbol} for {_name} not found");
            var subscription = await IExchange.SocketClient.Kucoin.SpotApi
                .SubscribeToTickerUpdatesAsync(actualSymbol, (data) => handler(data.Data.LastPrice ?? 0));
            if (!subscription.Success)
                throw new ArgumentException(subscription.Error?.ToString());
            return subscription.Data;
        }

        public void Unsubscribe()
        {
            IExchange.SocketClient.Kucoin.UnsubscribeAllAsync();
            IExchange.SocketClient.Kucoin.Dispose();
        }
    }
}
