using System.Text;

namespace CustomLogger.Logging;

public class FileLogger : ILoggerItem
{
    private readonly string _filePath;

    public FileLogger(string filePath)
    {
        _filePath = filePath;
    }
    public void Log(string message)
    {
        using var fs = new FileStream(_filePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
        var buffer = Encoding.Default.GetBytes(message);
        fs.Write(buffer, 0, buffer.Length);
        fs.WriteByte((byte)'\n');
    }
}