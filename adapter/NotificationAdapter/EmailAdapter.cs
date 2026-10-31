namespace NotificationAdapter;

public class EmailAdapter : INotificationService
{
    private readonly EmailClient _client;
    private readonly string _subject;

    public EmailAdapter(EmailClient client, string subject = "Bildirishnoma")
    {
        _client = client;
        _subject = subject;
    }

    public void Send(string recipient, string message)
    {
        _client.SendEmail(recipient, _subject, message);
    }
}
