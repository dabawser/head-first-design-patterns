using Strategy.Models;

namespace Strategy.Tests;

public class DuckTests
{
    [Fact]
    public void MallardDuck_WhenPerformQuack_ThenRealQuack()
    {
        // Arrange
        var mallardDuck = new MallardDuck();

        // Act
        var quack = mallardDuck.PerformQuack();

        // Assert
        Assert.Equal("Quack", quack);
    }

    [Fact]
    public void MallardDuck_WhenPerformFly_ThenFliesWithWings()
    {
        // Arrange
        var mallardDuck = new MallardDuck();

        // Act
        var fly = mallardDuck.PerformFly();

        // Assert
        Assert.Equal("I'm flying!!", fly);
    }

    [Fact]
    public void RedheadDuck_WhenPerformQuack_ThenRealQuack()
    {
        // Arrange
        var redheadDuck = new RedheadDuck();

        // Act
        var quack = redheadDuck.PerformQuack();

        // Assert
        Assert.Equal("Quack", quack);
    }

    [Fact]
    public void RedheadDuck_WhenPerformFly_ThenFliesWithWings()
    {
        // Arrange
        var redheadDuck = new RedheadDuck();

        // Act
        var fly = redheadDuck.PerformFly();

        // Assert
        Assert.Equal("I'm flying!!", fly);
    }

    [Fact]
    public void RubberDuck_WhenPerformQuack_ThenSqueaks()
    {
        // Arrange
        var rubberDuck = new RubberDuck();

        // Act
        var quack = rubberDuck.PerformQuack();

        // Assert
        Assert.Equal("Squeak", quack);
    }

    [Fact]
    public void RubberDuck_WhenPerformFly_ThenCannotFly()
    {
        // Arrange
        var rubberDuck = new RubberDuck();

        // Act
        var fly = rubberDuck.PerformFly();

        // Assert
        Assert.Equal("I can't fly", fly);
    }

    [Fact]
    public void DecoyDuck_WhenPerformQuack_ThenSilent()
    {
        // Arrange
        var decoyDuck = new DecoyDuck();

        // Act
        var quack = decoyDuck.PerformQuack();

        // Assert
        Assert.Equal("<< Silence >>", quack);
    }

    [Fact]
    public void DecoyDuck_WhenPerformFly_ThenCannotFly()
    {
        // Arrange
        var decoyDuck = new DecoyDuck();

        // Act
        var fly = decoyDuck.PerformFly();

        // Assert
        Assert.Equal("I can't fly", fly);
    }
}