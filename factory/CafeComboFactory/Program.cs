namespace CafeComboFactory;

public class Program
{
    public static void Main()
    {
        new ComboCafe(new CoffeeComboFactory()).OrderCombo();
        new ComboCafe(new TeaComboFactory()).OrderCombo();
    }
}
