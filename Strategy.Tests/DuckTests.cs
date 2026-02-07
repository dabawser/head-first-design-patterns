using Strategy.Behaviors;
using Strategy.Models;

namespace Strategy.Tests;

public class DuckTests
{
    [Fact]
    public void SetFlyBehavior_WhenCalled_ThenUpdatesFlyBehavior()
    {
        // Arrange
        var mallardDuck = new MallardDuck();
        var flyWithRocket = new FlyRocketPowered();

        // Act
        mallardDuck.SetFlyBehavior(flyWithRocket);
        var fly = mallardDuck.PerformFly();

        // Assert
        Assert.Equal("I'm flying with a rocket!", fly);
    }

    [Fact]
    public void SetQuackBehavior_WhenCalled_ThenUpdatesQuackBehavior()
    {
        // Arrange
        var mallardDuck = new MallardDuck();
        var squeak = new Squeak();

        // Act
        mallardDuck.SetQuackBehavior(squeak);
        var quack = mallardDuck.PerformQuack();

        // Assert
        Assert.Equal("Squeak", quack);
    }

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
    public void MallardDuck_WhenSwim_ThenFloats()
    {
        // Arrange
        var mallardDuck = new MallardDuck();

        // Act
        var swim = mallardDuck.Swim();

        // Assert
        Assert.Equal("All ducks float!", swim);
    }

    [Fact]
    public void MallardDuck_WhenDisplay_ThenShowsMallardDescription()
    {
        // Arrange
        var mallardDuck = new MallardDuck();

        // Act
        var display = mallardDuck.Display();

        // Assert
        Assert.Equal("I'm a real Mallard duck", display);
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
    public void RedheadDuck_WhenSwim_ThenFloats()
    {
        // Arrange
        var redheadDuck = new RedheadDuck();

        // Act
        var swim = redheadDuck.Swim();

        // Assert
        Assert.Equal("All ducks float!", swim);
    }

    [Fact]
    public void RedheadDuck_WhenDisplay_ThenShowsRedheadDescription()
    {
        // Arrange
        var redheadDuck = new RedheadDuck();

        // Act
        var display = redheadDuck.Display();

        // Assert
        Assert.Equal("I'm a real Redhead duck", display);
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
    public void RubberDuck_WhenSwim_ThenFloats()
    {
        // Arrange
        var rubberDuck = new RubberDuck();

        // Act
        var swim = rubberDuck.Swim();

        // Assert
        Assert.Equal("All ducks float!", swim);
    }

    [Fact]
    public void RubberDuck_WhenDisplay_ThenShowsRubberDuckDescription()
    {
        // Arrange
        var rubberDuck = new RubberDuck();

        // Act
        var display = rubberDuck.Display();

        // Assert
        Assert.Equal("I'm a rubber duckie", display);
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

    [Fact]
    public void DecoyDuck_WhenSwim_ThenFloats()
    {
        // Arrange
        var decoyDuck = new DecoyDuck();

        // Act
        var swim = decoyDuck.Swim();

        // Assert
        Assert.Equal("All ducks float!", swim);
    }

    [Fact]
    public void DecoyDuck_WhenDisplay_ThenShowsDecoyDescription()
    {
        // Arrange
        var decoyDuck = new DecoyDuck();

        // Act
        var display = decoyDuck.Display();

        // Assert
        Assert.Equal("I'm a decoy duck", display);
    }
}
