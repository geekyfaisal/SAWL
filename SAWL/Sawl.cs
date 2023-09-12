using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;
using Serilog.Events;

namespace SAWL
{
    public class Sawl<T> : ISawl
    {
        private Logger _logger;

        public Sawl()
        {
            _logger = Createlogger();
        }
        public Logger Createlogger()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

            IConfiguration config = builder.Build();

            var logger = new LoggerConfiguration()
                    .MinimumLevel.Information()
                    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                    .MinimumLevel.Override("Microsoft.Hosting.Lifetime", LogEventLevel.Warning)
                    .WriteTo.AzureBlobStorage(
                    config.GetSection("logsettings:SerilogConnection").Value,
                    storageFileName: $"{config.GetSection("logsettings: FileName").Value}{DateTime.Now.Year}{DateTime.Now.Day}.log",
                    storageContainerName: config.GetSection("logsettings:Storagecontainer").Value
                    ).CreateLogger();
            //logger.Information("Testing");
            return logger;
        }

        public void Information<T>(string message, T propertyValue)
        {
            _logger.Information(message, propertyValue);
        }
        public void Error<T>(string message, T propertyValue)
        {
            _logger.Error(message, propertyValue);
        }
        public void Debug<T>(string message, T propertyValue)
        {
            _logger.Debug(message, propertyValue);
        }
        public void Warning<T>(string message, T propertyValue)
        {
            _logger.Warning(message, propertyValue);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Information(string message)
        {
            _logger.Information(message);
        }

        public void Warning(string message)
        {
            _logger.Warning(message);
        }
    }
}