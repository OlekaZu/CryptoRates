using CryptoRates.Exchanges;
using CryptoRates.Settings;
using System.Globalization;

namespace CryptoRates
{
    public partial class MainWindow : Form
    {
        private static Dictionary<string, IExchange> _exchanges = new()
        {
            {"Binance", new BinanceExchange()},
            {"Bitget", new BitgetExchange()},
            {"Bybit", new BybitExchange()},
            {"Kucoin", new KucoinExchange()}
        };
        private Dictionary<string, decimal> _bufferRates = new() {
            {"Binance", 0},
            {"Bitget", 0},
            {"Bybit", 0},
            {"Kucoin", 0}
        };
        private System.Timers.Timer _timer;
        private string? _currentSymbol;

        public MainWindow()
        {
            InitializeComponent();
            labelCurrentTime.Text = DateTime.Now.ToString();
            _timer = new System.Timers.Timer();
            _timer.Interval = 5000;
            _timer.Elapsed += timer_Elapsed;
            LoadSymbolsFromFile();
            cbPairs.SelectedIndex = 0;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            UpdateTextBoxes();
            _timer.Start();
        }

        private void LoadSymbolsFromFile()
        {
            var message = ExchangeSymbols.LoadSymbols("Settings/SymbolNames.txt");
            if (message != null)
                MessageBox.Show(message);
        }

        private void GetData()
        {
            _exchanges.AsParallel().ForAll(async x =>
               {
                   try
                   {
                       await x.Value.SubscribeTicker(_currentSymbol!,
                        rate => HandleTickerUpdate(x.Key, rate));
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show(ex.Message);
                   }
               }
            );
        }

        private void timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Timer elapsed");
            labelCurrentTime.Invoke(() => labelCurrentTime.Text = DateTime.Now.ToString());
            UpdateTextBoxes();
        }

        private void UpdateTextBoxes()
        {
            tbBinance.Invoke(() => tbBinance.Text = _bufferRates["Binance"].ToString("N2", CultureInfo.InvariantCulture));
            tbBitget.Invoke(() => tbBitget.Text = _bufferRates["Bitget"].ToString("N2", CultureInfo.InvariantCulture));
            tbBybit.Invoke(() => tbBybit.Text = _bufferRates["Bybit"].ToString("N2", CultureInfo.InvariantCulture));
            tbKucoin.Invoke(() => tbKucoin.Text = _bufferRates["Kucoin"].ToString("N2", CultureInfo.InvariantCulture));
        }

        private void HandleTickerUpdate(string ecxhangeName, decimal rate)
        {
            _bufferRates[ecxhangeName] = rate;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            foreach (var exchange in _exchanges)
            {
                exchange.Value.Unsubscribe();
                exchange.Value.Dispose();
            }
            this.Close();
        }

        private void cbPairs_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentSymbol = cbPairs.SelectedItem!.ToString();
            foreach (var exchange in _exchanges)
            {
                if (exchange.Value.HasSubscriptions())
                    exchange.Value.Unsubscribe();
            }
            GetData();
        }
    }
}
