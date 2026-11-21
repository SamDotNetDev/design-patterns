namespace OrderDecorator;

public class Program
{
    public static void Main()
    {
        IOrder order1 = new BasicOrder("Smartfon", 500);
        Print("1. Oddiy buyurtma:", order1);

        IOrder order2 = new GiftWrapDecorator(order1);
        Print("2. Sovg'a qadoqlash qo'shilgan buyurtma:", order2);

        IOrder order3 = new ExpressDeliveryDecorator(order1);
        Print("3. Tezkor yetkazib berish qo'shilgan buyurtma:", order3);

        IOrder order4 = new ExpressDeliveryDecorator(new GiftWrapDecorator(order1));
        Print("4. Sovg'a qadoqlash va tezkor yetkazib berish qo'shilgan buyurtma:", order4);
    }

    private static void Print(string title, IOrder order)
    {
        Console.WriteLine(title);
        Console.WriteLine($"Tavsif: {order.GetDescription()}");
        Console.WriteLine($"Narx: ${order.GetPrice()}");
        Console.WriteLine();
    }
}
