namespace CafeComboFactory;

public interface ICafeFactory
{
    IDrink CreateDrink();
    IDessert CreateDessert();
}

public class CoffeeComboFactory : ICafeFactory
{
    public IDrink CreateDrink()
    {
        return new Latte();
    }

    public IDessert CreateDessert()
    {
        return new Cake();
    }
}

public class TeaComboFactory : ICafeFactory
{
    public IDrink CreateDrink()
    {
        return new Tea();
    }

    public IDessert CreateDessert()
    {
        return new Cookie();
    }
}
