using Logging;
using NetworkAdapter;

namespace CardPrinterService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly INotifierService notifierService;
        public Worker(ILogger<Worker> logger, INotifierService notifierService)
        {
            _logger = logger;
            this.notifierService = notifierService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            InitializeService();
            LogWriter.WriteDebugInfo("Service Started");
            while (!stoppingToken.IsCancellationRequested)
            {
                
                await Task.Delay(1000, stoppingToken);
            }
            LogWriter.WriteDebugInfo("Service Stopping");
        }

        private void InitializeService()
        {
             notifierService.StartServer();
        }
    }
}
