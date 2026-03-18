namespace CustomLogger.Logging;

public class Logger : ILogger
{
    private readonly List<ILoggerItem> _loggers;
    private readonly LogFormatter _formatter;

    public Logger()
    {
        _loggers = [new ConsoleLogger()];
        _formatter = new LogFormatter();
    }
    public Logger(List<ILoggerItem> loggers)
    {
        _loggers = loggers;
        _formatter = new LogFormatter();
    }

    public void AddLoggerItem(ILoggerItem item)
    {
        _loggers.Add(item);
    }

    public void RemoveLoggerItem(ILoggerItem item)
    {
        _loggers.Remove(item);
    }
    
    public void Error(string message)
    {
        Log(LogLevel.Error, message);
    }

    public void Error(Exception ex)
    {
        Log(LogLevel.Error, null, ex);
    }

    public void Warning(string message)
    {
        Log(LogLevel.Warning, message);
    }

    public void Info(string message)
    {
        Log(LogLevel.Info, message);
    }

    private void Log(LogLevel level, string? message, Exception? ex = null)
    {
        foreach (var logger in _loggers)
        {
            logger.Log(_formatter.FormatLog(level, message, ex));
        }
    }
}