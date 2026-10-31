namespace BridgeGames;

public abstract class Game
{
    protected readonly IDeveloper Developer;

    protected Game(IDeveloper developer)
    {
        Developer = developer;
    }

    public abstract void Create();
}
