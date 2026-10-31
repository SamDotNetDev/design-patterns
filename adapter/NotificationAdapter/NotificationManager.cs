namespace NotificationAdapter;

// Faqat INotificationService bilan ishlaydi — Telegram/Email uchun if/else yo'q
public class NotificationManager
{
    private readonly INotificationService _service;

    public NotificationManager(INotificationService service)
    {
        _service = service;
    }

    public void Notify(string recipient, string message)
    {
        _service.Send(recipient, message);
    }
}
