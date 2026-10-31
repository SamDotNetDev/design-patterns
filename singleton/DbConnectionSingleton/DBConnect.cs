namespace DbConnectionSingleton;

public sealed class DBConnect : IConnection
{
    private static readonly Lazy<DBConnect> _instance = new Lazy<DBConnect>(() => new DBConnect());

    private readonly int _session;

    private DBConnect()
    {
        _session = Random.Shared.Next(0, 11);
        Console.WriteLine($"DBConnect yaratildi (session = {_session})");
    }

    public static DBConnect Instance => _instance.Value;

    public int GetSession()
    {
        return _session;
    }
}
