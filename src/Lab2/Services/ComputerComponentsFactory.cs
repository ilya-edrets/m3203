using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class ComputerComponentsFactory
{
    private readonly IFactory<Cpu> _cpuFactory;
    private readonly IFactory<Motherboard> _motherboardFactory;
    private readonly IFactory<RamStick> _ramStickFactory;

    public ComputerComponentsFactory(
        IFactory<Cpu> cpuFactory,
        IFactory<Motherboard> motherboardFactory,
        IFactory<RamStick> ramStickFactory)
    {
        _cpuFactory = cpuFactory;
        _motherboardFactory = motherboardFactory;
        _ramStickFactory = ramStickFactory;
    }

    public Cpu? CreateCpuByName(string name)
    {
        return _cpuFactory.CreateByName(name);
    }
}