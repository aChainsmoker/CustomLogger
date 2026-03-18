using CustomLogger.Logging;

namespace CustomLogger;

class Program
{
    static void Main(string[] args)
    {
        var logger = new Logger([new ConsoleLogger(), new FileLogger("..\\..\\..\\log.txt")]);
        logger.Info("Hello World!");
        logger.Warning("Youre about to die");
        logger.Error("Youre dying");
        logger.Error(new Exception("Youre dead"));
        
        var logger2 = new Logger([new ConsoleLogger(LogLevel.Info), new FileLogger("..\\..\\..\\log.txt", LogLevel.Warning)]);
        logger2.Info("Hello World!");
        logger2.Warning("Youre about to die");
        logger2.Error("Youre dying");
        logger2.Error(new Exception("Youre dead"));
    }
}