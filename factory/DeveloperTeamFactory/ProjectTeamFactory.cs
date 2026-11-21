namespace DeveloperTeamFactory;

// Abstract Factory
public interface IProjectTeamFactory
{
    IDeveloper CreateDeveloper();
    ITester CreateTester();
    IProjectManager CreateProjectManager();
}

public class BankingTeamFactory : IProjectTeamFactory
{
    public IDeveloper CreateDeveloper()
    {
        return new JavaDeveloper();
    }

    public ITester CreateTester()
    {
        return new QATester();
    }

    public IProjectManager CreateProjectManager()
    {
        return new BankingPM();
    }
}

public class SystemTeamFactory : IProjectTeamFactory
{
    public IDeveloper CreateDeveloper()
    {
        return new CppDeveloper();
    }

    public ITester CreateTester()
    {
        return new NativeTester();
    }

    public IProjectManager CreateProjectManager()
    {
        return new SystemPM();
    }
}
