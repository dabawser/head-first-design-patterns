using Strategy.Behaviors;

namespace Strategy.Tests;

public class QuackBehaviorTests
{
    [Fact]
    public void Quack_WhenPerformQuack_ThenReturnsQuack()
    {
        // Arrange
        var quackBehavior = new Quack();

        // Act
        var result = quackBehavior.PerformQuack();

        // Assert
        Assert.Equal("Quack", result);
    }

    [Fact]
    public void Squeak_WhenPerformQuack_ThenReturnsSqueak()
    {
        // Arrange
        var squeakBehavior = new Squeak();

        // Act
        var result = squeakBehavior.PerformQuack();

        // Assert
        Assert.Equal("Squeak", result);
    }

    [Fact]
    public void MuteQuack_WhenPerformQuack_ThenReturnsSilence()
    {
        // Arrange
        var muteQuackBehavior = new MuteQuack();

        // Act
        var result = muteQuackBehavior.PerformQuack();

        // Assert
        Assert.Equal("<< Silence >>", result);
    }
}
