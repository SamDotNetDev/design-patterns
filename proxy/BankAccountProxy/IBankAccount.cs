namespace BankAccountProxy;

public interface IBankAccount
{
    void Withdraw(decimal amount);
    decimal GetBalance();
}
