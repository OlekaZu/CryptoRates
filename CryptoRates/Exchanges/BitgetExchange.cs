﻿using CryptoExchange.Net.Objects.Sockets;
using CryptoRates.Settings;

namespace CryptoRates.Exchanges
{
    public class BitgetExchange : IExchange
    {
        private readonly string _name = "Bitget";

        public bool CanPrint { get; set; } = true;

        public async Task<UpdateSubscription> SubscribeTicker(string symbol, Action<decimal> handler)
        {
            var actualSymbol = ExchangeSymbols.GetActualSymbolName(symbol, _name)
              ?? throw new ArgumentException($"{symbol} for {_name} not found");
            var subscription = await IExchange.SocketClient.Bitget.SpotApi
             .SubscribeToTickerUpdatesAsync(symbol, (data) => handler(data.Data.LastPrice));
            if (!subscription.Success)
                throw new ArgumentException(subscription.Error?.ToString());
            return subscription.Data;
        }

        public void Unsubscribe()
        {
            IExchange.SocketClient.Bitget.UnsubscribeAllAsync();
            IExchange.SocketClient.Bitget.Dispose();
        }
    }
}
