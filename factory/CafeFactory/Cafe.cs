namespace CafeFactory;

public class Cafe
{
    private readonly DrinkFactory _drinkFactory;

    public Cafe(DrinkFactory drinkFactory)
    {
        _drinkFactory = drinkFactory;
    }

    public string Order(string drinkType)
    {
        IDrink drink = _drinkFactory.Create(drinkType);
        return drink.Prepare();
    }
}
