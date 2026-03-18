namespace CustomLogger.Logging;

public interface ILoggerDestination
{
    LogLevel? LoggingLevel { get; set; }
    void Log(string message);
}