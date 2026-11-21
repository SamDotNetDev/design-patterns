namespace BankAccountProxy;

public class Program
{
    public static void Main()
    {
        RealBankAccount realAccount = new RealBankAccount("UZB-8888-1234", 1000);
        BankAccountProxy account = new BankAccountProxy(realAccount);

        Console.WriteLine("--- 1-holat: tizimga kirmasdan pul yechish ---");
        account.Withdraw(200);

        Console.WriteLine("--- 2-holat: tizimga kirib pul yechish ---");
        account.Login("Ali Valiyev");
        account.Withdraw(300);

        Console.WriteLine("--- 3-holat: balansdan ko'p summa yechish ---");
        account.Withdraw(1500);

        Console.WriteLine("--- 4-holat: tizimdan chiqib qayta urinish ---");
        account.Logout();
        account.Withdraw(100);

        Console.WriteLine("--- 5-holat: qayta kirib pul yechish ---");
        account.Login("Ali Valiyev");
        account.Withdraw(200);

        Console.WriteLine($"Yakuniy balans: ${account.GetBalance()}");
    }
}
