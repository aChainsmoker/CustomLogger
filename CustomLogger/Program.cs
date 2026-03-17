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
    }
}