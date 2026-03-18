namespace CustomLogger.Logging;

public class ConsoleLogger : ILoggerDestination
{
    public void Log( string message)
    {
        Console.WriteLine(message);
    }
}