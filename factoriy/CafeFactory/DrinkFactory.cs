namespace CafeFactory;

// Ichimlik yaratish mantig'i bitta joyda — Cafe endi aniq klasslarni bilmaydi
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
