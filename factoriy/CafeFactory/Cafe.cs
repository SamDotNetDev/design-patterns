namespace CafeFactory;

// Oldin: Cafe ichida if/else bilan new Latte() / new Tea() qilinardi.
// Endi: Cafe faqat DrinkFactory va IDrink bilan ishlaydi.
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
