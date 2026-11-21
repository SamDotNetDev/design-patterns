namespace TravelFacade;

public class Payment
{
    private readonly Dictionary<string, decimal> _payments = new Dictionary<string, decimal>();

    public bool MakePayment(string payerName, decimal amount, string currency = "USD")
    {
        if (amount <= 0)
        {
            Console.WriteLine($"  Xatolik: Noto'g'ri to'lov summasi ({amount})");
            return false;
        }
        _payments[payerName] = amount;
        Console.WriteLine($"  To'lov amalga oshirildi: {amount} {currency}");
        return true;
    }

    public bool RefundPayment(string payerName, string currency = "USD")
    {
        if (_payments.Remove(payerName, out decimal amount))
        {
            Console.WriteLine($"  To'lov qaytarildi: {amount} {currency}");
            return true;
        }
        Console.WriteLine($"  To'lov ma'lumoti topilmadi: {payerName}");
        return false;
    }
}
