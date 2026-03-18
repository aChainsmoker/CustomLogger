namespace CustomLogger.Logging;

public class ConsoleLogger : ILoggerDestination
{
    public LogLevel? LoggingLevel { get; set; }

    public ConsoleLogger()
    {
        
    }

    public ConsoleLogger(LogLevel level)
    {
        LoggingLevel = level;
    }

    public void Log( string message)
    {
        Console.WriteLine(message);
    }
}