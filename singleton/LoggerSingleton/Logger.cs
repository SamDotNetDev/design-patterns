namespace LoggerSingleton;

public enum LogLevel
{
    Info,
    Warn,
    Error,
    Debug
}

public record LogEntry(string Timestamp, LogLevel Level, string Context, string Message);

public sealed class Logger
{
    private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());

    private readonly List<LogEntry> _logs = new List<LogEntry>();

    private Logger()
    {
    }

    public static Logger Instance => _instance.Value;

    public void Info(string context, string message) => Log(LogLevel.Info, context, message);
    public void Warn(string context, string message) => Log(LogLevel.Warn, context, message);
    public void Error(string context, string message) => Log(LogLevel.Error, context, message);
    public void Debug(string context, string message) => Log(LogLevel.Debug, context, message);

    private void Log(LogLevel level, string context, string message)
    {
        string time = DateTime.Now.ToString("HH:mm:ss");
        _logs.Add(new LogEntry(time, level, context, message));
        Console.WriteLine($"[{time}] [{level.ToString().ToUpper(),-5}] [{context}] {message}");
    }

    public IReadOnlyList<LogEntry> GetLogs()
    {
        return _logs;
    }

    public List<LogEntry> GetLogsByLevel(LogLevel level)
    {
        return _logs.Where(entry => entry.Level == level).ToList();
    }
}
