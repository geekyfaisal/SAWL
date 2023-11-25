using Serilog;
using Serilog.Core;

namespace SAWL
{
    public interface ISLogger
    {
        Logger Createlogger();
        Logger Createlogger(LoggerConfiguration SConfig);
        Logger Createlogger(string filename);
        void Debug(string message);
        void Debug<T>(string message, T propertyValue);
        void Error(string message);
        void Error<T>(string message, T propertyValue);
        void Information(string message);
        void Information<T>(string message, T propertyValue);
        void Warning(string message);
        void Warning<T>(string message, T propertyValue);
    }
}