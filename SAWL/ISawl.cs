using Serilog.Core;

namespace SAWL
{
    public interface ISawl<T> where T : class
    {
        Logger Createlogger();
        void Debug<T>(string message, T propertyValue);
        void Error<T>(string message, T propertyValue);
        void Information<T>(string message, T propertyValue);
        void Warning<T>(string message, T propertyValue);
    }
}