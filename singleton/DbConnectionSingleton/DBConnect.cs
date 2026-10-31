namespace DbConnectionSingleton;

public sealed class DBConnect : IConnection
{
    // Lazy<T> — birinchi murojaatda bir marta yaratiladi, thread-safe
    private static readonly Lazy<DBConnect> _instance = new Lazy<DBConnect>(() => new DBConnect());

    private readonly int _session;

    // Private konstruktor — tashqaridan new DBConnect() qilib bo'lmaydi
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
