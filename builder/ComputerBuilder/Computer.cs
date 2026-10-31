namespace ComputerBuilder;

public class Computer
{
    public int Ram { get; }
    public int Cpu { get; }
    public int Gpu { get; }
    public int Storage { get; }

    // Faqat ComputerBuilder orqali yaratiladi
    internal Computer(int ram, int cpu, int gpu, int storage)
    {
        Ram = ram;
        Cpu = cpu;
        Gpu = gpu;
        Storage = storage;
    }

    public override string ToString()
    {
        return "Computer:" +
               $"\n ram: {Ram}gb" +
               $"\n cpu: {Cpu}" +
               $"\n gpu: {Gpu}" +
               $"\n storage: {Storage}gb";
    }
}
