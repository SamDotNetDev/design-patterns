namespace DeveloperTeamFactory;

public interface IProjectManager
{
    void ManageProject();
}

public class BankingPM : IProjectManager
{
    public void ManageProject()
    {
        Console.WriteLine("Banking PM manages Enterprise Banking project");
    }
}

public class SystemPM : IProjectManager
{
    public void ManageProject()
    {
        Console.WriteLine("System PM manages C++ Operating System project");
    }
}
