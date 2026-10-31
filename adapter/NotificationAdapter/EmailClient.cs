namespace NotificationAdapter;

// Adaptee: o'zgartirib bo'lmaydigan tashqi klass
public class EmailClient
{
    public void SendEmail(string emailAddress, string subject, string body)
    {
        Console.WriteLine($"[Email] {emailAddress} ga | Mavzu: {subject} | Matn: {body}");
    }
}
