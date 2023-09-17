using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;

public class ShipTests
{
    [Fact]
    public void TakeSmallDamage()
    {
        // Arrange
        var ship = new Ship();
        var obstacle = new Asteroid();

        // Act
        ship.TakeDamage(obstacle);

        // Assert
        Assert.True(ship.IsAlive);
    }

    [Theory]
    [InlineData(100, 20)]
    [InlineData(200, 20)]
    [InlineData(2, 1)]
    [InlineData(1, 0)]
    public void TakeHugeDamage(int maxHP, int damage)
    {
        // Arrange
        var ship = new Ship(maxHP);
        var obstacle = new Asteroid(damage);

        // Act
        ship.TakeDamage(obstacle);

        // Assert
        Assert.True(ship.IsAlive);
        Assert.False(obstacle.IsDead);
    }
}