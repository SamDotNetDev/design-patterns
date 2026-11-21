namespace BankAccountProxy;

public class BankAccountProxy : IBankAccount
{
    private readonly RealBankAccount _realAccount;
    private string? _currentUser;

    public BankAccountProxy(RealBankAccount realAccount)
    {
        _realAccount = realAccount;
    }

    public bool IsAuthenticated => _currentUser != null;

    public void Login(string username)
    {
        _currentUser = username;
        Console.WriteLine($"[TIZIMGA KIRILDI] \"{username}\" tizimga kirdi.");
    }

    public void Logout()
    {
        Console.WriteLine($"[TIZIMDAN CHIQILDI] \"{_currentUser}\" tizimdan chiqdi.");
        _currentUser = null;
    }

    public void Withdraw(decimal amount)
    {
        Console.WriteLine($"--> Pul yechishga urinish: ${amount}");
        if (!IsAuthenticated)
        {
            Console.WriteLine("[TAQIQLANDI] Foydalanuvchi tizimga kirmagan! Avval tizimga kiring.");
            Console.WriteLine();
            return;
        }

        Console.WriteLine("[RUXSAT BERILDI] Foydalanuvchi autentifikatsiyadan o'tgan.");
        _realAccount.Withdraw(amount);
        Console.WriteLine();
    }

    public decimal GetBalance()
    {
        if (!IsAuthenticated)
        {
            Console.WriteLine("[TAQIQLANDI] Balansni ko'rish uchun tizimga kirish kerak.");
            return 0;
        }
        return _realAccount.GetBalance();
    }
}
