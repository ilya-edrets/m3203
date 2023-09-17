using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public abstract class ShipBase
{
    protected ShipBase(EngineBase engine, ShellBase shell, DeflectorBase deflector, int fuelCapacity)
    {
        if (fuelCapacity <= 0)
        {
            throw new ArgumentException("fuelCapacity must be positive", nameof(fuelCapacity));
        }

        if (engine == null)
        {
            throw new ArgumentNullException(nameof(engine));
        }

        if (shell == null)
        {
            throw new ArgumentNullException(nameof(shell));
        }

        Deflector = deflector ?? new NullDeflector();

        Engine = engine;
        Shell = shell;
        this.FuelCapacity = fuelCapacity;
    }

    public EngineBase Engine { get; set; }

    public ShellBase Shell { get; set; }

    public DeflectorBase Deflector { get; set; }

    public int FuelCapacity { get; set; }

    public void TakeDamage(ObstacleBase obstacle)
    {
        obstacle ??= obstacle ?? throw new ArgumentNullException(nameof(obstacle));

        Deflector.TakeDamage(obstacle);
        Shell.TakeDamage(obstacle);

        this.IsShipDead = obstacle.IsAlive;
    }
}