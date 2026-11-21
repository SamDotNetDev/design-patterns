namespace LoggerSingleton;

public sealed class Database
{
    private static readonly Lazy<Database> _instance = new Lazy<Database>(() => new Database());

    private readonly Logger _logger = Logger.Instance;
    private bool _isConnected;

    private Database()
    {
        _logger.Info("Database", "Ma'lumotlar bazasi pooli yaratildi");
    }

    public static Database Instance => _instance.Value;

    public void Connect()
    {
        _isConnected = true;
        _logger.Info("Database", "PostgreSQL serveriga ulandi");
    }

    public void Query(string sql)
    {
        if (!_isConnected)
        {
            _logger.Error("Database", $"So'rov bajarilmadi, baza ulanmagan: {sql}");
            return;
        }
        _logger.Debug("Database", $"SQL bajarildi: {sql}");
    }

    public void Disconnect()
    {
        _isConnected = false;
        _logger.Info("Database", "Baza ulanishi uzildi");
    }
}
