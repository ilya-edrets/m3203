namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class ShellBase
{
    public ShellBase(int maxHitPoints)
    {
        // Валидация
        MaxHitPoints = maxHitPoints;
        CurrentHitPoints = maxHitPoints;
    }

    public int MaxHitPoints { get; }

    public bool IsAlive => this.CurrentHitPoints > 0;

    public int CurrentHitPoints { get; private set; }

    public void TakeDamage(ObstacleBase obstacle)
    {
        this.CurrentHitPoints -= obstacle.Damage;
    }
}