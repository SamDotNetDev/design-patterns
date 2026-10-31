namespace NotificationAdapter;

// Target: tizim kutayotgan umumiy interfeys
public interface INotificationService
{
    void Send(string recipient, string message);
}
