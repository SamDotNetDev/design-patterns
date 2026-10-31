namespace DbConnectionSingleton;

public class Program
{
    public static void Main()
    {
        DBConnect connection1 = DBConnect.Instance;
        DBConnect connection2 = DBConnect.Instance;
        DBConnect connection3 = DBConnect.Instance;
        DBConnect connection4 = DBConnect.Instance;
        DBConnect connection5 = DBConnect.Instance;

        Console.WriteLine(connection1.GetSession());
        Console.WriteLine(connection2.GetSession());
        Console.WriteLine(connection3.GetSession());
        Console.WriteLine(connection4.GetSession());
        Console.WriteLine(connection5.GetSession());

        bool allSame = ReferenceEquals(connection1, connection2)
                       && ReferenceEquals(connection2, connection3)
                       && ReferenceEquals(connection3, connection4)
                       && ReferenceEquals(connection4, connection5);
        Console.WriteLine($"Hammasi bitta obyektmi: {allSame}");
    }
}
