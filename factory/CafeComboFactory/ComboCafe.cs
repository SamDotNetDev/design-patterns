namespace CafeComboFactory;

public class ComboCafe
{
    private readonly ICafeFactory _factory;

    public ComboCafe(ICafeFactory factory)
    {
        _factory = factory;
    }

    public void OrderCombo()
    {
        IDrink drink = _factory.CreateDrink();
        IDessert dessert = _factory.CreateDessert();
        Console.WriteLine($"Kombo tayyorlanmoqda: {drink.Name()} + {dessert.Name()}");
    }
}
