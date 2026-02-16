using Decorator.Coffees;
using Decorator.Condiments;

namespace Decorator.Tests;

public class CondimentsDecoratorTests
{
    [Fact]
    public void DarkRoastWithMilk_WhenGetDescriptionCalled_ReturnsDescriptionOfEntireBeverage()
    {
        // Arrange
        var darkRoast = new DarkRoast();
        var milk = new Milk(darkRoast);

        // Act
        var description = milk.GetDescription();

        // Assert
        Assert.Equal("Dark Roast, Milk", description);
    }

    [Fact]
    public void DarkRoastWithMilk_WhenCostCalled_ReturnsTotalCostOfBeverage()
    {
        // Arrange
        var houseBlend = new HouseBlend();
        var milk = new Milk(houseBlend);

        // Act
        var description = milk.GetDescription();
        var cost = milk.Cost();

        // Assert
        Assert.Equal("House Blend, Milk", description);
        Assert.Equal(1.08m, cost);
    }

    [Fact]
    public void DecafWithMilkAndMocha_WhenGetDescriptionCalled_ReturnsDescriptionOfEntireBeverage()
    {
        // Arrange
        var decaf = new Decaf();
        var decafMocha = new Mocha(decaf);
        var decafMochaMilk = new Milk(decafMocha);

        // Act
        var description = decafMochaMilk.GetDescription();
        var cost = decafMochaMilk.Cost();

        // Assert
        Assert.Equal("Decaf, Mocha, Milk", description);
        Assert.Equal(1.44m, cost);
    }

    [Fact]
    public void EspressoWithMilkAndMochaAndSoyAndWhip_WhenCostCalled_ReturnsTotalCostOfBeverage()
    {
        // Arrange
        var espresso = new Espresso();
        var espressoMilk = new Milk(espresso);
        var espressoMilkMocha = new Mocha(espressoMilk);
        var espressoMilkMochaSoy = new Soy(espressoMilkMocha);
        var espressoMilkMochaSoyWhip = new Whip(espressoMilkMochaSoy);

        // Act
        var description = espressoMilkMochaSoyWhip.GetDescription();
        var cost = espressoMilkMochaSoyWhip.Cost();

        // Assert
        Assert.Equal("Espresso, Milk, Mocha, Soy, Whip", description);
        Assert.Equal(2.63m, cost);
    }
}
