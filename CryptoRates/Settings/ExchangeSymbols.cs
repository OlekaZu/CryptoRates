using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoRates.Settings
{
    public record SymbolName(string Symbol, string Exchange, string ActualName);

    public static class ExchangeSymbols
    {
        private static List<SymbolName> _symbols = new List<SymbolName>();

        public static string? LoadSymbols(string fileName)
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName);
                foreach (var line in lines)
                {
                    string[] parts = line.Split(' ');
                    _symbols.Add(new SymbolName(parts[0], parts[1], parts[2]));
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return null;
        }

        public static string? GetActualSymbolName(string symbol, string exchange)
            => _symbols.FirstOrDefault(x => x.Symbol.Equals(symbol)
            && x.Exchange.Equals(exchange))?.ActualName;
    }
}
