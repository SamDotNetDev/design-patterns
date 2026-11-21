namespace CafeComboFactory;

public interface IDessert
{
    string Name();
}

public class Cake : IDessert
{
    public string Name()
    {
        return "Tort";
    }
}

public class Cookie : IDessert
{
    public string Name()
    {
        return "Pechenye";
    }
}
