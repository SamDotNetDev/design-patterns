namespace OrderDecorator;

public abstract class OrderDecorator : IOrder
{
    protected readonly IOrder Order;

    protected OrderDecorator(IOrder order)
    {
        Order = order;
    }

    public virtual string GetDescription()
    {
        return Order.GetDescription();
    }

    public virtual decimal GetPrice()
    {
        return Order.GetPrice();
    }
}

public class GiftWrapDecorator : OrderDecorator
{
    private readonly decimal _giftWrapPrice;

    public GiftWrapDecorator(IOrder order, decimal giftWrapPrice = 20) : base(order)
    {
        _giftWrapPrice = giftWrapPrice;
    }

    public override string GetDescription()
    {
        return $"{Order.GetDescription()} + Sovg'a qadoqlash";
    }

    public override decimal GetPrice()
    {
        return Order.GetPrice() + _giftWrapPrice;
    }
}

public class ExpressDeliveryDecorator : OrderDecorator
{
    private readonly decimal _deliveryPrice;

    public ExpressDeliveryDecorator(IOrder order, decimal deliveryPrice = 30) : base(order)
    {
        _deliveryPrice = deliveryPrice;
    }

    public override string GetDescription()
    {
        return $"{Order.GetDescription()} + Tezkor yetkazib berish";
    }

    public override decimal GetPrice()
    {
        return Order.GetPrice() + _deliveryPrice;
    }
}
