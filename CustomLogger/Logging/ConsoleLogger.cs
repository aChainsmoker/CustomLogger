namespace CustomLogger.Logging;

public class ConsoleLogger : ILoggerItem
{
    public void Log( string message)
    {
        Console.WriteLine(message);
    }
}