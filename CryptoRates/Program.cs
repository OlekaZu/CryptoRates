using Serilog;

namespace CryptoRates
{
    internal static class Program
    {
        private static ILogger logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.Console()
            .CreateLogger();

        [STAThread]
        private static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                ApplicationConfiguration.Initialize();
                Application.Run(new MainWindow(logger));
            }
            catch (Exception ex)
            {
                logger.Fatal(ex.Message);
            }
        }
    }
}