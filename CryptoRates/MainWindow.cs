using CryptoClients.Net;
using CryptoRates.Exchanges;
using CryptoRates.Settings;
using System.ComponentModel.DataAnnotations;


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
        private System.Timers.Timer _timer;

        public MainWindow()
        {
            InitializeComponent();
            cbPairs.SelectedIndex = 0;
            _timer = new System.Timers.Timer();
            _timer.Interval = 5000;
            _timer.Elapsed += timer_Elapsed;
            LoadSymbolsFromFile();
            GetData();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
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
            var symbol = cbPairs.SelectedItem!.ToString();
            _exchanges.AsParallel().ForAll(async x =>
               {
                   try
                   {
                       var subData = await x.Value.SubscribeTicker(symbol!,
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
            _exchanges.AsParallel().ForAll(x => x.Value.CanPrint = true);
        }

        private void HandleTickerUpdate(string ecxhangeName, decimal rate)
        {
            var rateStr = rate.ToString("0.00");
            tbBinance.Invoke((MethodInvoker)delegate
            {
                switch (ecxhangeName)
                {
                    case "Binance":
                        if (_exchanges["Binance"].CanPrint)
                        {
                            tbBinance.Text = rateStr;
                            _exchanges["Binance"].CanPrint = false;
                        }
                        break;
                    case "Bitget":
                        if (_exchanges["Bitget"].CanPrint)
                        {
                            tbBitget.Text = rateStr;
                            _exchanges["Bitget"].CanPrint = false;
                        }
                        break;
                    case "Bybit":
                        if (_exchanges["Bybit"].CanPrint)
                        {
                            tbBybit.Text = rateStr;
                            _exchanges["Bybit"].CanPrint = false;
                        }
                        break;
                    case "Kucoin":
                        if (_exchanges["Kucoin"].CanPrint)
                        {
                            tbKucoin.Text = rateStr;
                            _exchanges["Kucoin"].CanPrint = false;
                        }
                        break;
                    default:
                        break;
                }
            });
            labelCurrentTime.Invoke((MethodInvoker)delegate
            {
                labelCurrentTime.Text = DateTime.Now.ToString();
            });
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            foreach (var exchange in _exchanges)
            {
                exchange.Value.Unsubscribe();
            }
            this.Close();
        }

    }
}
