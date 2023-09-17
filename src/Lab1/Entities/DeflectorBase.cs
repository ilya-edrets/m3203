namespace Itmo.ObjectOrientedProgramming.Lab1.Entities;

public class DeflectorBase
{
    public DeflectorBase(int maxHitPoints)
    {
        // Валидация
        MaxHitPoints = maxHitPoints;
        CurrentHitPoints = maxHitPoints;
    }

    public int MaxHitPoints { get; }

    public bool IsAlive => this.CurrentHitPoints > 0;

    public int CurrentHitPoints { get; private set; }

    public virtual void TakeDamage(ObstacleBase obstacle)
    {
        var actual = this.CurrentHitPoints > obstacle.Damage ? obstacle.Damage : this.CurrentHitPoints;
        this.CurrentHitPoints -= actual;
        obstacle.TakeDamage(actual);
    }
}