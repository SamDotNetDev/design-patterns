namespace CafeFactory;

public class DrinkFactory
{
    public IDrink Create(string drinkType)
    {
        return drinkType switch
        {
            "latte" => new Latte(),
            "tea" => new Tea(),
            _ => throw new ArgumentException($"{drinkType} bunday tur yo'q")
        };
    }
}
