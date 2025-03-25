using Serilog;
using System;
using System.IO;

namespace Logging
{
    public static class LogWriter
    {
        private static readonly ILogger TransactionLogger;
        private static readonly ILogger DebugLogger;
        private static readonly ILogger HardwareLogger;

        static LogWriter()
        {
            var basePath = Path.Combine(AppContext.BaseDirectory, "logs");
            var timePath = Path.Combine(basePath, DateTime.Now.ToString("yyyyMMdd_HHmmss"));
            var transactionPath = Path.Combine(timePath, "Transaction");
            var debugPath = Path.Combine(timePath, "Debug");
            var hardwarePath = Path.Combine(timePath, "Hardware");

            Directory.CreateDirectory(transactionPath);
            Directory.CreateDirectory(debugPath);
            Directory.CreateDirectory(hardwarePath);

            TransactionLogger = new LoggerConfiguration()
                .WriteTo.File(Path.Combine(transactionPath, "TransactionLogs.log"), rollingInterval: RollingInterval.Hour)
                .CreateLogger();

            DebugLogger = new LoggerConfiguration()
                .WriteTo.File(Path.Combine(debugPath, "DebugLogs.log"), rollingInterval: RollingInterval.Hour)
                .CreateLogger();

            HardwareLogger = new LoggerConfiguration()
                .WriteTo.File(Path.Combine(hardwarePath, "HardwareLogs.log"), rollingInterval: RollingInterval.Hour)
                .CreateLogger();
        }

        public static void WriteTransactionInfo(string message)
        {
            TransactionLogger.Information(message);
        }

        public static void WriteDebugInfo(string message)
        {
            DebugLogger.Information(message);
        }

        public static void WriteHardwareInfo(string message)
        {
            HardwareLogger.Information(message);
        }

        public static void WriteTransactionError(string message)
        {
            TransactionLogger.Error(message);
        }

        public static void WriteDebugError(string message)
        {
            DebugLogger.Error(message);
        }

        public static void WriteHardwareError(string message)
        {
            HardwareLogger.Error(message);
        }

        public static void CloseAndFlush()
        {
            (TransactionLogger as IDisposable)?.Dispose();
            (DebugLogger as IDisposable)?.Dispose();
            (HardwareLogger as IDisposable)?.Dispose();
        }
    }
}

