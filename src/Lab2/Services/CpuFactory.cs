using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;

public class CpuFactory : IFactory<Cpu>
{
    private readonly ICollection<Cpu> _cpuList;

    // public CpuFactory()
    // {
    //     _cpuList = new List<Cpu>();
    //
    //     _cpuList.Add(new Cpu { Name = "Intel i7 13600K" });
    //     _cpuList.Add(new Cpu { Name = "Intel i5 13500K" });
    //     _cpuList.Add(new Cpu { Name = "Intel i3 13100" });
    //     _cpuList.Add(new Cpu { Name = "Intel i3 12100" });
    // }

    public CpuFactory(ICollection<Cpu> cpuList)
    {
        _cpuList = cpuList;
    }

    public Cpu? CreateByName(string name)
    {
        return _cpuList
            .FirstOrDefault(cpu => cpu.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            .Copy();
    }
}