namespace CustomLogger;

public interface ILogFormatter
{
    string FormatLog(LogLevel level, string? message, Exception? ex= null);
}