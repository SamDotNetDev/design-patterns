namespace BridgeGames;

public class FootballGame : Game
{
    public FootballGame(IDeveloper developer) : base(developer) { }

    public override void Create()
    {
        Console.WriteLine("Futbol o'yini (FootballGame) yaratilmoqda...");
        Developer.WriteCode("FootballGame");
    }
}
