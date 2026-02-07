using Strategy.Behaviors;

namespace Strategy.Tests;

public class FlyBehaviorTests
{
    [Fact]
    public void FlyWithWings_WhenPerformFly_ThenReturnsFlying()
    {
        // Arrange
        var flyBehavior = new FlyWithWings();

        // Act
        var result = flyBehavior.PerformFly();

        // Assert
        Assert.Equal("I'm flying!!", result);
    }

    [Fact]
    public void FlyNoWay_WhenPerformFly_ThenReturnsCantFly()
    {
        // Arrange
        var flyBehavior = new FlyNoWay();

        // Act
        var result = flyBehavior.PerformFly();

        // Assert
        Assert.Equal("I can't fly", result);
    }

    [Fact]
    public void FlyRocketPowered_WhenPerformFly_ThenReturnsFlyingWithRocket()
    {
        // Arrange
        var flyBehavior = new FlyRocketPowered();

        // Act
        var result = flyBehavior.PerformFly();

        // Assert
        Assert.Equal("I'm flying with a rocket!", result);
    }
}
