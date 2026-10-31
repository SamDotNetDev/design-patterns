namespace CafeFactory;

public interface IDrink
{
    string Prepare();
}

public class Latte : IDrink
{
    public string Prepare()
    {
        return "Latte tayyorlanmoqda";
    }
}

public class Tea : IDrink
{
    public string Prepare()
    {
        return "Choy tayyorlanmoqda";
    }
}
