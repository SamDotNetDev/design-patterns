namespace NotificationAdapter;

public class SmsNotificationService : INotificationService
{
    public void Send(string recipient, string message)
    {
        Console.WriteLine($"[SMS] {recipient} raqamiga: {message}");
    }
}
