namespace DeveloperTeamFactory;

// Factory Method
public interface IDeveloperFactory
{
    IDeveloper CreateDeveloper();
}

public class JavaDeveloperFactory : IDeveloperFactory
{
    public IDeveloper CreateDeveloper()
    {
        return new JavaDeveloper();
    }
}

public class CppDeveloperFactory : IDeveloperFactory
{
    public IDeveloper CreateDeveloper()
    {
        return new CppDeveloper();
    }
}
