using CryptoClients.Net;
using System.Reflection.PortableExecutable;


namespace CryptoRates
{

    public partial class MainWindow : Form
    {
        private ExchangeSocketClient _exchangeSocketClient;
        private System.Timers.Timer _timer;
        private bool _canPrint;

        public MainWindow()
        {
            InitializeComponent();
            cbPairs.SelectedIndex = 0;
            _exchangeSocketClient = new ExchangeSocketClient();
            _timer = new System.Timers.Timer();
            _timer.Interval = 5000;
            _timer.Elapsed += timer_Elapsed;
            _canPrint = true;
            GetData();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            _timer.Start();
        }

        private async void GetData()
        {
            string rate = "";
            string actualTime = "";
            var pair = cbPairs.SelectedItem!.ToString();
            var subscription = await _exchangeSocketClient.Binance.SpotApi.ExchangeData
                .SubscribeToTickerUpdatesAsync(pair!, (data) =>
            {
                rate = data.Data.LastPrice.ToString("0.00");
                actualTime = data.Data.CloseTime.ToString();
                if (_canPrint)
                {
                    PrintData(rate, actualTime);
                    _canPrint = false;
                }
            });
            if (!subscription.Success)
            {
                labelCurrentTime.Invoke((MethodInvoker)delegate
                {
                    labelCurrentTime.Text = $"Failed to sub: {subscription.Error}";
                });
            }
        }

        private void timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Timer elapsed");
            _canPrint = true;
        }

        private void PrintData(string rate, string time)
        {
            tbBinance.Invoke((MethodInvoker)delegate
            {
                tbBinance.Text = rate;
            });
            labelCurrentTime.Invoke((MethodInvoker)delegate
            {
                labelCurrentTime.Text = time;
            });
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
