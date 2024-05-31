using CryptoExchange.Net.Objects.Sockets;
using CryptoRates.Settings;

namespace CryptoRates.Exchanges
{
    public class KucoinExchange : IExchange
    {
        private readonly string _name = "Kucoin";

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

        public void Unsubscribe() => IExchange.SocketClient.Kucoin.UnsubscribeAllAsync();

        public bool HasSubscriptions() => IExchange.SocketClient.Kucoin.CurrentSubscriptions > 0;

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                    IExchange.SocketClient.Kucoin.Dispose();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
