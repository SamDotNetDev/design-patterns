namespace LoggerSingleton;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== 1. SINGLETON TEKSHIRUVI ===");
        Logger logger1 = Logger.Instance;
        Logger logger2 = Logger.Instance;
        Console.WriteLine($"logger1 == logger2: {ReferenceEquals(logger1, logger2)}");

        Database db1 = Database.Instance;
        Database db2 = Database.Instance;
        Console.WriteLine($"db1 == db2: {ReferenceEquals(db1, db2)}");
        Console.WriteLine();

        Console.WriteLine("=== 2. ISHLASH JARAYONI VA LOGLAR ===");
        db1.Connect();

        UserService userService = new UserService();
        userService.Register("ali_coder");
        userService.Login("ali_coder", 8);
        userService.Login("hacker", 4);

        db2.Disconnect();
        db2.Query("SELECT * FROM users");
        Console.WriteLine();

        Console.WriteLine("=== 3. YAGONA LOGGERDAGI LOGLAR ===");
        Console.WriteLine($"Jami loglar: {logger2.GetLogs().Count} ta");
        Console.WriteLine($"Xatolar (ERROR): {logger2.GetLogsByLevel(LogLevel.Error).Count} ta");
        Console.WriteLine($"Ogohlantirishlar (WARN): {logger2.GetLogsByLevel(LogLevel.Warn).Count} ta");
    }
}
