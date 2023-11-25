using Serilog.Core;

namespace SAWL
{
    public interface ISawl
    {
        Logger Createlogger();

        void Debug<T>(string message, T propertyValue);

        void Error<T>(string message, T propertyValue);

        void Information<T>(string message, T propertyValue);

        void Warning<T>(string message, T propertyValue);

        void Debug(string message);

        void Error(string message);

        void Information(string message);

        void Warning(string message);
    }
}