namespace CustomLogger.Logging;

public interface ILoggerDestination
{
    void Log(string message);
}