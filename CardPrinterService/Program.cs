using CardPrinterService;
using Hardware;
using MessageHandler;
using Microsoft.Extensions.Hosting.WindowsServices;
using NetworkAdapter;
using Utility;

var builder = Host.CreateApplicationBuilder(args);
if (!builder.Environment.IsDevelopment())
{
    builder.Services.AddSingleton<IHostLifetime, WindowsServiceLifetime>();
}
builder.Services.AddHostedService<Worker>();
builder.Services.AddHardwareServices();
builder.Services.AddNetworkAdapterServices();
builder.Services.AddImageSertvices();
builder.Services.AddMessageHandlerServices();
var host = builder.Build();
host.Run();
