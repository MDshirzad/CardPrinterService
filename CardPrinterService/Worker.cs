using Logging;
using MessageHandler.Contracts;
using NetworkAdapter;

namespace CardPrinterService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly INotifierService notifierService;
        private readonly IMessageParser messageParser;
        public Worker(ILogger<Worker> logger, INotifierService notifierService, IMessageParser messageParser)
        {
            _logger = logger;
            this.notifierService = notifierService;
            this.messageParser = messageParser;
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
            notifierService.OnRecievedMessage += NotifierService_OnRecievedMessage;
        }

        private async Task NotifierService_OnRecievedMessage(string recievedMessage)
        {
            var result = await messageParser.ParseMessage(recievedMessage);
            notifierService.SendMessage(result!.ToString()!);
        }
    }
}
