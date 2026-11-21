namespace CafeComboFactory;

public interface IDrink
{
    string Name();
}

public class Latte : IDrink
{
    public string Name()
    {
        return "Latte";
    }
}

public class Tea : IDrink
{
    public string Name()
    {
        return "Choy";
    }
}
