namespace LoggerSingleton;

public class UserService
{
    private readonly Logger _logger = Logger.Instance;
    private readonly Database _db = Database.Instance;

    public void Register(string username)
    {
        _logger.Info("UserService", $"Foydalanuvchi ro'yxatdan o'tkazilmoqda: {username}");
        _db.Query($"INSERT INTO users VALUES ('{username}')");
        _logger.Info("UserService", $"Foydalanuvchi muvaffaqiyatli saqlandi: {username}");
    }

    public void Login(string username, int passwordLength)
    {
        if (passwordLength < 6)
        {
            _logger.Warn("UserService", $"Xavfsiz bo'lmagan parol bilan kirish urinishi: {username}");
            return;
        }
        _logger.Info("UserService", $"Tizimga muvaffaqiyatli kirdi: {username}");
    }
}
