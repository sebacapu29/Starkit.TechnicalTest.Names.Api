using Serilog;

namespace Starkit.Test.Application
{
    public static class Logger
    {
        public static void ConfigureLog()
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .CreateLogger();
        }
        public static void LogInfo(string message)
        {
            Log.Information(message);
        }
        public static void LogWarning(string message)
        {
            Log.Warning(message);
        }
        public static void LogError(string message)
        {
            Log.Error(message);
        }
    }
}
