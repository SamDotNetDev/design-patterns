namespace DeveloperTeamFactory;

public interface ITester
{
    void TestCode();
}

public class QATester : ITester
{
    public void TestCode()
    {
        Console.WriteLine("QA Tester tests Java Enterprise system");
    }
}

public class NativeTester : ITester
{
    public void TestCode()
    {
        Console.WriteLine("Native Tester tests C++ high-performance system");
    }
}
