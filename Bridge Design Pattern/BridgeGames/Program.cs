namespace BridgeGames;

public class Program
{
    public static void Main()
    {
        IDeveloper javaDeveloper = new JavaDeveloper();
        IDeveloper cppDeveloper = new CppDeveloper();

        // 4 ta kombinatsiya
        Game[] games =
        {
            new RacingGame(javaDeveloper),
            new RacingGame(cppDeveloper),
            new FootballGame(javaDeveloper),
            new FootballGame(cppDeveloper)
        };

        for (int i = 0; i < games.Length; i++)
        {
            Console.WriteLine($"--- Kombinatsiya {i + 1} ---");
            games[i].Create();
            Console.WriteLine();
        }
    }
}
