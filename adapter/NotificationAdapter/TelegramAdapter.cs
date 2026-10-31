namespace NotificationAdapter;

public class TelegramAdapter : INotificationService
{
    private readonly TelegramClient _client;

    public TelegramAdapter(TelegramClient client)
    {
        _client = client;
    }

    public void Send(string recipient, string message)
    {
        _client.SendTelegramMessage(recipient, message);
    }
}
