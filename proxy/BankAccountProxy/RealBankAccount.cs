namespace BankAccountProxy;

public class RealBankAccount : IBankAccount
{
    private decimal _balance;

    public RealBankAccount(string accountNumber, decimal initialBalance = 0)
    {
        AccountNumber = accountNumber;
        _balance = initialBalance;
    }

    public string AccountNumber { get; }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine($"[XATOLIK] Noto'g'ri summa: ${amount}. Summa musbat bo'lishi kerak.");
            return;
        }

        if (amount > _balance)
        {
            Console.WriteLine($"[RAD ETILDI] Mablag' yetarli emas! Hisobda: ${_balance}, so'ralgan: ${amount}");
            return;
        }

        _balance -= amount;
        Console.WriteLine($"[MUVAFFAQIYATLI] Hisobdan ${amount} yechildi. Qolgan balans: ${_balance}");
    }

    public decimal GetBalance()
    {
        return _balance;
    }
}
