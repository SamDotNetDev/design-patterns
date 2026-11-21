namespace DeveloperTeamFactory;

public interface IDeveloper
{
    void WriteCode();
}

public class JavaDeveloper : IDeveloper
{
    public void WriteCode()
    {
        Console.WriteLine("Java Developer writes Java code");
    }
}

public class CppDeveloper : IDeveloper
{
    public void WriteCode()
    {
        Console.WriteLine("C++ Developer writes C++ code");
    }
}
