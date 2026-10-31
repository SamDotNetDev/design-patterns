namespace ComputerBuilder;

public class ComputerBuilder
{
    private int _ram;
    private int _cpu;
    private int _gpu;
    private int _storage;

    public ComputerBuilder SetRam(int ram)
    {
        _ram = ram;
        return this;
    }

    public ComputerBuilder SetCpu(int cpu)
    {
        _cpu = cpu;
        return this;
    }

    public ComputerBuilder SetGpu(int gpu)
    {
        _gpu = gpu;
        return this;
    }

    public ComputerBuilder SetStorage(int storage)
    {
        _storage = storage;
        return this;
    }

    public Computer Build()
    {
        return new Computer(_ram, _cpu, _gpu, _storage);
    }
}
