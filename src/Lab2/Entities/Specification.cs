using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities;

public class Specification
{
    public string CpuName { get; set; }

    public string MotherboardName { get; set; }

    public List<string> RamSticks { get; set; }
}