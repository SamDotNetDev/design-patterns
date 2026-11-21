namespace DeveloperTeamFactory;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== 1. FACTORY METHOD ===");

        IDeveloperFactory cppFactory = CreateDeveloperFactoryBySpeciality("C++");
        cppFactory.CreateDeveloper().WriteCode();

        IDeveloperFactory javaFactory = CreateDeveloperFactoryBySpeciality("Java");
        javaFactory.CreateDeveloper().WriteCode();

        Console.WriteLine();
        Console.WriteLine("=== 2. ABSTRACT FACTORY ===");

        Console.WriteLine("-> Banking Team loyihasi:");
        RunTeam(new BankingTeamFactory());

        Console.WriteLine();
        Console.WriteLine("-> System OS Team loyihasi:");
        RunTeam(new SystemTeamFactory());
    }

    private static void RunTeam(IProjectTeamFactory factory)
    {
        factory.CreateDeveloper().WriteCode();
        factory.CreateTester().TestCode();
        factory.CreateProjectManager().ManageProject();
    }

    private static IDeveloperFactory CreateDeveloperFactoryBySpeciality(string speciality)
    {
        return speciality.ToLower() switch
        {
            "java" => new JavaDeveloperFactory(),
            "c++" => new CppDeveloperFactory(),
            _ => throw new ArgumentException($"{speciality} noma'lum mutaxassislik")
        };
    }
}
