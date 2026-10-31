namespace ComputerBuilder;

public class Program
{
    public static void Main()
    {
        Computer office = new ComputerBuilder()
            .SetRam(8)
            .SetCpu(4)
            .SetGpu(8)
            .SetStorage(250)
            .Build();

        Computer gaming = new ComputerBuilder()
            .SetRam(32)
            .SetCpu(16)
            .SetGpu(24)
            .SetStorage(2000)
            .Build();

        Console.WriteLine(office);
        Console.WriteLine();
        Console.WriteLine(gaming);
    }
}
