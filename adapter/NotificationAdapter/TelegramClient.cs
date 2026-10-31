namespace NotificationAdapter;

// Adaptee: o'zgartirib bo'lmaydigan tashqi klass
public class TelegramClient
{
    public void SendTelegramMessage(string chatId, string text)
    {
        Console.WriteLine($"[Telegram] chat {chatId} ga: {text}");
    }
}
