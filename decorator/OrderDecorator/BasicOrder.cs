namespace OrderDecorator;

public class BasicOrder : IOrder
{
    private readonly string _description;
    private readonly decimal _price;

    public BasicOrder(string description = "Oddiy buyurtma", decimal price = 100)
    {
        _description = description;
        _price = price;
    }

    public string GetDescription()
    {
        return _description;
    }

    public decimal GetPrice()
    {
        return _price;
    }
}
