using MessageHandler.Contracts;

namespace MessageHandler.Handlers.SingleSideKHandle
{
    internal record SingleSideK(string frontImage) : BasePrinterCommand;
}
