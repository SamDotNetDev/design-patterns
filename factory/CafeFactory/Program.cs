namespace CafeFactory;

public class Program
{
    public static void Main()
    {
        Cafe cafe = new Cafe(new DrinkFactory());

        Console.WriteLine(cafe.Order("latte"));
        Console.WriteLine(cafe.Order("tea"));

        try
        {
            Console.WriteLine(cafe.Order("juice"));
        }
        catch (ArgumentException e)
        {
            Console.WriteLine("Xato: " + e.Message);
        }
    }
}
