namespace NotificationAdapter;

public class Program
{
    public static void Main()
    {
        NotificationManager sms = new NotificationManager(new SmsNotificationService());
        NotificationManager telegram = new NotificationManager(new TelegramAdapter(new TelegramClient()));
        NotificationManager email = new NotificationManager(new EmailAdapter(new EmailClient()));

        sms.Notify("+998901234567", "Buyurtmangiz qabul qilindi");
        telegram.Notify("123456789", "Buyurtmangiz qabul qilindi");
        email.Notify("user@example.com", "Buyurtmangiz qabul qilindi");
    }
}
